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
using Calculate_Spare_Money.Models;

namespace Calculate_Spare_Money
{
    public partial class te : Form
    {
        public te()
        {
            InitializeComponent();
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

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            string name = "";
            int monthlyDueDate = 0;
            double amount = 0.0;
            bool error = false;

            if (txtAddName.Text != "")
            {
                name = txtAddName.Text;
            }
            else
            {
                MessageBox.Show("Enter a name for the bill.");
                error = true;
            }

            if (double.TryParse(txtAddAmount.Text, out amount)) { }
            else
            {
                MessageBox.Show("Enter an amount for the bill. (Ex. 100 or 100.00)");
                error = true;
            }

            if (int.TryParse(txtAddMonthlyDueDate.Text, out monthlyDueDate)) { }
            else
            {
                MessageBox.Show("Enter a date using 1-2 numerical digits. (Ex. 4 or 23)");
                error = true;
            }

            if (!error)
            {
                using (SqlConnection conn = new SqlConnection(SQLFetch.connectionString))
                {
                    conn.Open();

                    SqlCommand sqlCommand = new SqlCommand("Insert Into billsT(BillDesc, Amount, DueDate) Values (@name, @amount, @dueDate);", conn);
                    SqlParameter nameParam = sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar);
                    SqlParameter amountParam = sqlCommand.Parameters.Add("@amount", SqlDbType.SmallMoney);
                    SqlParameter monthlyDueDateParam = sqlCommand.Parameters.Add("@dueDate", SqlDbType.Int);

                    nameParam.Value = name;
                    amountParam.Value = amount;
                    monthlyDueDateParam.Value = monthlyDueDate;

                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Added " + txtAddName.Text + " to bills.");
                    }
                    else
                    {
                        MessageBox.Show("Error. Failed to add " + txtAddName.Text + " to bills. Try again.");
                    }

                    conn.Close();
                }

                txtAddAmount.Clear();
                txtAddName.Clear();
                txtAddMonthlyDueDate.Clear();
                txtAddName.Focus();
            }
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

        private void btnTabAdd_Click(object sender, EventArgs e)
        {
            if (!lblAddName.Visible) //DELETE TAB CURRENT
            {
                listBills.Hide();
                btnDeleteBill.Hide();
                
                tabAdd.BackColor = Color.Silver;
                tabAdd.ForeColor = Color.Black;

                tabDelete.BackColor = SystemColors.ControlDarkDark;
                tabDelete.ForeColor = Color.FromArgb(224, 224, 224);

                lblAddName.Show();
                lblAddAmount.Show();
                lblAddMonthlyDueDate.Show();
                txtAddName.Show();
                txtAddAmount.Show();
                txtAddMonthlyDueDate.Show();
                btnAddBill.Show();
                lblDollarSign.Show();

                txtAddName.Focus();
            }
        }

        private void tabDelete_Click(object sender, EventArgs e)
        {
            if (lblAddName.Visible)//ADD TAB CURRENT
            {
                lblAddName.Hide();
                lblAddAmount.Hide();
                lblAddMonthlyDueDate.Hide();
                txtAddName.Hide();
                txtAddAmount.Hide();
                txtAddMonthlyDueDate.Hide();
                btnAddBill.Hide();
                lblDollarSign.Hide();

                tabDelete.BackColor = Color.Silver;
                tabDelete.ForeColor = Color.Black;

                tabAdd.BackColor = SystemColors.ControlDarkDark;
                tabAdd.ForeColor = Color.FromArgb(224, 224, 224);

                using (SqlConnection conn = new SqlConnection(Main.CSTR))
                {
                    conn.Open();

                    SqlCommand sqlCommand = new SqlCommand("Select BillDesc From billsT Order By BillDesc;", conn);

                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    listBills.Items.Clear();
                    while (dataReader.Read())
                    {                       
                        listBills.Items.Add(dataReader.GetString(0));
                    }
                    conn.Close();
                }

                listBills.Show();
                btnDeleteBill.Show();
            }
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            if (listBills.CheckedItems.Count > 0) //If user has items selected
            {
                using (SqlConnection conn = new SqlConnection(Main.CSTR))
                {
                    conn.Open();

                    SqlCommand sqlCommand = new SqlCommand("Delete billsT Where BillDesc = @BillDesc;", conn);
                    SqlParameter billDesc = sqlCommand.Parameters.Add("@BillDesc", SqlDbType.VarChar);

                    string[] bills = new string[150];
                    listBills.CheckedItems.CopyTo(bills, 0);

                    int count = 0;
                    int listCount = listBills.CheckedItems.Count;
                    for (int i = 0; i < listCount; i++)
                    {
                        listBills.Items.Remove(bills[i]);
                        billDesc.Value = bills[i];
                        sqlCommand.ExecuteNonQuery();
                        count++;
                    }
                    MessageBox.Show("Removed " + count + " bill(s).");

                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("You have no bills selected");
            }
        }

        private void tabDelete_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnDeleteBill;
        }

        private void tabAdd_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnAddBill;
        }

        private void txtAddName_Enter(object sender, EventArgs e)
        {
            txtAddName.SelectAll();
        }

        private void txtAddAmount_Enter(object sender, EventArgs e)
        {
            txtAddAmount.SelectAll();
        }

        private void txtAddMonthlyDueDate_Enter(object sender, EventArgs e)
        {
            txtAddMonthlyDueDate.SelectAll();
        }
    }
}
