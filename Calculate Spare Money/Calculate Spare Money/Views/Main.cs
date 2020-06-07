using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_Spare_Money
{
    public partial class Main : Form
    {
        public static string CSTR = "server=(local)\\SQLEXPRESS01;database=Bills;Integrated Security=SSPI;";
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            te formAddBill = new te();
            formAddBill.ShowDialog();
        }

        private void btnCalcBudget_Click(object sender, EventArgs e)
        {
            Form1 formCalculateBudget = new Form1();
            formCalculateBudget.ShowDialog();
        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            ShowHistoryForm formShowHistory = new ShowHistoryForm();
            formShowHistory.ShowDialog();
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
    }
}
