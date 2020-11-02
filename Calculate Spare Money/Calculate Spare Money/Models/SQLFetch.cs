using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Calculate_Spare_Money.Models
{
    class SQLFetch
    {

        public const string connectionString = "server=(local)\\SQLEXPRESS01;database=Bills;Integrated Security=SSPI;";
        private SqlCommand _sqlCommand;        

        public SQLFetch()
        {

        }
        public SQLFetch(string sqlCommand)
        {
            _sqlCommand = new SqlCommand(sqlCommand);
        }

        public void setSqlCommand(string sqlCommand)
        {
            _sqlCommand = new SqlCommand(sqlCommand); ;
        }

        public void setParameter(string paramReference, SqlDbType sqlDbType, string value)
        {
            _sqlCommand.Parameters.Add(paramReference, sqlDbType).Value = value;
        }
    }

}
