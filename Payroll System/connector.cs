using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Payroll_System
{
    internal class Connector
    {
        private SqlConnection con;

        public void connection()
        {
            string cs = "Data Source=R3NZ\\SQLEXPRESS;Initial Catalog=Payroll_db;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            try
            {
                con = new SqlConnection(cs);
                con.Open();
                
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



        public void LoadEmployeeNames(ComboBox cmbname)
        {
           connection();

            
                try
                {
                    string query = "SELECT employee_id, (first_name + ' ' + last_name) AS FullName FROM employee";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbname.DataSource = dt;
                    cmbname.DisplayMember = "FullName";   // What user sees
                    cmbname.ValueMember = "employee_id";  // The actual value behind each item
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            
        }



        public void DisplayEmployeeSalary(int employeeID, Label salaryLabel,Label sss)
        {
            connection();
            string query = "SELECT salary FROM employee WHERE employee_id = @id";
            string query1 = "SELECT sss FROM deduction WHERE sss = @sss";
            using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", employeeID);
                   

                try
                    {
                        
                        object result = cmd.ExecuteScalar(); 
                        con.Close();
                    if (result != null && result != DBNull.Value)
                    {
                        salaryLabel.Text = "₱" + Convert.ToDecimal(result).ToString("N2");
                        sss.Text = "₱" + Convert.ToDecimal(result).ToString("N2");
                    }
                    else
                    {
                        salaryLabel.Text = "No salary found";
                        sss.Text = "No salary found";

                    }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading salary: " + ex.Message);
                    }
                    
                }
            
        }



    }
}
