using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            panel_color();
            LoadInitialEmployees();
            LoadDepartments();
            load_avg_pay();
            focus_remover();

        }

        //change the connection string as per your sql server

        private void btnemployee_Click(object sender, EventArgs e)
        {
            Employeedashboard employeedashboard = new Employeedashboard();
            employeedashboard.Show();
            this.Show();
            this.Hide();
        }

        private void btnpayrollcenter_Click(object sender, EventArgs e)
        {
            Payroll_process payroll_process = new Payroll_process();
            payroll_process.Show();
            this.Show();
            this.Hide();
        }

        private void btnreportscenter_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Show();
            this.Hide();
        }

        private void btnbenefits_Click(object sender, EventArgs e)
        {
            BenefitsAdministration benefits = new BenefitsAdministration();
            benefits.Show();
            this.Show();
            this.Hide();
        }

        private void logo_Click(object sender, EventArgs e)
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

        private void btnsettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Show();
            this.Hide();
        }
        private DataTable connector(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connector = dbConnector.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connector);
                adapter.Fill(dt);
            }
            return dt;
        }

        private void load_avg_pay()
        {
            string query = "SELECT AVG(salary) AS average_salary FROM employee";
            DataTable avgTable = connector(query);
            if (avgTable.Rows.Count > 0)
            {
                int averageSalary = Convert.ToInt32(avgTable.Rows[0]["average_salary"]);
                ave_pay.Text = averageSalary.ToString("C0"); // Format as currency
            }
        }

        private void LoadInitialEmployees()
        {
            string query = @"
            SELECT TOP 50 
                employee_id AS [Employee ID],
                department_id AS [Department ID],
                (first_name + ' ' + last_name) AS [Name],
                salary AS [Salary]
            FROM employee
            WHERE is_active = 1
            ORDER BY employee_id ASC";

            string countQuery = "SELECT COUNT(*) AS total FROM employee WHERE is_active = 1";

            emp_list.DataSource = connector(query);

            emp_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            emp_list.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            emp_list.AllowUserToResizeColumns = false;
            emp_list.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            emp_list.DefaultCellStyle.SelectionBackColor = emp_list.DefaultCellStyle.BackColor;
            emp_list.DefaultCellStyle.SelectionForeColor = emp_list.DefaultCellStyle.ForeColor;

            DataTable countTable = connector(countQuery);
            if (countTable.Rows.Count > 0)
            {
                int count = Convert.ToInt32(countTable.Rows[0]["total"]);
                total_emp.Text = count.ToString();
            }
        }
        private void LoadDepartments()
        {
            string query = "SELECT * FROM department";
            string countQuery = "SELECT COUNT(*) AS total FROM department";

            // Load department list into DataGridView
            dept_list.DataSource = connector(query);
            dept_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dept_list.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dept_list.AllowUserToResizeColumns = false;
            dept_list.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dept_list.DefaultCellStyle.SelectionBackColor = emp_list.DefaultCellStyle.BackColor;
            dept_list.DefaultCellStyle.SelectionForeColor = emp_list.DefaultCellStyle.ForeColor;

            // Get department count from query result
            DataTable countTable = connector(countQuery);
            if (countTable.Rows.Count > 0)
            {
                int count = Convert.ToInt32(countTable.Rows[0]["total"]);
                total_departments.Text = count.ToString(); // Update label
            }

        }

        public void focus_remover()
        {
            Label dummyFocus = new Label();
            dummyFocus.Size = new Size(0, 0);
            dummyFocus.Location = new Point(0, 0);
            this.Controls.Add(dummyFocus);
            this.ActiveControl = dummyFocus;

            // employee button hover effect
            btnemployeecenter.MouseEnter += (s, e) =>
            {
                btnemployeecenter.BackColor = ColorTranslator.FromHtml("#E6F3FE");
            };

            btnemployeecenter.MouseLeave += (s, e) =>
            {
                btnemployeecenter.BackColor = SystemColors.Control;
            };

            // payroll button hover effect
            btnpayrollcenter.MouseEnter += (s, e) =>
            {
                btnpayrollcenter.BackColor = ColorTranslator.FromHtml("#E6F3FE");
            };

            btnpayrollcenter.MouseLeave += (s, e) =>
            {
                btnpayrollcenter.BackColor = SystemColors.Control;
            };

            // reports button hover effect
            btnreportscenter.MouseEnter += (s, e) =>
            {
                btnreportscenter.BackColor = ColorTranslator.FromHtml("#E6F3FE");
            };

            btnpayrollcenter.MouseLeave += (s, e) =>
            {
                btnreportscenter.BackColor = SystemColors.Control;
            };

            // tax button hover effect
            btntax.MouseEnter += (s, e) =>
            {
                btntax.BackColor = ColorTranslator.FromHtml("#E6F3FE");
            };

            btntax.MouseLeave += (s, e) =>
            {
                btntax.BackColor = SystemColors.Control;
            };

            // benefits button hover effect
            btnbenefits.MouseEnter += (s, e) =>
            {
                btnbenefits.BackColor = ColorTranslator.FromHtml("#E6F3FE");
            };
            btnbenefits.MouseLeave += (s, e) =>
            {
                btnbenefits.BackColor = SystemColors.Control;
            };

            // settings button hover effect
            btnsettings.MouseEnter += (s, e) =>
            {
                btnsettings.BackColor = ColorTranslator.FromHtml("#E6F3FE");
            };
            btnsettings.MouseLeave += (s, e) =>
            {
                btnsettings.BackColor = SystemColors.Control;
            };
        }
        public void panel_color()
        {
            // Define a consistent accent width
            int accentWidth = 4;

            // Accent line for Employee panel
            Panel empAccent = new Panel();
            empAccent.Size = new Size(accentWidth, emp_panel.Height);
            empAccent.Location = new Point(emp_panel.Left - accentWidth, emp_panel.Top + 67);
            empAccent.BackColor = Color.MediumSeaGreen;
            this.Controls.Add(empAccent);
            empAccent.BringToFront();
            emp_panel.BorderStyle = BorderStyle.FixedSingle;

            // Accent line for Expense panel
            Panel expenseAccent = new Panel();
            expenseAccent.Size = new Size(accentWidth, expense_panel.Height);
            expenseAccent.Location = new Point(expense_panel.Left - accentWidth, expense_panel.Top + 67);
            expenseAccent.BackColor = Color.IndianRed;
            this.Controls.Add(expenseAccent);
            expenseAccent.BringToFront();

            // Accent line for Average Pay panel
            Panel avePayAccent = new Panel();
            avePayAccent.Size = new Size(accentWidth, ave_pay_panel.Height);
            avePayAccent.Location = new Point(ave_pay_panel.Left - accentWidth, ave_pay_panel.Top + 67);
            avePayAccent.BackColor = Color.SlateBlue;
            this.Controls.Add(avePayAccent);
            avePayAccent.BringToFront();

            // Accent line for Departments panel
            Panel deptAccent = new Panel();
            deptAccent.Size = new Size(accentWidth, departments_panel.Height);
            deptAccent.Location = new Point(departments_panel.Left - accentWidth, departments_panel.Top + 67);
            deptAccent.BackColor = Color.DarkOrange;
            this.Controls.Add(deptAccent);
            deptAccent.BringToFront();
        }

        private void btntax_Click(object sender, EventArgs e)
        {
            attendance attendance = new attendance();
            attendance.Show();
            this.Show();
            this.Hide();
        }
    }
}
