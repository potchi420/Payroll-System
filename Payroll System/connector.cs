using DocumentFormat.OpenXml.Bibliography;
using Org.BouncyCastle.Tls;
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
  Label overtime,
  Label salary)
        {

            double sssdeduction = 0.05;
            double phildeduction = 0.05;
            double pagibigdeduction = 0.05;
            connection(); // Opens your SQL connection

            string query = @"
   SELECT 
       e.first_name, 
       e.last_name,
       a.days_worked,
       a.overtimed_hour,
       e.salary
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
                            double salaryPerDay = Convert.ToDouble(reader["salary"]);


                            double totalSalary = dayWorked * salaryPerDay;
                            double overtimePay = overtimeHours * (salaryPerDay / 8) * 1.25; // 8-hour workday
                            double grossSalary = totalSalary + overtimePay;

                            double sssAmount = grossSalary * sssdeduction;
                            double philAmount = grossSalary * phildeduction;
                            double pagibigAmount = grossSalary * pagibigdeduction;
                            double totalDeductions = sssAmount + philAmount + pagibigAmount;
                            double netSalary = grossSalary - totalDeductions;

                            // Display values with ₱ and 2 decimal places
                            salary.Text = $"₱{salaryPerDay:N2}";
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
                            salary.Text = "₱N/A";
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
        public void LoadEmployeeBenefits(DataGridView dgv)
        {
            try
            {
                connection(); // open SQL connection

                // 1️⃣ Get employees
                string employeeQuery = "SELECT employee_id, first_name, last_name FROM employee";
                SqlDataAdapter empAdapter = new SqlDataAdapter(employeeQuery, con);
                DataTable empTable = new DataTable();
                empAdapter.Fill(empTable);

                // 2️⃣ Get benefits with status
                string benefitQuery = "SELECT benefit_type FROM BenefitCatalog";
                SqlDataAdapter benAdapter = new SqlDataAdapter(benefitQuery, con);
                DataTable benTable = new DataTable();
                benAdapter.Fill(benTable);

                // 3️⃣ Clear DataGridView
                dgv.Rows.Clear();
                dgv.Columns.Clear();

                // 4️⃣ Add Name column (TextBox)
                DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
                nameCol.HeaderText = "Name";
                nameCol.Name = "name";
                nameCol.ReadOnly = true;
                dgv.Columns.Add(nameCol);

                // 5️⃣ Add Benefit column (ComboBox)
                DataGridViewComboBoxColumn benefitCol = new DataGridViewComboBoxColumn();
                benefitCol.HeaderText = "Benefit";
                benefitCol.Name = "benefit_type";
                benefitCol.DataSource = benTable;
                benefitCol.DisplayMember = "benefit_type";
                benefitCol.ValueMember = "benefit_type";
                dgv.Columns.Add(benefitCol);

                // 6️⃣ Add Status column (ComboBox)
                DataGridViewComboBoxColumn statusCol = new DataGridViewComboBoxColumn();
                statusCol.HeaderText = "Status";
                statusCol.Name = "status";
                statusCol.Items.Add("Active");
                statusCol.Items.Add("Inactive");
                dgv.Columns.Add(statusCol);

                // 7️⃣ Add employee rows
                foreach (DataRow row in empTable.Rows)
                {
                    string fullName = row["first_name"].ToString() + " " + row["last_name"].ToString();
                    dgv.Rows.Add(fullName);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee benefits: " + ex.Message);
            }
        }


        public void DisplayBenefits(DataGridView dgv)
        {
            try
            {
                connection();

                string query = "SELECT benefit_id, benefit_type, description,default_amount FROM BenefitCatalog";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv.Rows.Clear(); // clear old data

                    foreach (DataRow row in dt.Rows)
                    {
                        dgv.Rows.Add(

                            row["benefit_id"].ToString(),
                            row["benefit_type"].ToString(),
                            row["description"].ToString(),
                            row["default_amount"].ToString()
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }




        public void AddBenefits(DataGridView dgv)
{
    try
    {
        connection();
        bool anyAdded = false;

        foreach (DataGridViewRow row in dgv.Rows)
        {
            if (row.IsNewRow) continue;

            string benefitType = row.Cells["benefit_type"].Value?.ToString();
            string description = row.Cells["description"].Value?.ToString();
            string amountText = row.Cells["default_amount"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(benefitType) || string.IsNullOrWhiteSpace(amountText))
                continue;

            double defaultAmount = double.Parse(amountText);

            // ✅ Check if this benefit already exists
            string checkQuery = @"SELECT COUNT(*) FROM BenefitCatalog 
                                  WHERE benefit_type = @type 
                                  AND CAST(description AS NVARCHAR(MAX)) = @desc";

            using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
            {
                checkCmd.Parameters.AddWithValue("@type", benefitType);
                checkCmd.Parameters.AddWithValue("@desc", description ?? "");
                int exists = (int)checkCmd.ExecuteScalar();

                if (exists == 0) // Only insert if not exists
                {
                    string insertQuery = @"INSERT INTO BenefitCatalog 
                                           (benefit_type, description, default_amount)
                                           VALUES (@type, @desc, @amount)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@type", benefitType);
                        insertCmd.Parameters.AddWithValue("@desc", description ?? "");
                        insertCmd.Parameters.AddWithValue("@amount", defaultAmount);
                        insertCmd.ExecuteNonQuery();
                    }

                    anyAdded = true;
                }
            }
        }

        if (anyAdded)
        {
            MessageBox.Show("New rows added successfully!");
            DisplayBenefits(dgv); // Refresh grid
        }
        else
        {
            MessageBox.Show("No new Benefits to add.");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error: " + ex.Message);
    }
    finally
    {
        con.Close();
    }
}


        public void EditBenefit(DataGridView dgv)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to edit.");
                    return;
                }

                DataGridViewRow row = dgv.SelectedRows[0];


                int benefitID = Convert.ToInt32(row.Cells["benefit_id"].Value);

                string description = row.Cells["description"].Value?.ToString();
                string benefitType = row.Cells["benefit_type"].Value?.ToString();
                string amountText = row.Cells["default_amount"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(benefitType) || string.IsNullOrWhiteSpace(amountText))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                double defaultAmount = double.Parse(amountText);

                connection(); // Open SQL connection

                string query = @"UPDATE BenefitCatalog
           SET benefit_type = @type,
                  description = @desc,
               default_amount = @amount
           WHERE benefit_id = @id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@desc", description ?? "");
                    cmd.Parameters.AddWithValue("@type", benefitType);
                    cmd.Parameters.AddWithValue("@amount", defaultAmount);
                    cmd.Parameters.AddWithValue("@id", benefitID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Record updated successfully!");
                    else
                        MessageBox.Show("No record found to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }





        public void DeleteBenefit(DataGridView dgv)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete.");
                    return;
                }

                DataGridViewRow row = dgv.SelectedRows[0];
                int benefitID = Convert.ToInt32(row.Cells["benefit_id"].Value); // unique key

                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    connection(); // open SQL connection

                    string query = "DELETE FROM BenefitCatalog WHERE benefit_id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", benefitID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Record deleted successfully!");

                    // Refresh the grid after deletion
                    DisplayBenefits(dgv); // reloads data from the database
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }





    }
}
