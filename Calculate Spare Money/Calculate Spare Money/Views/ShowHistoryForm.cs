using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using Calculate_Spare_Money.Views;

namespace Calculate_Spare_Money
{
    public partial class ShowHistoryForm : Form
    {
        string[,] currentBills = new string[100, 3];

        int arrayCount = 0;

        public ShowHistoryForm()
        {
            InitializeComponent();
            
            DateTime dateCalc = DateTime.Now, calStart = DateTime.Now, calEnd = DateTime.Now;
           decimal budget = 0;
            using (SqlConnection conn = new SqlConnection(Main.CSTR))
            {
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand("Select * From Log_Info", conn);

                SqlDataReader dataReader = sqlCmd.ExecuteReader();

                while (dataReader.Read())
                {
                    dateCalc = dataReader.GetDateTime(0);
                    calStart = dataReader.GetDateTime(1);
                    calEnd = dataReader.GetDateTime(2);
                    budget = dataReader.GetDecimal(3);
                }
                dataReader.Close();

                //NEW STATEMENT  
                sqlCmd.CommandText = "Select * From Log_BillsCurrent Order By DueDate;"; //TODO: Order by closest bill
                dataReader = sqlCmd.ExecuteReader();

                while (dataReader.Read())
                {
                    currentBills[arrayCount, 0] = dataReader.GetString(0); //Bill
                    currentBills[arrayCount, 1] = dataReader.GetDecimal(1).ToString("C2"); //Amount
                    currentBills[arrayCount, 2] = dataReader.GetInt32(2).ToString(); //DueDate
                    arrayCount++;
                }
                dataReader.Close();

                conn.Close();
            }
            Console.WriteLine(budget);
            lblDateCalculated.Text = "Date Calculated: " + dateCalc.ToShortDateString();
            lblForDates.Text = "For Dates: " + calStart.ToLongDateString() + " THROUGH " + calEnd.ToLongDateString();
            lblBudget.Text = budget.ToString("C2");

            //Sort Array by due date
            int currentDay = DateTime.Now.Day;

            string tempBill = "", tempAmount = "", tempDueDate = "";

            for (int i = 0; i < arrayCount; i++) //Looping through each bill (curentBills array)
            {
                Console.WriteLine("(" + currentBills[i, 2] + " < " + currentDay + " = " + (int.Parse(currentBills[i, 2]) < currentDay) + " && ");
                Console.WriteLine(currentBills[i, 2] + " > " + calStart.Day + " = " + (int.Parse(currentBills[i, 2]) > calStart.Day) + ")");
                Console.WriteLine(" || ");
                Console.WriteLine("(" + currentBills[i, 2] + " > " + currentDay + " = " + (int.Parse(currentBills[i, 2]) > currentDay) + " && ");
                Console.WriteLine(currentBills[i, 2] + " > " + calEnd.Day + " = " + (int.Parse(currentBills[i, 2]) > calEnd.Day) + ")");

                if (int.Parse(currentBills[i, 2]) < currentDay && (int.Parse(currentBills[i,2]) >= calStart.Day || (int.Parse(currentBills[i, 2]) < currentDay && int.Parse(currentBills[i, 2]) > calEnd.Day)))
                {
                    currentBills[i, 0] = "  *OVERDUE* " + currentBills[i, 0];

                    tempBill = currentBills[i, 0];
                    tempAmount = currentBills[i, 1];
                    tempDueDate = currentBills[i, 2]; //Keep track of record to be focused on

                    for (int j = i; j > 0; j--) //remove current and shift all other items
                    {
                        currentBills[j, 0] = currentBills[j - 1, 0];
                        currentBills[j, 1] = currentBills[j - 1, 1];
                        currentBills[j, 2] = currentBills[j - 1, 2];
                    }
                    currentBills[0, 0] = tempBill;
                    currentBills[0, 1] = tempAmount;
                    currentBills[0, 2] = tempDueDate;
                }
            }
            //////////////////////////////


            for (int i = 0; i < arrayCount; i++)
            {
                listCurrentBills.Items.Add(currentBills[i, 0] + " -  " + currentBills[i, 1] + " -  Due on: " + currentBills[i, 2]);
            }


        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;               
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Main.CSTR))
            {
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand("Delete Log_BillsCurrent Where Bill = @bill;", conn);
                SqlParameter bill = sqlCmd.Parameters.Add("@bill", SqlDbType.VarChar);

                string[] checkedItems = new string[listCurrentBills.CheckedItems.Count];
                listCurrentBills.CheckedItems.CopyTo(checkedItems, 0);

                int currentBillNameCount = arrayCount;
                string[] currentBillName = new string[arrayCount];
                
                for (int i = 0; i < arrayCount; i++)
                {
                    currentBillName[i] = currentBills[i, 0];
                }

                int listBoxCount = listCurrentBills.CheckedItems.Count;
                for (int i = 0; i < listBoxCount; i++)
                {

                    for (int j = 0; j < currentBillNameCount; j++)
                    {
                        if (checkedItems[i].Contains(currentBillName[j]))
                        {
                            listCurrentBills.Items.Remove(checkedItems[i]);
                            if (currentBillName[j].StartsWith("  *OVERDUE* "))
                            {
                                bill.Value = currentBillName[j].Remove(0, 12);
                            }
                            else
                            {
                                bill.Value = currentBillName[j];
                            }
                            if (sqlCmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show(bill.Value + " is Paid!");
                            }
                            break;
                        }
                    }
                }

                conn.Close();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Main.CSTR))
            {
                conn.Open();

                double budget = 0;

                if (double.TryParse(txtPlus.Text, out budget))
                {
                    SqlCommand sqlCmd = new SqlCommand("Update Log_Info Set Budget = (Budget + @newBudget)", conn);
                    SqlParameter newBudget = sqlCmd.Parameters.Add("@newbudget", SqlDbType.Decimal);
                    newBudget.Value = budget;

                    if (sqlCmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Added " + budget.ToString() + " to the budget.");
                        double updatedBudget = double.Parse(lblBudget.Text.TrimStart('$')) + budget;
                        lblBudget.Text = updatedBudget.ToString("C2");
                    }
                }
                else
                {
                    MessageBox.Show("Type an amount to add to the budget. ");
                }

                conn.Close();
            }
            txtPlus.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Main.CSTR))
            {
                conn.Open();

                double budget = 0;

                if (double.TryParse(txtMinus.Text, out budget))
                {
                    SqlCommand sqlCmd = new SqlCommand("Update Log_Info Set Budget = (Budget - @newBudget)", conn);
                    SqlParameter newBudget = sqlCmd.Parameters.Add("@newbudget", SqlDbType.Decimal);
                    newBudget.Value = budget;

                    if (sqlCmd.ExecuteNonQuery() > 0)
                    { 
                        MessageBox.Show("Subtracted " + budget.ToString() + " from the budget.");
                        double updatedBudget = double.Parse(lblBudget.Text.TrimStart('$')) - budget;
                        lblBudget.Text = updatedBudget.ToString("C2");
                    }
                }
                else
                {
                    MessageBox.Show("Type an amount to subtract from the budget. ");
                }

                conn.Close();
            }
            txtMinus.Clear();
        }

        private void txtPlus_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnPlus;
        }

        private void txtPlus_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void txtMinus_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnMinus;
        }

        private void txtMinus_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void listCurrentBills_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnPaid;
        }

        private void listCurrentBills_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            FrmAddToLog frmAddToLog = new FrmAddToLog();
            frmAddToLog.ShowDialog();
        }
    }
}
