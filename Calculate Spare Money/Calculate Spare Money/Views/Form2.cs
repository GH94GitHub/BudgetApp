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
using System.Diagnostics;

namespace Calculate_Spare_Money
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string billName { get; set; }

        private void btnYes_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Main.CSTR))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand("update billsT SET Paid = \'y\' WHERE BillDesc = @name;", conn);
            
                SqlParameter name = sqlCommand.Parameters.Add("@name", SqlDbType.VarChar);
                name.Value = billName;

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("1 or more rows effected");
                }
                else
                {
                    Console.WriteLine("No Rows effected");
                }
                
                conn.Close();
            } 
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
