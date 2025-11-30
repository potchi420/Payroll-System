using DocumentFormat.OpenXml.Office.CoverPageProps;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Ocsp;
using Spire.Pdf;
using System.Data.SqlClient;


namespace Payroll_System
{
    // THIS IS THE MAIN GIT SOMETHING
    public partial class Payroll_process : Form
    {
        private bool salaryLoaded = false;
        public int currentID;
        private string lastGeneratedFilePath = null;
        private bool payslipGenerated = false;
        PayslipData data = new PayslipData();
        public Payroll_process()
        {
            InitializeComponent();
            Connector cn = new Connector();
            cn.LoadEmployeeNames(cmbname);


        }

        public class PayslipData
        {
            public int EmployeeID { get; set; }
            public string FullName { get; set; }
            public string Department { get; set; }

            public DateTime PayPeriodStart { get; set; }
            public DateTime PayPeriodEnd { get; set; }

            public int DaysWorked { get; set; }
            public int OvertimeHours { get; set; }

            public decimal SalaryPerDay { get; set; }
            public decimal monthlySalary { get; set; }
            public decimal OvertimePay { get; set; }
            public int TotalBenefits { get; set; }
            public int GrossPay { get; set; }

            public decimal SSS { get; set; }
            public decimal PhilHealth { get; set; }
            public decimal PagIBIG { get; set; }
            public decimal TotalDeductions { get; set; }

            public decimal NetPay { get; set; }
        }
        public static class dbConnector
        {
            private static readonly string connectionString = "Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }


        // TODO
        // this should process other attendance records, not just the first one it finds/the oldest one
        private void load_employee_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbname.SelectedValue == null || !int.TryParse(cmbname.SelectedValue.ToString(), out int attendanceID))
                {
                    MessageBox.Show("Please select a valid attendance record.");
                    salaryLoaded = false; // boolean flag
                    return;
                }

                Connector cn = new Connector();
                data = cn.DisplayEmployeeSalary(
                    attendanceID,
                    gross_pay_value,
                    sss_value,
                    philhealth_value,
                    pagibig_value,
                    total_deductions_value,
                    net_pay_value,
                    overtime_value,
                    basic_salary_value,
                    start_date,
                    end_date
                );

                if (data != null)  
                {
                    salaryLoaded = true; 
                    currentID = cn.GetEmployeeIDFromAttendance(attendanceID);
                }
                else
                {
                    MessageBox.Show("Failed to load salary. Please check the attendance record.");
                    salaryLoaded = false;
                    currentID = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee salary: " + ex.Message);
                salaryLoaded = false;
                currentID = 0;
            }
        }



