using System.Data;
using System.Data.SqlClient;

namespace Payroll_System
{
    public partial class AssignBenefits : Form
    {
        public AssignBenefits()
        {
            InitializeComponent();
            focus_remover();
            LoadEmployeeBenefits(dgv_assignbenefits);
            dgv_assignbenefits.CellContentClick += dgv_assignbenefits_CellContentClick;
            LoadEmployeeNames(empList);
            empList.KeyDown += searchbox_KeyDown;

        }
        public static class dbConnector
        {
            private static readonly string connectionString = "Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }
        public void LoadEmployeeBenefits(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv.AutoGenerateColumns = false;

            using (SqlConnection con = dbConnector.GetConnection())
            {
                string query = @"
            SELECT e.employee_id,
                   (e.first_name + ' ' + e.last_name) AS EmployeeName,
                   b.benefit_id,
                   b.benefit_type,
                   ab.amount,
                   ab.date_assigned
            FROM Employee e
            INNER JOIN AssignedBenefits ab ON e.employee_id = ab.employee_id
            INNER JOIN BenefitCatalog b ON ab.benefit_id = b.benefit_id";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "employee_id", HeaderText = "Employee ID", Visible = false });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "employee_name", HeaderText = "Employee Name", ReadOnly = true });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "benefit_id", HeaderText = "Benefit ID", Visible = false });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "benefit_type", HeaderText = "Benefit", ReadOnly = true });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "amount", HeaderText = "Amount", ReadOnly = true });
                dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "date_assigned", HeaderText = "Date Assigned", ReadOnly = true });

                DataGridViewButtonColumn removeBtn = new DataGridViewButtonColumn();
                removeBtn.Name = "remove_btn";
                removeBtn.HeaderText = "Remove Benefit";
                removeBtn.Text = "🗑 Remove";
                removeBtn.UseColumnTextForButtonValue = true;
                dgv.Columns.Add(removeBtn);

                foreach (DataRow row in dt.Rows)
                {
                    dgv.Rows.Add(
                        row["employee_id"],
                        row["EmployeeName"],
                        row["benefit_id"],
                        row["benefit_type"],
                        row["amount"],
                        row["date_assigned"]
                    );
                }

                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dgv.AllowUserToResizeColumns = false;
                dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void dgv_assignbenefits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_assignbenefits.Columns[e.ColumnIndex].Name == "remove_btn" && e.RowIndex >= 0)
            {
                int empId = Convert.ToInt32(dgv_assignbenefits.Rows[e.RowIndex].Cells["employee_id"].Value);
                int benefitId = Convert.ToInt32(dgv_assignbenefits.Rows[e.RowIndex].Cells["benefit_id"].Value);

                var confirm = MessageBox.Show("Remove this benefit from employee?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection con = dbConnector.GetConnection())
                    {
                        string deleteQuery = "DELETE FROM AssignedBenefits WHERE employee_id=@empId AND benefit_id=@benefitId";
                        SqlCommand cmd = new SqlCommand(deleteQuery, con);
                        cmd.Parameters.AddWithValue("@empId", empId);
                        cmd.Parameters.AddWithValue("@benefitId", benefitId);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Benefit removed.");
                    LoadEmployeeBenefits(dgv_assignbenefits);
                }
            }
        }

        public void LoadEmployeeNames(ComboBox searchbox)
        {
            string query = @"
        SELECT DISTINCT e.employee_id, 
               (e.first_name + ' ' + e.last_name) AS FullName
        FROM Employee e
        INNER JOIN AssignedBenefits ab ON e.employee_id = ab.employee_id";

            using (SqlConnection connector = dbConnector.GetConnection())
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connector);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No employees with benefits found.");
                        return;
                    }

                    searchbox.DataSource = dt;
                    searchbox.DisplayMember = "FullName";   
                    searchbox.ValueMember = "employee_id"; 
                    searchbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    searchbox.AutoCompleteSource = AutoCompleteSource.ListItems;
                    searchbox.SelectedIndex = -1;
                    searchbox.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee names: " + ex.Message);
                }
            }
        }

        private void searchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string selectedName = empList.Text.Trim().ToLower(); 
                dgv_assignbenefits.ClearSelection();

                foreach (DataGridViewRow row in dgv_assignbenefits.Rows)
                {
                    if (row.Cells["employee_name"].Value != null)
                    {
                        string fullName = row.Cells["employee_name"].Value.ToString().ToLower();
                        if (fullName.Contains(selectedName))
                        {
                            row.Selected = true;
                        }
                    }
                }

                e.Handled = true;
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
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            BenefitsAdministration benefitsAdmin = new BenefitsAdministration();
            benefitsAdmin.Show();
            this.Show();
            this.Hide();
        }
        public void focus_remover()
        {
            Label dummyFocus = new Label();
            dummyFocus.Size = new Size(0, 0);
            dummyFocus.Location = new Point(0, 0);
            this.Controls.Add(dummyFocus);
            this.ActiveControl = dummyFocus;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            assignEmployeeBenefit aeb = new assignEmployeeBenefit();
            aeb.Show();
            this.Show();
            this.Hide();
        }

    }
}
