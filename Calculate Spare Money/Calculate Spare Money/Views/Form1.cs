using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Calculate_Spare_Money
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtBankAmount.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
            using (SqlConnection conn = new SqlConnection(Main.CSTR))
            {
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand("SELECT BillDesc, Cast(Amount AS decimal(7,2)) as Amount, DueDate, Paid FROM billsT ORDER BY DueDate;", conn);

                SqlDataAdapter adapt = new SqlDataAdapter(sqlCmd);
                adapt.SelectCommand = sqlCmd;

                DataTable datatab = new DataTable();
                adapt.Fill(datatab);

                BindingSource bind = new BindingSource();
                bind.DataSource = datatab;

                DataTableReader dataRead = new DataTableReader(datatab);
                Form2 f2 = new Form2();

                while (dataRead.Read())
                {                   
                    if (dataRead.GetString(3) == "n")
                    {
                        f2.billName = dataRead.GetString(0);
                        f2.lblPrompt.Text = "Have you paid \"" + dataRead.GetString(0) + "\"?";
                        f2.ShowDialog();
                    }
                }

                dataGridView1.DataSource = bind;

                datatab.Clear();
                adapt.Fill(datatab);

                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(Main.CSTR))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand("Select * From Log_Info", conn);

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    balance = dataReader.GetDecimal(3);
                }
            }
                txtBankAmount.Text = balance.ToString("F2"); ;
        } 

        int startSelection, endSelection;
        decimal balance;
        DateTime calStart, calEnd;

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            startSelection = monthCalendar1.SelectionRange.Start.Day;
            endSelection = monthCalendar1.SelectionRange.End.Day;

            calStart = monthCalendar1.SelectionStart.Date;
            calEnd = monthCalendar1.SelectionEnd.Date;
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            

            using (SqlConnection conn = new SqlConnection(Main.CSTR))
            {
                conn.Open();

                double budget = 0;

                if (double.TryParse(txtAddMoney.Text, out budget))
                {
                    balance = balance + (decimal)budget;
                    txtBankAmount.Text = balance.ToString("n2");
                    lblSpareMoney.Text = balance.ToString("c");

                    SqlCommand sqlCmd = new SqlCommand("Update Log_Info Set Budget = (Budget + @newBudget)", conn);
                    SqlParameter newBudget = sqlCmd.Parameters.Add("@newbudget", SqlDbType.Decimal);
                    newBudget.Value = budget;

                    sqlCmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Type an amount to add to the budget.");
                }

                conn.Close();
            }

            txtAddMoney.Clear();
            txtAddMoney.Focus();
        }

        private void btnSubtractMoney_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Main.CSTR))
            {
                conn.Open();

                double budget = 0;

                if (double.TryParse(txtSubtractMoney.Text, out budget))
                {
                    balance = balance - (decimal)budget;
                    txtBankAmount.Text = balance.ToString("n2");
                    lblSpareMoney.Text = balance.ToString("c");

                    SqlCommand sqlCmd = new SqlCommand("Update Log_Info Set Budget = (Budget - @newBudget)", conn);
                    SqlParameter newBudget = sqlCmd.Parameters.Add("@newbudget", SqlDbType.Decimal);
                    newBudget.Value = budget;

                    sqlCmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Type an amount to subtract from the budget. ");
                }

                conn.Close();
            }
            txtSubtractMoney.Clear();
            txtSubtractMoney.Focus();
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

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void txtBankAmount_Leave(object sender, EventArgs e)
        {
            if(decimal.TryParse(txtBankAmount.Text,out balance))
            {

            }
            else
            {
                MessageBox.Show("Cannot turn balance text box into a numeric decimal");
            }
        }

        private void txtAddMoney_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnAddMoney;
        }

        private void txtSubtractMoney_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnSubtractMoney;
        }

        private void txtSubtractMoney_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = btnCalculate;
        }

        private void txtAddMoney_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = btnCalculate;
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {          
                using (SqlConnection conn = new SqlConnection(Main.CSTR))
                {
                    conn.Open();

                    SqlCommand sqlCmd = new SqlCommand("IF @end >= @start BEGIN SELECT * FROM billsT WHERE DueDate >= @start AND DueDate <= @end ORDER BY DueDate END ELSE BEGIN  SELECT * FROM billsT WHERE DueDate >= @start UNION SELECT * FROM billsT WHERE DueDate <= @end ORDER BY DueDate END", conn);
                    SqlParameter start = sqlCmd.Parameters.Add("@start", SqlDbType.Int);
                    start.Value = startSelection;
                    SqlParameter end = sqlCmd.Parameters.Add("@end", SqlDbType.Int);
                    end.Value = endSelection;

                    SqlDataAdapter adapt = new SqlDataAdapter(sqlCmd);


                    DataTable datatab = new DataTable();
                    adapt.Fill(datatab);

                    BindingSource bind = new BindingSource();
                    bind.DataSource = datatab;

                    dataGridView1.DataSource = bind;
                    adapt.Update(datatab);

                    if (decimal.TryParse(txtBankAmount.Text, out balance)) { }
                    else
                    {
                        MessageBox.Show("Enter Balance in (0000.00) format.");
                        txtBankAmount.Clear();
                        txtBankAmount.Focus();
                    }

                    for (int count = 0; count < dataGridView1.RowCount; count++)
                    {
                        decimal billAmount = (decimal)(dataGridView1.Rows[count].Cells[1].Value);
                        balance = balance - billAmount;
                    }
                    lblSpareMoney.Text = balance.ToString("C");
                    txtBankAmount.Text = balance.ToString("n2");

                    //NEW STATEMENT
                    sqlCmd.CommandText = "Delete Log_Info;";
                        sqlCmd.ExecuteNonQuery();

                        sqlCmd.CommandText = "Insert Into Log_Info(DateCalc, CalStart, CalEnd, Budget) Values(GETDATE(), @start, @end, @budget);";
                        start.SqlDbType = SqlDbType.Date;
                        start.Value = calStart.Date;
                        end.SqlDbType = SqlDbType.Date;
                        end.Value = calEnd.Date;
                        SqlParameter budget = sqlCmd.Parameters.Add("@budget", SqlDbType.Decimal);
                        budget.Value = balance;
                        sqlCmd.ExecuteNonQuery();

                    //NEW STATEMENT
                    sqlCmd.CommandText = "Delete Log_BillsCurrent;";
                    sqlCmd.ExecuteNonQuery();

                    sqlCmd.CommandText = "Insert Into Log_BillsCurrent(Bill, Amount, DueDate) Values (@bill, @amount, @dueDate);";
                    sqlCmd.Parameters.Clear();
                    SqlParameter bill = sqlCmd.Parameters.Add("@bill", SqlDbType.VarChar);
                    SqlParameter amount = sqlCmd.Parameters.Add("@amount", SqlDbType.Int);
                    SqlParameter dueDate = sqlCmd.Parameters.Add("@dueDate", SqlDbType.Int);
                
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        bill.Value = dataGridView1.Rows[i].Cells[0].Value;
                        amount.Value = dataGridView1.Rows[i].Cells[1].Value;
                        dueDate.Value = dataGridView1.Rows[i].Cells[2].Value;
                        sqlCmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }
            
        }
    }
}