        private void cmbname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void total_deductions_value_Click(object sender, EventArgs e)
        {

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logo_btn_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void generate_payslip_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentID > 0)
                {
                    if (data == null || string.IsNullOrWhiteSpace(data.FullName))
                    {
                        MessageBox.Show("Payslip data is missing. Please load the employee first.");
                        return;
                    }

                    string safeName = data.FullName.Replace(" ", "_");
                    string start = data.PayPeriodStart.ToString("dd-MM-yyyy");
                    string end = data.PayPeriodEnd.ToString("dd-MM-yyyy");
                    string fileName = $"{safeName}_{start}_{end}.pdf";

                    string directoryPath = @"C:\Payslips";
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    string filePath = Path.Combine(directoryPath, fileName);
                    GeneratePayslipPDF(filePath);

                    lastGeneratedFilePath = filePath;
                    payslipGenerated = true;
                }
                else
                {
                    MessageBox.Show("Please load an employee first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating payslip: " + ex.Message);
            }
        }

        public void GeneratePayslipPDF(string filePath)
        {
            Document doc = new Document(PageSize.A4, 50, 50, 25, 25);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // Fonts
            var titleFont = FontFactory.GetFont("Arial", 14f, iTextSharp.text.Font.BOLD);
            var sectionFont = FontFactory.GetFont("Arial", 12f, iTextSharp.text.Font.BOLD);
            var labelFont = FontFactory.GetFont("Arial", 10f, iTextSharp.text.Font.BOLD);
            var valueFont = FontFactory.GetFont("Arial", 10f, iTextSharp.text.Font.NORMAL);
            var italicFont = FontFactory.GetFont("Arial", 9f, iTextSharp.text.Font.ITALIC);

            // Header
            Paragraph header = new Paragraph("Philippine Christian University", titleFont);
            header.Alignment = Element.ALIGN_CENTER;
            doc.Add(header);
            doc.Add(new Paragraph("1648 Taft Ave, Malate, Manila, 1004, Metro Manila", valueFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph("\n"));

            // Payslip Title
            Paragraph payslipTitle = new Paragraph("Employee Payslip", sectionFont);
            payslipTitle.Alignment = Element.ALIGN_CENTER;
            doc.Add(payslipTitle);
            doc.Add(new Paragraph("\n"));

            // Employee Info Table
            PdfPTable empTable = new PdfPTable(2);
            empTable.WidthPercentage = 100;
            empTable.SetWidths(new float[] { 30f, 70f });

            void AddRow(string label, string value)
            {
                empTable.AddCell(new PdfPCell(new Phrase(label, labelFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                empTable.AddCell(new PdfPCell(new Phrase(value, valueFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
            }

            AddRow("Employee Name:", data.FullName);
            AddRow("Department:", data.Department ?? "N/A");
            AddRow("Pay Period Start:", data.PayPeriodStart.ToString("dd/MM/yyyy"));
            AddRow("Pay Period End:", data.PayPeriodEnd.ToString("dd/MM/yyyy"));
            AddRow("Worked Days:", data.DaysWorked.ToString());
            AddRow("Overtime Hours:", data.OvertimeHours.ToString());

            doc.Add(empTable);
            doc.Add(new Paragraph("\n"));

            // Earnings Section
            doc.Add(new Paragraph("Earnings", sectionFont));
            PdfPTable earningsTable = new PdfPTable(2);
            earningsTable.WidthPercentage = 100;
            earningsTable.SetWidths(new float[] { 70f, 30f });

            void AddEarning(string type, string amount)
            {
                earningsTable.AddCell(new PdfPCell(new Phrase(type, valueFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                earningsTable.AddCell(new PdfPCell(new Phrase(amount, valueFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
            }

            AddEarning("Monthly Salary", $"₱{data.monthlySalary:N2}");
            AddEarning("Overtime Pay", $"₱{data.OvertimePay:N2}");
            AddEarning("Gross Pay", $"₱{data.GrossPay:N2}");

            decimal totalEarnings = data.GrossPay + data.TotalBenefits;
            AddEarning("Total Earnings", $"₱{totalEarnings:N2}");

            doc.Add(earningsTable);
            doc.Add(new Paragraph("\n"));

            doc.Add(new Paragraph("Benefits", sectionFont));
            PdfPTable benefitTable = new PdfPTable(2);
            benefitTable.WidthPercentage = 100;
            benefitTable.SetWidths(new float[] { 70f, 30f });

            void AddBenefit(string type, string amount)
            {
                benefitTable.AddCell(new PdfPCell(new Phrase(type, valueFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                benefitTable.AddCell(new PdfPCell(new Phrase(amount, valueFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
            }

            // Query assigned benefits
            List<BenefitItem> assignedBenefits = GetAssignedBenefits(data.EmployeeID);

            decimal totalBenefits = 0;
            foreach (var benefit in assignedBenefits)
            {
                AddBenefit(benefit.BenefitName, $"₱{benefit.Amount:N2}");
                totalBenefits += benefit.Amount;
            }

            AddBenefit("Total Benefits", $"₱{totalBenefits:N2}");

            doc.Add(benefitTable);
            doc.Add(new Paragraph("\n"));

            // Deductions Section
            doc.Add(new Paragraph("Deductions", sectionFont));
            PdfPTable deductionsTable = new PdfPTable(2);
            deductionsTable.WidthPercentage = 100;
            deductionsTable.SetWidths(new float[] { 70f, 30f });

            void AddDeduction(string type, string amount)
            {
                deductionsTable.AddCell(new PdfPCell(new Phrase(type, valueFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                deductionsTable.AddCell(new PdfPCell(new Phrase(amount, valueFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
            }


            AddDeduction("SSS", $"₱{data.SSS:N2}");
            AddDeduction("PhilHealth", $"₱{data.PhilHealth:N2}");
            AddDeduction("Pag-IBIG", $"₱{data.PagIBIG:N2}");

            AddDeduction("Total Deductions", $"₱{data.TotalDeductions:N2}");

            doc.Add(deductionsTable);
            doc.Add(new Paragraph("\n"));

            // Net Pay
            Paragraph netPay = new Paragraph($"Net Pay: ₱{data.NetPay:N2}", sectionFont);
            doc.Add(netPay);
            doc.Add(new Paragraph($"In Words: {ConvertToWords(data.NetPay)}", italicFont));
            doc.Add(new Paragraph("\n"));

            // Signature Section
            PdfPTable signTable = new PdfPTable(2);
            signTable.WidthPercentage = 100;
            signTable.SetWidths(new float[] { 50f, 50f });

            signTable.AddCell(new PdfPCell(new Phrase("\n\n________________________\nEmployer Signature", valueFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_CENTER });
            signTable.AddCell(new PdfPCell(new Phrase("\n\n________________________\nEmployee Signature", valueFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_CENTER });

            doc.Add(signTable);

            // Footer
            Paragraph footer = new Paragraph("\nThis is a system-generated payslip. No signature is required.", italicFont);
            footer.Alignment = Element.ALIGN_CENTER;
            doc.Add(footer);

            doc.Close();
            MessageBox.Show("Payslip generated successfully.");
        }

        // Convert number to words (for Philippine Peso)
        public string ConvertToWords(decimal amount)
        {
            if (amount == 0)
                return "Zero Pesos";

            long pesos = (long)Math.Floor(amount);
            string words = NumberToWords(pesos);

            return $"{words} Pesos";
        }

        // Helper method to convert number to words

        private string NumberToWords(long number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                       "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen",
                       "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            string result = "";

            if ((number / 1000000) > 0)
            {
                result += NumberToWords(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                result += NumberToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                result += NumberToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (number < 20)
                    result += units[number];
                else
                {
                    result += tens[number / 10];
                    if ((number % 10) > 0)
                        result += "-" + units[number % 10];
                }
            }

            return result.Trim();
        }

        private void save_record_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // ginawa ko na yung "dapat nakagenerate na ng pdf payslip bago magsave"
                if (!payslipGenerated || string.IsNullOrEmpty(lastGeneratedFilePath))
                {
                    MessageBox.Show("You must generate the payslip before saving.");
                    return;
                }


                // Ensure an attendance record is selected
                if (cmbname.SelectedValue == null || cmbname.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an attendance record first.");
                    return;
                }

                int attendanceID = Convert.ToInt32(cmbname.SelectedValue);

                // Prevent saving if salary was not loaded
                if (!salaryLoaded)
                {
                    MessageBox.Show("Please click LOAD to compute the employee’s salary before saving.");
                    return;
                }

                // Validate date range
                if (end_date.Value < start_date.Value)
                {
                    MessageBox.Show("Invalid date range. Please reload salary.");
                    return;
                }

                // Parse label values individually
                if (!double.TryParse(gross_pay_value.Text.Replace("₱", "").Replace(",", "").Trim(), out double grossPay))
                {
                    MessageBox.Show("Invalid gross pay value. Please reload salary.");
                    return;
                }

                if (!double.TryParse(net_pay_value.Text.Replace("₱", "").Replace(",", "").Trim(), out double netPay))
                {
                    MessageBox.Show("Invalid net pay value. Please reload salary.");
                    return;
                }

                if (!double.TryParse(total_deductions_value.Text.Replace("₱", "").Replace(",", "").Trim(), out double totalDeductions))
                {
                    MessageBox.Show("Invalid total deductions value. Please reload salary.");
                    return;
                }

                // Save to database
                Connector conector = new Connector();
                conector.SaveOrUpdatePayslip(
                    currentID,
                    start_date,
                    end_date,
                    grossPay,
                    netPay,
                    totalDeductions,
                    Convert.ToDouble(sss_value.Text.Replace("₱", "")),
                    Convert.ToDouble(pagibig_value.Text.Replace("₱", "")),
                    Convert.ToDouble(philhealth_value.Text.Replace("₱", "")),
                    lastGeneratedFilePath // new column
                );



                MessageBox.Show("Payslip successfully saved!");
                salaryLoaded = false;
                payslipGenerated = false; // reset flag
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payslip: " + ex.Message);
            }
        }



        private void print_payslip_btn_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                if (currentID > 0)
                {
                    Connector cn = new Connector();
                    PayslipData data = cn.GetPayslipData(currentID);

                    string safeName = data.FullName.Replace(" ", "_");
                    string start = data.PayPeriodStart.ToString("dd-MM-yyyy");
                    string end = data.PayPeriodEnd.ToString("dd-MM-yyyy");
                    string fileName = $"{safeName}_{start}_{end}.pdf";
                    string filePath = Path.Combine(@"C:\Users\franz\Downloads", fileName);

                    // Step 1: Generate the PDF
                    GeneratePayslipPDF(filePath, data);

                    // Step 2: Load and print using FreeSpire.PDF
                    PdfDocument doc = new PdfDocument();
                    doc.LoadFromFile(filePath);

                    // Print using Spire.Pdf's Print() method
                    doc.Pri
                    doc.Close();
                }
                else
                {
                    MessageBox.Show("Please load an employee first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing payslip: " + ex.Message);
            }
        */
        }

        private void logobtn_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            Connector cn = new Connector();
            if (end_date.Value.Date < start_date.Value.Date)
            {
                MessageBox.Show("End Date cannot be earlier than Start Date.");
                return;
            }


            cn.LoadEmployeeNamesByDate(cmbname, start_date.Value, end_date.Value);
            //
        }

        public List<BenefitItem> GetAssignedBenefits(int employeeId)
        {
            var benefits = new List<BenefitItem>();

            using (SqlConnection con = dbConnector.GetConnection())
            {
                string query = @"
            SELECT bc.benefit_type, ab.amount
            FROM AssignedBenefits ab
            JOIN BenefitCatalog bc ON ab.benefit_id = bc.benefit_id
            WHERE ab.employee_id = @empId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@empId", employeeId);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string type = reader.GetString(0);
                            decimal amount = reader.GetDecimal(1);
                            benefits.Add(new BenefitItem { BenefitName = type, Amount = amount });
                        }
                    }
                }
            }

            return benefits;
        }

        public class BenefitItem
        {
            public string BenefitName { get; set; }
            public decimal Amount { get; set; }
        }
    }
}
