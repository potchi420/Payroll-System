using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            Reports_Load();
            focus_remover();

            // Accent line for SSS panel
            Panel sssAccent = new Panel();
            sssAccent.Size = new Size(4, sss_panel.Height);
            sssAccent.Location = new Point(sss_panel.Left - 4, sss_panel.Top);
            sssAccent.BackColor = Color.SteelBlue;
            this.Controls.Add(sssAccent);
            sssAccent.BringToFront();

            // Accent line for PhilHealth panel
            // Accent line for PhilHealth panel – split into yellow and green
            int accentWidth = 4;
            int halfWidth = accentWidth / 2;

            // Yellow half
            Panel philhealthAccentYellow = new Panel();
            philhealthAccentYellow.Size = new Size(halfWidth, philhealth_panel.Height);
            philhealthAccentYellow.Location = new Point(philhealth_panel.Left - accentWidth, philhealth_panel.Top);
            philhealthAccentYellow.BackColor = Color.Gold;
            this.Controls.Add(philhealthAccentYellow);
            philhealthAccentYellow.BringToFront();

            // Green half
            Panel philhealthAccentGreen = new Panel();
            philhealthAccentGreen.Size = new Size(halfWidth, philhealth_panel.Height);
            philhealthAccentGreen.Location = new Point(philhealth_panel.Left - halfWidth, philhealth_panel.Top);
            philhealthAccentGreen.BackColor = Color.ForestGreen;
            this.Controls.Add(philhealthAccentGreen);
            philhealthAccentGreen.BringToFront();


            // Accent line for Pag-IBIG panel
            Panel pagibigAccent = new Panel();
            pagibigAccent.Size = new Size(4, pagibig_panel.Height);
            pagibigAccent.Location = new Point(pagibig_panel.Left - 4, pagibig_panel.Top);
            pagibigAccent.BackColor = Color.DarkBlue;
            this.Controls.Add(pagibigAccent);
            pagibigAccent.BringToFront();

        }
        public static class dbConnector
        {
            private static readonly string connectionString = "Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }

        private void logo_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Logout.Execute(this);
        }

        public void Reports_Load()
        {
            using (SqlConnection con = dbConnector.GetConnection())
            {
                string query = "SELECT * FROM Reports";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                decimal sss = Convert.ToDecimal(reader["sss"]);
                                decimal philhealth = Convert.ToDecimal(reader["philhealth"]);
                                decimal pagibig = Convert.ToDecimal(reader["pagibig"]);
                                decimal total = sss + philhealth + pagibig;

                                sss_value.Text = $"₱{sss:N2}";
                                philhealth_value.Text = $"₱{philhealth:N2}";
                                pagibig_value.Text = $"₱{pagibig:N2}";
                                total_tax_value.Text = $"₱{total:N0}";
                            }
                            else
                            {
                                sss_value.Text = "₱0.00";
                                philhealth_value.Text = "₱0.00";
                                pagibig_value.Text = "₱0.00";
                                total_tax_value.Text = "₱0.00";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading report values: " + ex.Message);
                    }
                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string directoryPath = @"C:\PayrollReports";
                if (!Directory.Exists(directoryPath))
                    Directory.CreateDirectory(directoryPath);

                string fileName = $"TaxReport_{DateTime.Now:yyyy-MM-dd}.pdf";
                string filePath = Path.Combine(directoryPath, fileName);

                Document doc = new Document(PageSize.A4, 50, 50, 25, 25);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                // Fonts
                var titleFont = FontFactory.GetFont("Arial", 14f, iTextSharp.text.Font.BOLD);
                var labelFont = FontFactory.GetFont("Arial", 11f, iTextSharp.text.Font.BOLD);
                var valueFont = FontFactory.GetFont("Arial", 11f, iTextSharp.text.Font.NORMAL);

                // Header
                doc.Add(new Paragraph("PCU Payroll System – Tax Report", titleFont) { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph($"Generated on: {DateTime.Now:MMMM dd, yyyy hh:mm tt}", valueFont) { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph("\n"));

                // Table
                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 80;
                table.SetWidths(new float[] { 40f, 60f });
                table.HorizontalAlignment = Element.ALIGN_CENTER;

                void AddRow(string label, string value)
                {
                    table.AddCell(new PdfPCell(new Phrase(label, labelFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                    table.AddCell(new PdfPCell(new Phrase(value, valueFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                }

                AddRow("SSS:", sss_value.Text);
                AddRow("PhilHealth:", philhealth_value.Text);
                AddRow("Pag-IBIG:", pagibig_value.Text);
                AddRow("Total Tax Withheld:", total_tax_value.Text);

                doc.Add(table);
                doc.Add(new Paragraph("\nThis is a system-generated report.", valueFont) { Alignment = Element.ALIGN_CENTER });

                doc.Close();
                MessageBox.Show("Report saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving report: " + ex.Message);
            }
        }
        public void focus_remover()
        {
            Label dummyFocus = new Label();
            dummyFocus.Size = new Size(0, 0);
            dummyFocus.Location = new Point(0, 0);
            this.Controls.Add(dummyFocus);
            this.ActiveControl = dummyFocus;
        }
    }  
}
