using System.Data;
using System.Data.SqlClient;

namespace Payroll_System
{
    public partial class assignEmployeeBenefit : Form
    {
        public assignEmployeeBenefit()
        {
            InitializeComponent();
            LoadEmployeeNames(empBox);
            empBox.SelectedIndexChanged += new EventHandler(empBox_SelectedIndexChanged);
        }

        public void LoadEmployeeNames(ComboBox searchbox)
        {
            string query = "SELECT employee_id, (first_name + ' ' + last_name) AS FullName " +
                           "FROM employee WHERE is_active = 1";

            using (SqlConnection connector = dbConnector.GetConnection())
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connector);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

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
        public void LoadBenefitsForEmployee(int employeeId)
        {
            benefitsList.Items.Clear();

            using (SqlConnection con = dbConnector.GetConnection())
            {
                string query = @"
                                SELECT b.benefit_id, b.benefit_type, b.default_amount,
                                       CASE WHEN ab.benefit_id IS NULL THEN 0 ELSE 1 END AS IsAssigned
                                FROM BenefitCatalog b
                                LEFT JOIN AssignedBenefits ab
                                  ON b.benefit_id = ab.benefit_id AND ab.employee_id = @empId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@empId", employeeId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int benefitId = reader.GetInt32(0);
                    string benefitType = reader.GetString(1);
                    decimal defaultAmount = reader.GetDecimal(2);
                    bool isAssigned = reader.GetInt32(3) == 1;

                    string displayText = $"{benefitType} (₱{defaultAmount:N2})";
                    benefitsList.Items.Add(new BenefitItem(benefitId, displayText, defaultAmount), isAssigned);
                }
            }
        }

        public class BenefitItem
        {
            public int Id { get; }
            public string DisplayText { get; }
            public decimal DefaultAmount { get; }

            public BenefitItem(int id, string text, decimal amount)
            {
                Id = id;
                DisplayText = text;
                DefaultAmount = amount;
            }

            public override string ToString()
            {
                return DisplayText;
            }
        }

        private void empBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empBox.SelectedIndex >= 0)
            {
                int employeeId = Convert.ToInt32(empBox.SelectedValue);
                LoadBenefitsForEmployee(employeeId);
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Logout.Execute(this);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            AssignBenefits ab = new AssignBenefits();
            ab.Show();
            this.Hide();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (empBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an employee first.");
                return;
            }

            if (benefitsList.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please assign at least one benefit before saving.");
                return;
            }

            int employeeId = Convert.ToInt32(empBox.SelectedValue);

            using (SqlConnection con = dbConnector.GetConnection())
            {
                con.Open();

                string clearQuery = "DELETE FROM AssignedBenefits WHERE employee_id = @empId";
                using (SqlCommand clearCmd = new SqlCommand(clearQuery, con))
                {
                    clearCmd.Parameters.AddWithValue("@empId", employeeId);
                    clearCmd.ExecuteNonQuery();
                }

                foreach (var item in benefitsList.CheckedItems)
                {
                    BenefitItem benefit = (BenefitItem)item;

                    string insertQuery = @"INSERT INTO AssignedBenefits 
                           (employee_id, benefit_id, amount, date_assigned) 
                           VALUES (@empId, @benefitId, @amount, GETDATE())";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@empId", employeeId);
                        insertCmd.Parameters.AddWithValue("@benefitId", benefit.Id);
                        insertCmd.Parameters.AddWithValue("@amount", benefit.DefaultAmount);
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Benefits saved successfully!");
            empBox.SelectedIndex = -1;  
            empBox.Text = string.Empty;  
            benefitsList.Items.Clear();
        }
    }
}
