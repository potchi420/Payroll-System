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



        public void DisplayEmployeeSalary(
     int employeeID,
     Label grosspay,
     Label sss,
     Label philhealth,
     Label pagibig,
     Label totaldeductions,
     Label netpay,
     Label overtime)
        {
            double salaryPerDay = 700;
            double sssdeduction = 0.05;
            double phildeduction = 0.05;
            double pagibigdeduction = 0.05;
            connection(); // Opens your SQL connection

            string query = @"
        SELECT 
            e.first_name, 
            e.last_name,
            a.days_worked,
            a.overtimed_hour
        FROM employee e
        INNER JOIN attendance a 
            ON e.employee_id = a.employee_id
        WHERE e.employee_id = @id";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", employeeID);

                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int dayWorked = Convert.ToInt32(reader["days_worked"]);
                            int overtimeHours = Convert.ToInt32(reader["overtimed_hour"]);

                            double totalSalary = dayWorked * salaryPerDay;
                            double overtimePay = overtimeHours * (salaryPerDay / 8) * 1.25; // 8-hour workday
                            double grossSalary = totalSalary + overtimePay;

                            double sssAmount = grossSalary * sssdeduction;
                            double philAmount = grossSalary * phildeduction;
                            double pagibigAmount = grossSalary * pagibigdeduction;
                            double totalDeductions = sssAmount + philAmount + pagibigAmount;
                            double netSalary = grossSalary - totalDeductions;

                            // Display values with ₱ and 2 decimal places
                            grosspay.Text = $"₱{grossSalary:N2}";
                            sss.Text = $"₱{sssAmount:N2}";
                            philhealth.Text = $"₱{philAmount:N2}";
                            pagibig.Text = $"₱{pagibigAmount:N2}";
                            totaldeductions.Text = $"₱{totalDeductions:N2}";
                            netpay.Text = $"₱{netSalary:N2}";
                            overtime.Text = $"₱{overtimePay:N2}";
                        }
                        else
                        {
                            grosspay.Text = "₱N/A";
                            sss.Text = "₱N/A";
                            philhealth.Text = "₱N/A";
                            pagibig.Text = "₱N/A";
                            totaldeductions.Text = "₱N/A";
                            netpay.Text = "₱N/A";
                            overtime.Text = "₱N/A";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading salary: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }






    }
}
