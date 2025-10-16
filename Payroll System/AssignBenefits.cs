using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class AssignBenefits : Form
    {
        public AssignBenefits()
        {
            InitializeComponent();
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
            Application.Exit();
        }

        /*
         // Global variables
            DataTable employeeDataTable;
            int selectedEmployeeId;

            // Load random employees on form load
            private void AssignBenefits_Load(object sender, EventArgs e)
            {
                string query = "SELECT TOP 20 EmployeeID, FullName, Department FROM Employees ORDER BY NEWID()";
                employeeDataTable = GetDataTableFromDatabase(query); // Replace with your DB method
                dataGridViewEmployees.DataSource = employeeDataTable;
            }

            // Handle row selection in employee table
            private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewEmployees.Rows[e.RowIndex];
                    selectedEmployeeId = Convert.ToInt32(row.Cells["EmployeeID"].Value);

                    LoadAssignedBenefits(selectedEmployeeId);
                    EnableBenefitButtons(true);
                }
            }

            // Dynamically filter employee list based on search input
            private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
            {
                string filterText = txtSearchEmployee.Text.Trim();

                if (employeeDataTable != null)
                {
                    employeeDataTable.DefaultView.RowFilter =
                        $"FullName LIKE '%{filterText}%' OR Department LIKE '%{filterText}%'";
                }
            }

            // Load assigned benefits for selected employee
            private void LoadAssignedBenefits(int employeeId)
            {
                string query = "SELECT BenefitType, Amount, DateAssigned FROM AssignedBenefits WHERE employee_id = @employeeId";
                DataTable benefitsTable = GetDataTableFromDatabase(query, new SqlParameter("@employeeId", employeeId));
                dataGridViewBenefits.DataSource = benefitsTable;
            }

            // Enable benefit action buttons
            private void EnableBenefitButtons(bool enable)
            {
                btnAddBenefit.Enabled = enable;
                btnEditBenefit.Enabled = enable;
                btnRemoveBenefit.Enabled = enable;
            }
        */
    }
}
