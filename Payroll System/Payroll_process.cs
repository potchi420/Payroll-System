using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Payroll_System
{
    public partial class Payroll_process : Form
    {
        public Payroll_process()
        {
            InitializeComponent();
            Connector cn = new Connector();
            cn.LoadEmployeeNames(cmbname);


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void load_employee_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbname.SelectedValue != null && int.TryParse(cmbname.SelectedValue.ToString(), out int empID))
                {
                    Connector cn = new Connector();
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
            GeneratePayslipPDF(@"C:\Users\franz\Downloads\Santos_Oct2025.pdf");
        }

        public void GeneratePayslipPDF(string filePath)
        {
            Document doc = new Document(PageSize.A4, 50, 50, 25, 25);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // Header
            Paragraph header = new Paragraph("Philippine Christian University\n1648 Taft Ave, Malate, Manila, 1004, Metro Manila", FontFactory.GetFont("Arial", 12f, iTextSharp.text.Font.BOLD));
            header.Alignment = Element.ALIGN_CENTER;
            doc.Add(header);
            doc.Add(new Paragraph("\n"));

            // Employee Info
            PdfPTable empTable = new PdfPTable(2);
            empTable.WidthPercentage = 100;
            empTable.AddCell("Employee Name:");
            empTable.AddCell("Mama mo");
            empTable.AddCell("Designation:");
            empTable.AddCell("Marketing Executive");
            empTable.AddCell("Department:");
            empTable.AddCell("Marketing");
            empTable.AddCell("Date of Joining:");
            empTable.AddCell("June 23, 2018");
            empTable.AddCell("Pay Period:");
            empTable.AddCell("August 2021");
            empTable.AddCell("Worked Days:");
            empTable.AddCell("26");
            doc.Add(empTable);
            doc.Add(new Paragraph("\n"));

            // Earnings
            Paragraph earningsHeader = new Paragraph("Earnings", FontFactory.GetFont("Arial", 12f, iTextSharp.text.Font.BOLD));
            doc.Add(earningsHeader);
            PdfPTable earningsTable = new PdfPTable(2);
            earningsTable.WidthPercentage = 100;
            earningsTable.AddCell("Basic");
            earningsTable.AddCell("₱10,000");
            earningsTable.AddCell("Incentive Pay");
            earningsTable.AddCell("₱500");
            earningsTable.AddCell("House Rent Allowance");
            earningsTable.AddCell("₱400");
            earningsTable.AddCell("Meal Allowance");
            earningsTable.AddCell("₱200");
            earningsTable.AddCell("Total Earnings");
            earningsTable.AddCell("₱11,600");
            doc.Add(earningsTable);
            doc.Add(new Paragraph("\n"));

            // Deductions
            Paragraph deductionsHeader = new Paragraph("Deductions", FontFactory.GetFont("Arial", 12f, iTextSharp.text.Font.BOLD));
            doc.Add(deductionsHeader);
            PdfPTable deductionsTable = new PdfPTable(2);
            deductionsTable.WidthPercentage = 100;
            deductionsTable.AddCell("Provident Fund");
            deductionsTable.AddCell("₱1,200");
            deductionsTable.AddCell("Professional Tax");
            deductionsTable.AddCell("₱500");
            deductionsTable.AddCell("Loan");
            deductionsTable.AddCell("₱400");
            deductionsTable.AddCell("Total Deductions");
            deductionsTable.AddCell("₱2,100");
            doc.Add(deductionsTable);
            doc.Add(new Paragraph("\n"));

            // Net Pay
            Paragraph netPay = new Paragraph("Net Pay: ₱9,500\nIn Words: Nine Thousand Five Hundred", FontFactory.GetFont("Arial", 12f, iTextSharp.text.Font.BOLD));
            netPay.Alignment = Element.ALIGN_LEFT;
            doc.Add(netPay);
            doc.Add(new Paragraph("\n"));

            // Signatures
            PdfPTable signTable = new PdfPTable(2);
            signTable.WidthPercentage = 100;
            signTable.AddCell("Employer Signature");
            signTable.AddCell("Employee Signature");
            doc.Add(signTable);

            // Footer
            Paragraph footer = new Paragraph("\nThis is a system generated payslip.", FontFactory.GetFont("Arial", 10f, iTextSharp.text.Font.ITALIC));
            footer.Alignment = Element.ALIGN_CENTER;
            doc.Add(footer);

            doc.Close();
            MessageBox.Show("Generated the payslip");
        }
    }
}
