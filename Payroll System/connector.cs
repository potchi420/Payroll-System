using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_System
{
    internal class connector
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public string sql;

        public void connection()
        {
            con = new("Data Source=R3NZ\\SQLEXPRESS;Initial Catalog=payroll_db;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
        }

        public void dataSend()
        {
            connection();
            SqlDataAdapter adap = new SqlDataAdapter();
            sql = "insert into demo values(register_username=@username,register_password=@password)";
            cmd = new SqlCommand(sql, con);
            adap.InsertCommand = new SqlCommand(sql, con);
            adap.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }



    }
}
