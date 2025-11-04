using DocumentFormat.OpenXml.Bibliography;
using Org.BouncyCastle.Tls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Payroll_System.Payroll_process;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Payroll_System
{
    internal class Connector
    {
        private SqlConnection con;
        PayslipData data = new PayslipData();

        public static class SessionData
        {
            public static int? EmployeeID { get; set; }
        }

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

        public (bool isValid, int? employeeId) DataReceive(string username, string password)
        {
            try
            {
                connection();
                string sql = "SELECT employee_id FROM [login] WHERE username = @user AND password = @pass";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        if (result != DBNull.Value)
                            return (true, Convert.ToInt32(result)); // employee login
                        else
                            return (true, null); // admin login
                    }
                    else
                    {
                        return (false, null); // login not found
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return (false, null);
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
                cmbname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbname.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmbname.SelectedIndex = -1;
                cmbname.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public PayslipData GetPayslipData(int employeeID)
        {
            PayslipData data = new PayslipData();

            double sssRate = 0.045;
            double philRate = 0.025;
            double pagibigRate = 0.02;

            connection(); // open SQL connection

            string query = @"
        SELECT 
            e.first_name, 
            e.last_name,
            d.department_name,
            a.days_worked,
            a.overtime_hours,
            e.salary
        FROM employee e
        INNER JOIN attendance a ON e.employee_id = a.employee_id
        LEFT JOIN department d ON e.department_id = d.department_id
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
                            int daysWorked = Convert.ToInt32(reader["days_worked"]);
                            int overtimeHours = Convert.ToInt32(reader["overtime_hours"]);
                            double dailyRate = Convert.ToDouble(reader["salary"]);

                            double basicPay = daysWorked * dailyRate;
                            double overtimePay = overtimeHours * (dailyRate / 8) * 1.25;
                            double gross = basicPay + overtimePay;

                            double sss = gross * sssRate;
                            double phil = gross * philRate;
                            double pagibig = gross * pagibigRate;
                            double totalDeductions = sss + phil + pagibig;
                            double net = gross - totalDeductions;

                            data.employeeID = employeeID;
                            data.FullName = reader["first_name"] + " " + reader["last_name"];
                            data.Department = reader["department_name"].ToString();
                            data.PayPeriodStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                            data.PayPeriodEnd = data.PayPeriodStart.AddMonths(1).AddDays(-1);
                            data.DaysWorked = daysWorked;
                            data.OvertimeHours = overtimeHours;
                            data.DailyRate = Convert.ToDecimal(dailyRate);
                            data.BasicPay = Convert.ToDecimal(basicPay);
                            data.GrossPay = Convert.ToDecimal(gross);
                            data.overtimePay = Convert.ToDecimal(overtimePay);
                            data.NetPay = Convert.ToDecimal(net);

                            data.Deductions.Add(("SSS", Convert.ToDecimal(sss)));
                            data.Deductions.Add(("PhilHealth", Convert.ToDecimal(phil)));
                            data.Deductions.Add(("Pag-IBIG", Convert.ToDecimal(pagibig)));

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving payslip data: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            return data;
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
     Label salary,
     DateTimePicker start_date,
     DateTimePicker end_date)
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
            a.overtime_hours,
            e.salary,
            a.start_date,
            a.end_date
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
                            // 🗓 Retrieve attendance period
                            DateTime startDate = Convert.ToDateTime(reader["start_date"]);
                            DateTime endDate = Convert.ToDateTime(reader["end_date"]);

                            // ✅ Show in DateTimePickers
                            start_date.Value = startDate;
                            end_date.Value = endDate;

                            // 📆 Attendance and salary info
                            int dayWorked = Convert.ToInt32(reader["days_worked"]);
                            int overtimeHours = Convert.ToInt32(reader["overtime_hours"]);
                            double salaryPerDay = Convert.ToDouble(reader["salary"]);

                            // 💰 Salary computation
                            double totalSalary = dayWorked * salaryPerDay;
                            double overtimePay = overtimeHours * (salaryPerDay / 8) * 1.25; // 8-hour day
                            double grossSalary = totalSalary + overtimePay;

                            double sssAmount = grossSalary * sssdeduction;
                            double philAmount = grossSalary * phildeduction;
                            double pagibigAmount = grossSalary * pagibigdeduction;
                            double totalDeductions = sssAmount + philAmount + pagibigAmount;
                            double netSalary = grossSalary - totalDeductions;

                            // 💵 Display in labels
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
                            // No record found
                            MessageBox.Show("No attendance record found for this employee.");

                            // Reset labels
                            grosspay.Text = sss.Text = philhealth.Text = pagibig.Text =
                            totaldeductions.Text = netpay.Text = overtime.Text = salary.Text = "₱N/A";

                            // Reset pickers
                            start_date.Value = DateTime.Today;
                            end_date.Value = DateTime.Today;
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



        public void SaveOrUpdatePayslip(
    int employeeID,
    DateTimePicker startDatePicker,
    DateTimePicker endDatePicker,
    double grossPay,
    double netPay,
    double taxWithheld)
        {
            connection();

            try
            {
                // Get values from DateTimePickers
                DateTime payPeriodStart = startDatePicker.Value;
                DateTime payPeriodEnd = endDatePicker.Value;

                // Check if a payslip already exists for this employee & period
                string checkQuery = @"
            SELECT COUNT(*) 
            FROM Payslip
            WHERE employee_id = @employee_id
              AND pay_period_start = @start
              AND pay_period_end = @end";

                int count = 0;
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@employee_id", employeeID);
                    checkCmd.Parameters.AddWithValue("@start", payPeriodStart);
                    checkCmd.Parameters.AddWithValue("@end", payPeriodEnd);
                    count = (int)checkCmd.ExecuteScalar();
                }

                if (count > 0)
                {
                    // Update existing record
                    string updateQuery = @"
                UPDATE Payslip
                SET gross_pay = @gross,
                    net_pay = @net,
                    tax_withheld = @tax,
                    created_at = @created
                WHERE employee_id = @employee_id
                  AND pay_period_start = @start
                  AND pay_period_end = @end";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@gross", (float)grossPay);
                        updateCmd.Parameters.AddWithValue("@net", (float)netPay);
                        updateCmd.Parameters.AddWithValue("@tax", (float)taxWithheld);
                        updateCmd.Parameters.AddWithValue("@created", DateTime.Now);
                        updateCmd.Parameters.AddWithValue("@employee_id", employeeID);
                        updateCmd.Parameters.AddWithValue("@start", payPeriodStart);
                        updateCmd.Parameters.AddWithValue("@end", payPeriodEnd);

                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Payslip updated successfully!");
                    }
                }
                else
                {
                    // Insert new record
                    string insertQuery = @"
                INSERT INTO Payslip 
                (employee_id, pay_period_start, pay_period_end, gross_pay, net_pay, tax_withheld, created_at)
                VALUES (@employee_id, @start, @end, @gross, @net, @tax, @created)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@employee_id", employeeID);
                        insertCmd.Parameters.AddWithValue("@start", payPeriodStart);
                        insertCmd.Parameters.AddWithValue("@end", payPeriodEnd);
                        insertCmd.Parameters.AddWithValue("@gross", (float)grossPay);
                        insertCmd.Parameters.AddWithValue("@net", (float)netPay);
                        insertCmd.Parameters.AddWithValue("@tax", (float)taxWithheld);
                        insertCmd.Parameters.AddWithValue("@created", DateTime.Now);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Payslip added successfully!");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving/updating payslip: " + ex.Message);
            }
            finally
            {
                con.Close();
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


        public void LoadEmployeeBenefits(DataGridView dgv)
        {
            try
            {
                connection(); // Open SQL connection

                // Get employees
                string employeeQuery = "SELECT employee_id, first_name, last_name FROM Employee";
                SqlDataAdapter empAdapter = new SqlDataAdapter(employeeQuery, con);
                DataTable empTable = new DataTable();
                empAdapter.Fill(empTable);

                // Get benefits
                string benefitQuery = "SELECT benefit_id, benefit_type, default_amount FROM BenefitCatalog";
                SqlDataAdapter benAdapter = new SqlDataAdapter(benefitQuery, con);
                DataTable benTable = new DataTable();
                benAdapter.Fill(benTable);
                if (benTable.PrimaryKey.Length == 0)
                    benTable.PrimaryKey = new DataColumn[] { benTable.Columns["benefit_id"] };

                // Get assigned benefits
                string assignedQuery = "SELECT employee_id, benefit_id, amount, status FROM AssignedBenefits";
                SqlDataAdapter assignedAdapter = new SqlDataAdapter(assignedQuery, con);
                DataTable assignedTable = new DataTable();
                assignedAdapter.Fill(assignedTable);

                // Clear grid
                dgv.Rows.Clear();
                dgv.Columns.Clear();
                dgv.AutoGenerateColumns = false;

                // Create columns
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "employee_id", Visible = false });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "employee_name", HeaderText = "Employee Name", ReadOnly = true });
                dgv.Columns.Add(new DataGridViewComboBoxColumn
                {
                    Name = "benefit_type",
                    HeaderText = "Benefit",
                    DataSource = benTable,
                    DisplayMember = "benefit_type",
                    ValueMember = "benefit_id"
                });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "benefit_id", Visible = false });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "amount", HeaderText = "Amount", ReadOnly = true });
                dgv.Columns.Add(new DataGridViewComboBoxColumn { Name = "status", HeaderText = "Status" });

                // Add employee rows
                foreach (DataRow emp in empTable.Rows)
                {
                    int rowIndex = dgv.Rows.Add();
                    DataGridViewRow row = dgv.Rows[rowIndex];

                    int employeeId = Convert.ToInt32(emp["employee_id"]);
                    string fullName = emp["first_name"].ToString() + " " + emp["last_name"].ToString();

                    row.Cells["employee_id"].Value = employeeId;
                    row.Cells["employee_name"].Value = fullName;

                    DataRow assigned = assignedTable.Select("employee_id = " + employeeId).FirstOrDefault();

                    // Set benefit
                    if (assigned != null)
                    {
                        row.Cells["benefit_type"].Value = assigned["benefit_id"];
                        row.Cells["benefit_id"].Value = assigned["benefit_id"];
                        row.Cells["amount"].Value = assigned["amount"];
                    }
                    else
                    {
                        row.Cells["benefit_type"].Value = benTable.Rows[0]["benefit_id"];
                        row.Cells["benefit_id"].Value = benTable.Rows[0]["benefit_id"];
                        row.Cells["amount"].Value = benTable.Rows[0]["default_amount"];
                    }

                    // Set status using a ComboBoxCell per row
                    var statusCell = new DataGridViewComboBoxCell();
                    statusCell.Items.Add("Active");
                    statusCell.Items.Add("Inactive");

                    string currentStatus = (assigned != null) ? assigned["status"].ToString().Trim() : "Active";
                    if (!statusCell.Items.Contains(currentStatus))
                        statusCell.Items.Add(currentStatus);

                    statusCell.Value = currentStatus;
                    row.Cells["status"] = statusCell;
                }

                // Handle benefit selection change
                dgv.EditingControlShowing += (s, e) =>
                {
                    if (dgv.CurrentCell.OwningColumn.Name == "benefit_type" && e.Control is ComboBox cb)
                    {
                        cb.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                        cb.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
                    }
                };

                void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
                {
                    ComboBox cb = sender as ComboBox;
                    if (cb.SelectedValue == null) return;

                    int selectedBenefitId;
                    if (!int.TryParse(cb.SelectedValue.ToString(), out selectedBenefitId)) return;

                    dgv.CurrentRow.Cells["benefit_id"].Value = selectedBenefitId;

                    DataRow found = benTable.Rows.Find(selectedBenefitId);
                    if (found != null)
                        dgv.CurrentRow.Cells["amount"].Value = found["default_amount"];
                }

                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee benefits: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void SaveAssignedBenefits(DataGridView dgv)
        {
            try
            {
                connection(); // Open SQL connection

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    int employeeId = Convert.ToInt32(row.Cells["employee_id"].Value);
                    int benefitId = Convert.ToInt32(row.Cells["benefit_id"].Value);
                    double amount = Convert.ToDouble(row.Cells["amount"].Value ?? 0);
                    string status = row.Cells["status"].Value?.ToString() ?? "Active";
                    DateTime dateAssigned = DateTime.Now.Date;

                    // Get latest payslip for this employee
                    int payslipId = 0;
                    string payslipQuery = @"
                SELECT TOP 1 payslip_id 
                FROM Payslip
                WHERE employee_id = @empId
                ORDER BY pay_period_end DESC";

                    using (SqlCommand cmdPayslip = new SqlCommand(payslipQuery, con))
                    {
                        cmdPayslip.Parameters.AddWithValue("@empId", employeeId);
                        object result = cmdPayslip.ExecuteScalar();
                        if (result != null)
                            payslipId = Convert.ToInt32(result);
                    }

                    if (payslipId == 0)
                    {
                        // If no payslip exists, insert a new benefit row without a payslip_id
                        string insertQuery = @"
                    INSERT INTO AssignedBenefits
                    (employee_id, benefit_id, amount, date_assigned, status)
                    VALUES
                    (@empId, @benefitId, @amount, @dateAssigned, @status)";

                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                        {
                            insertCmd.Parameters.AddWithValue("@empId", employeeId);
                            insertCmd.Parameters.AddWithValue("@benefitId", benefitId);
                            insertCmd.Parameters.AddWithValue("@amount", amount);
                            insertCmd.Parameters.AddWithValue("@dateAssigned", dateAssigned);
                            insertCmd.Parameters.AddWithValue("@status", status);

                            insertCmd.ExecuteNonQuery();
                        }

                        continue; // skip to next row
                    }

                    // Check if benefit already exists for this employee + payslip
                    string checkQuery = @"
                SELECT COUNT(*) 
                FROM AssignedBenefits
                WHERE employee_id = @empId
                  AND benefit_id = @benefitId
                  AND payslip_id = @payslipId";

                    int exists = 0;
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, con))
                    {
                        cmdCheck.Parameters.AddWithValue("@empId", employeeId);
                        cmdCheck.Parameters.AddWithValue("@benefitId", benefitId);
                        cmdCheck.Parameters.AddWithValue("@payslipId", payslipId);

                        exists = (int)cmdCheck.ExecuteScalar();
                    }

                    if (exists > 0)
                    {
                        // UPDATE existing row
                        string updateQuery = @"
                    UPDATE AssignedBenefits
                    SET amount = @amount,
                        status = @status,
                        date_assigned = @dateAssigned
                    WHERE employee_id = @empId
                      AND benefit_id = @benefitId
                      AND payslip_id = @payslipId";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@amount", amount);
                            updateCmd.Parameters.AddWithValue("@status", status);
                            updateCmd.Parameters.AddWithValue("@dateAssigned", dateAssigned);
                            updateCmd.Parameters.AddWithValue("@empId", employeeId);
                            updateCmd.Parameters.AddWithValue("@benefitId", benefitId);
                            updateCmd.Parameters.AddWithValue("@payslipId", payslipId);

                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // INSERT new row with payslip_id
                        string insertQuery = @"
                    INSERT INTO AssignedBenefits
                    (payslip_id, employee_id, benefit_id, amount, date_assigned, status)
                    VALUES
                    (@payslipId, @empId, @benefitId, @amount, @dateAssigned, @status)";

                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                        {
                            insertCmd.Parameters.AddWithValue("@payslipId", payslipId);
                            insertCmd.Parameters.AddWithValue("@empId", employeeId);
                            insertCmd.Parameters.AddWithValue("@benefitId", benefitId);
                            insertCmd.Parameters.AddWithValue("@amount", amount);
                            insertCmd.Parameters.AddWithValue("@dateAssigned", dateAssigned);
                            insertCmd.Parameters.AddWithValue("@status", status);

                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("All assigned benefits saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving assigned benefits: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
//


    }
}
