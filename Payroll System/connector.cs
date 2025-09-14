using System;
using System.Data.SqlClient;

namespace Payroll_System
{
    internal class Connector
    {
        private SqlConnection con;

        public void connection()
        {
            string cs = "Data Source=R3NZ\\SQLEXPRESS;" +
                        "Initial Catalog=Payroll_db;" +
                        "Integrated Security=True;" +
                        "Encrypt=True;" +
                        "TrustServerCertificate=True;";

            try
            {
                con = new SqlConnection(cs);
                con.Open();
                MessageBox.Show("Connection successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }



        public void dataSend(string username, string password)
        {
            try
            {
                connection();  // open connection

                string sql = "INSERT INTO [user] (username, password) VALUES (@register_username, @register_password)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@register_username", username);
                    cmd.Parameters.AddWithValue("@register_password", password);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registration successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }



    }
}
