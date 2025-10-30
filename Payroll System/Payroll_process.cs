﻿using DocumentFormat.OpenXml.Office.CoverPageProps;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Ocsp;


namespace Payroll_System
{
    // THIS IS THE MAIN GIT SOMETHING
    public partial class Payroll_process : Form
    {
        public int currentID;
        public Payroll_process()
        {
            InitializeComponent();
            Connector cn = new Connector();
            cn.LoadEmployeeNames(cmbname);


        }

        public class PayslipData
        {
            public int employeeID { get; set; }
            public string FullName { get; set; }
            public string Department { get; set; }
            public DateTime PayPeriodStart { get; set; }
            public DateTime PayPeriodEnd { get; set; }
            public int DaysWorked { get; set; }
            public int OvertimeHours { get; set; }
            public decimal overtimePay { get; set; }
            public decimal DailyRate { get; set; }
            public decimal BasicPay { get; set; }
            public List<(string BenefitName, decimal Amount)> Benefits { get; set; } = new();
            public List<(string DeductionType, decimal Amount)> Deductions { get; set; } = new();
            public decimal NetPay { get; set; }
            public decimal GrossPay { get; set; }
        }

        private void load_employee_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbname.SelectedValue != null && int.TryParse(cmbname.SelectedValue.ToString(), out int empID))
                {
                    Connector cn = new Connector();
                    currentID = empID;
                    cn.DisplayEmployeeSalary(empID, gross_pay_value, sss_value, philhealth_value, pagibig_value, total_deductions_value, net_pay_value, overtime_value, basic_salary_value);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                    Connector cn = new Connector();
                    PayslipData data = cn.GetPayslipData(currentID);

                    // Sanitize FullName for filename safety
                    string safeName = data.FullName.Replace(" ", "_");
                    string start = data.PayPeriodStart.ToString("dd-MM-yyyy");
                    string end = data.PayPeriodEnd.ToString("dd-MM-yyyy");
                    string fileName = $"{safeName}_{start}_{end}.pdf";
                    string filePath = Path.Combine(@"C:\Users\franz\Downloads", fileName);

                    GeneratePayslipPDF(filePath, data);
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

        public void GeneratePayslipPDF(string filePath, PayslipData data)
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

            AddEarning("Daily Pay", $"₱{data.DailyRate:N2}");
            AddEarning("Overtime Pay", $"₱{data.overtimePay:N2}");
            AddEarning("Gross Pay", $"₱{data.GrossPay:N2}");

            foreach (var benefit in data.Benefits)
                AddEarning(benefit.BenefitName, $"₱{benefit.Amount:N2}");

            decimal totalEarnings = data.GrossPay + data.Benefits.Sum(b => b.Amount);
            AddEarning("Total Earnings", $"₱{totalEarnings:N2}");

            doc.Add(earningsTable);
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

                foreach (var deduction in data.Deductions)
                    AddDeduction(deduction.DeductionType, $"-₱{deduction.Amount:N2}");

                decimal totalDeductions = data.Deductions.Sum(d => d.Amount);
                AddDeduction("Total Deductions", $"₱{totalDeductions:N2}");

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


        // still unsure about this
        // as i envisioned this to utilize the 2 datetimepick elements
        // or not use the 2 datetimepick at all
        private void save_record_btn_Click(object sender, EventArgs e)

        {
            try
            {
                if (cmbname.SelectedValue == null)
                {
                    MessageBox.Show("Please select an employee first.");
                    return;
                }

                int employeeID = Convert.ToInt32(cmbname.SelectedValue);

                // Convert label text to numbers safely
                if (!double.TryParse(gross_pay_value.Text.Replace("₱", "").Replace(",", "").Trim(), out double grossPay))
                {
                    MessageBox.Show("Invalid gross pay value.");
                    return;
                }

                if (!double.TryParse(net_pay_value.Text.Replace("₱", "").Replace(",", "").Trim(), out double netPay))
                {
                    MessageBox.Show("Invalid net pay value.");
                    return;
                }

                if (!double.TryParse(total_deductions_value.Text.Replace("₱", "").Replace(",", "").Trim(), out double totalDeductions))
                {
                    MessageBox.Show("Invalid total deductions value.");
                    return;
                }

                // Create connector object
                Connector con = new Connector();

                // Get attendance period
                var period = con.GetAttendancePeriod(employeeID);
                if (period.startDate == DateTime.MinValue) return;

                // Save or update payslip
                con.SaveOrUpdatePayslip(employeeID, period.startDate, period.endDate, grossPay, netPay, totalDeductions);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payslip: " + ex.Message);
            }
        }
    }
}
