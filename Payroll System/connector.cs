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
            public static int UserID { get; set; }
        }


        public void connection()
        {
            string cs = "Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True";

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




        public void dataSend(string username, string password, string email)
        {
            try
            {
                // Basic input validation
                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Username cannot be empty.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Password cannot be empty.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Email cannot be empty.");
                    return;
                }
                if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Invalid email format.");
                    return;
                }

                connection();

                string checkSql = "SELECT COUNT(*) FROM [login] WHERE username = @username";
                using (SqlCommand checkCmd = new SqlCommand(checkSql, con))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose another.");
                        return;
                    }
                }

                // Insert into login and get new user_id
                string sqlLogin = @"
            INSERT INTO [login] (username, password) 
            OUTPUT INSERTED.user_id
            VALUES (@register_username, @register_password)";

                int newUserId;
                using (SqlCommand cmd = new SqlCommand(sqlLogin, con))
                {
                    cmd.Parameters.AddWithValue("@register_username", username);
                    cmd.Parameters.AddWithValue("@register_password", password);

                    newUserId = (int)cmd.ExecuteScalar();
                }

                // Insert into UserContact
                string sqlContact = "INSERT INTO UserContact (user_id, email) VALUES (@user_id, @register_email)";
                using (SqlCommand cmdContact = new SqlCommand(sqlContact, con))
                {
                    cmdContact.Parameters.AddWithValue("@user_id", newUserId);
                    cmdContact.Parameters.AddWithValue("@register_email", email);

                    cmdContact.ExecuteNonQuery();
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
                string sql = "SELECT user_id, employee_id FROM [login] WHERE username = @user AND password = @pass";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Connector.SessionData.UserID = (int)reader["user_id"];
                            Connector.SessionData.EmployeeID = reader["employee_id"] == DBNull.Value
                                ? (int?)null
                                : (int)reader["employee_id"];

                            return (true, Connector.SessionData.EmployeeID);
                        }
                        else
                        {
                            return (false, null); 
                        }
                    }
                }
            }
            catch
            {
                return (false, null);
            }
        }
        public void LoadEmployeeNamesByDate(ComboBox cmbname, DateTime startDate, DateTime endDate)
        {
            connection();

            try
            {
                string query = @"
    SELECT 
        a.attendance_id,
        e.employee_id,
        (e.first_name + ' ' + e.last_name 
            + ' – ' + CONVERT(varchar(10), a.start_date, 120)
            + ' to ' + CONVERT(varchar(10), a.end_date, 120)
        ) AS FullDisplay
    FROM employee e
    INNER JOIN attendance a 
        ON e.employee_id = a.employee_id
    WHERE 
        CAST(a.start_date AS DATE) >= @StartDate
        AND CAST(a.end_date AS DATE) <= @EndDate
    ORDER BY e.employee_id, a.attendance_id;
";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@StartDate", SqlDbType.Date).Value = startDate.Date;
                    cmd.Parameters.Add("@EndDate", SqlDbType.Date).Value = endDate.Date;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Reset ComboBox BEFORE assigning new values
                    cmbname.DataSource = null;
                    cmbname.Items.Clear();

                    if (dt.Rows.Count > 0)
                    {
                        cmbname.DataSource = dt;
                        cmbname.DisplayMember = "FullDisplay";
                        cmbname.ValueMember = "attendance_id";
                        cmbname.SelectedIndex = -1;
                    }
                    else
                    {
                        cmbname.Items.Add("No records found");
                        cmbname.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        public void LoadEmployeeNames(ComboBox cmbname)
        {
            connection();

            try
            {
                string query = @"
SELECT 
    a.attendance_id,
    e.employee_id,
    (e.first_name + ' ' + e.last_name 
        + ' – ' + CONVERT(varchar(10), a.start_date, 120)
        + ' to ' + CONVERT(varchar(10), a.end_date, 120)
    ) AS FullDisplay
FROM employee e
INNER JOIN attendance a 
    ON e.employee_id = a.employee_id
ORDER BY a.attendance_id;
";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Reset ComboBox BEFORE assigning new values
                    cmbname.DataSource = null;
                    cmbname.Items.Clear();

                    if (dt.Rows.Count > 0)
                    {
                        cmbname.DataSource = dt;
                        cmbname.DisplayMember = "FullDisplay";
                        cmbname.ValueMember = "attendance_id";
                        cmbname.SelectedIndex = -1;
                    }
                    else
                    {
                        cmbname.Items.Add("No records found");
                        cmbname.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
            finally
            {
                con.Close();
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


        // deleted the data. things in here
        // might need it again tho
        public bool DisplayEmployeeSalary(
 int attendanceID,
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
            double sssRate = 0.045;
            double philRate = 0.025;
            double pagibigRate = 0.02;

            try
            {
                // Ensure the connection is open
                connection();

                string query = @"
       SELECT 
           e.first_name, 
           e.last_name,
           a.days_worked,
           a.overtime_hours,
           e.salary,
           a.start_date,
           a.end_date
       FROM attendance a
       INNER JOIN employee e 
           ON e.employee_id = a.employee_id
       WHERE a.attendance_id = @attid
   ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@attid", attendanceID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Load dates
                            DateTime sDate = Convert.ToDateTime(reader["start_date"]);
                            DateTime eDate = Convert.ToDateTime(reader["end_date"]);

                            start_date.Value = sDate;
                            end_date.Value = eDate;

                            // Load attendance and salary data
                            int dayWorked = Convert.ToInt32(reader["days_worked"]);
                            int overtimeHours = Convert.ToInt32(reader["overtime_hours"]);
                            double salaryPerDay = Convert.ToDouble(reader["salary"]);

                            // Compute salary
                            double totalSalary = dayWorked * salaryPerDay;
                            double overtimePay = overtimeHours * (salaryPerDay / 8) * 1.25;
                            double grossSalary = totalSalary + overtimePay;

                            double sssAmount = grossSalary * sssRate;
                            double philAmount = grossSalary * philRate;
                            double pagibigAmount = grossSalary * pagibigRate;
                            double totalDeductions = sssAmount + philAmount + pagibigAmount;
                            double netSalary = grossSalary - totalDeductions;

                            // Assign values to labels
                            salary.Text = $"₱{salaryPerDay:N2}";
                            grosspay.Text = $"₱{grossSalary:N2}";
                            sss.Text = $"₱{sssAmount:N2}";
                            philhealth.Text = $"₱{philAmount:N2}";
                            pagibig.Text = $"₱{pagibigAmount:N2}";
                            totaldeductions.Text = $"₱{totalDeductions:N2}";
                            netpay.Text = $"₱{netSalary:N2}";
                            overtime.Text = $"₱{overtimePay:N2}";

                            return true; // Salary loaded successfully
                        }
                        else
                        {
                            MessageBox.Show("No attendance record found for this selection.");
                            return false; // No data found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading salary: " + ex.Message);
                return false; // Error occurred
            }
        }



            public void SaveOrUpdatePayslip(
        int employeeID,
        DateTimePicker startDatePicker,
        DateTimePicker endDatePicker,
        double grossPay,
        double netPay,
        double taxWithheld,
        double sss,
        double pagibig,
        double philhealth,
        string lastGeneratedFilePath)
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
                        ile_path = @file_path
                    WHERE employee_id = @employee_id
                      AND pay_period_start = @start
                      AND pay_period_end = @end";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@gross", (float)grossPay);
                            updateCmd.Parameters.AddWithValue("@net", (float)netPay);
                            updateCmd.Parameters.AddWithValue("@tax", (float)taxWithheld);
                            updateCmd.Parameters.AddWithValue("@created", DateTime.Now);
                            updateCmd.Parameters.AddWithValue("@file_path", lastGeneratedFilePath);
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
                    (employee_id, pay_period_start, pay_period_end, gross_pay, net_pay, tax_withheld, created_at, file_path)
                    VALUES (@employee_id, @start, @end, @gross, @net, @tax, @created, @filepath)";

                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                        {
                            insertCmd.Parameters.AddWithValue("@employee_id", employeeID);
                            insertCmd.Parameters.AddWithValue("@start", payPeriodStart);
                            insertCmd.Parameters.AddWithValue("@end", payPeriodEnd);
                            insertCmd.Parameters.AddWithValue("@gross", (float)grossPay);
                            insertCmd.Parameters.AddWithValue("@net", (float)netPay);
                            insertCmd.Parameters.AddWithValue("@tax", (float)taxWithheld);
                            insertCmd.Parameters.AddWithValue("@created", DateTime.Now);
                            insertCmd.Parameters.AddWithValue("@filepath", lastGeneratedFilePath);

                        insertCmd.ExecuteNonQuery();
                            MessageBox.Show("Payslip added successfully!");
                        }
                    }
                // Insert into Reports table
                // might change this later

                string reportCheckQuery = "SELECT COUNT(*) FROM Reports";
                int reportCount = 0;

                using (SqlCommand checkReportCmd = new SqlCommand(reportCheckQuery, con))
                {
                    reportCount = (int)checkReportCmd.ExecuteScalar();
                }

                if (reportCount > 0)
                {
                    string reportUpdateQuery = "UPDATE Reports SET sss = sss + @sss, pagibig = pagibig + @pagibig, philhealth = philhealth + @philhealth";

                    using (SqlCommand updateReportCmd = new SqlCommand(reportUpdateQuery, con))
                    {
                        updateReportCmd.Parameters.AddWithValue("@sss", (float)sss);
                        updateReportCmd.Parameters.AddWithValue("@pagibig", (float)pagibig);
                        updateReportCmd.Parameters.AddWithValue("@philhealth", (float)philhealth);

                        updateReportCmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    string reportInsertQuery = "INSERT INTO Reports (sss, pagibig, philhealth) VALUES (@sss, @pagibig, @philhealth)";

                    using (SqlCommand reportCmd = new SqlCommand(reportInsertQuery, con))
                    {
                        reportCmd.Parameters.AddWithValue("@sss", (float)sss);
                        reportCmd.Parameters.AddWithValue("@pagibig", (float)pagibig);
                        reportCmd.Parameters.AddWithValue("@philhealth", (float)philhealth);

                        reportCmd.ExecuteNonQuery();
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

        
        //
        public int GetEmployeeIDFromAttendance(int attendanceID)
        {
            int employeeID = 0;

            connection(); 

            try
            {
                string query = "SELECT employee_id FROM Attendance WHERE attendance_id = @attendanceID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@attendanceID", attendanceID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        employeeID = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving employee ID: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return employeeID;
        }

    }
}
