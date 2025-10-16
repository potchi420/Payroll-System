using System;
using System.Data;
using System.Data.SqlClient;

namespace Payroll_System
{
    internal class Connector
    {
        private SqlConnection con;

        public void connection()
        {
            string cs = "Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True";

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
                connection(); 

                string sql = "INSERT INTO [login] (username, password) VALUES (@register_username, @register_password)";
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

        public bool DataReceive(string username, string password)
        {
            try
            {
                connection();
                string sql = "SELECT COUNT(*) FROM [login] WHERE username = @user AND password = @pass";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    int count = (int)cmd.ExecuteScalar(); // returns number of matches
                    return count > 0; // true if found, false if not
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
        }




    }
}
