namespace Payroll_System
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            logo = new PictureBox();
            label8 = new Label();
            logout = new Label();
            home = new Label();
            gradientPanel1 = new GradientPanel();
            btnemployeecenter = new Button();
            btnpayrollcenter = new Button();
            btnreportscenter = new Button();
            btntax = new Button();
            btnbenefits = new Button();
            btnsettings = new Button();
            emp_list = new DataGridView();
            emp_panel = new Panel();
            label2 = new Label();
            total_emp = new Label();
            total_emp_value = new Label();
            expense_panel = new Panel();
            label3 = new Label();
            total_expense = new Label();
            departments_panel = new Panel();
            label7 = new Label();
            total_departments = new Label();
            ave_pay_panel = new Panel();
            label5 = new Label();
            ave_pay = new Label();
            dept_list = new DataGridView();
            label1 = new Label();
            pnlcenter = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emp_list).BeginInit();
            emp_panel.SuspendLayout();
            expense_panel.SuspendLayout();
            departments_panel.SuspendLayout();
            ave_pay_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dept_list).BeginInit();
            pnlcenter.SuspendLayout();
            SuspendLayout();
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Cursor = Cursors.Hand;
            logo.Image = Properties.Resources.icon;
            logo.Location = new Point(0, 3);
            logo.Name = "logo";
            logo.Size = new Size(76, 75);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 22;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(82, 30);
            label8.Name = "label8";
            label8.Size = new Size(258, 24);
            label8.TabIndex = 23;
            label8.Text = "PCU PAYROLL SYSTEM";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // logout
            // 
            logout.AutoSize = true;
            logout.BackColor = Color.Transparent;
            logout.Cursor = Cursors.Hand;
            logout.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.Transparent;
            logout.Location = new Point(1090, 30);
            logout.Name = "logout";
            logout.Size = new Size(85, 24);
            logout.TabIndex = 24;
            logout.Text = "Log Out";
            logout.TextAlign = ContentAlignment.TopCenter;
            logout.Click += logout_Click;
            // 
            // home
            // 
            home.AutoSize = true;
            home.BackColor = Color.Transparent;
            home.Cursor = Cursors.Hand;
            home.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home.ForeColor = Color.Transparent;
            home.Location = new Point(1018, 30);
            home.Name = "home";
            home.Size = new Size(66, 24);
            home.TabIndex = 24;
            home.Text = "Home";
            home.TextAlign = ContentAlignment.TopCenter;
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(home);
            gradientPanel1.Controls.Add(logout);
            gradientPanel1.Controls.Add(label8);
            gradientPanel1.Controls.Add(logo);
            gradientPanel1.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel1.Location = new Point(-3, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1191, 76);
            gradientPanel1.TabIndex = 4;
            // 
            // btnemployeecenter
            // 
            btnemployeecenter.BackColor = SystemColors.ButtonFace;
            btnemployeecenter.Cursor = Cursors.Hand;
            btnemployeecenter.Font = new Font("Arial", 9F);
            btnemployeecenter.Image = (Image)resources.GetObject("btnemployeecenter.Image");
            btnemployeecenter.Location = new Point(618, 219);
            btnemployeecenter.Margin = new Padding(10);
            btnemployeecenter.Name = "btnemployeecenter";
            btnemployeecenter.Size = new Size(170, 170);
            btnemployeecenter.TabIndex = 0;
            btnemployeecenter.Text = "Employee \r\nManagement\r\n\r\n";
            btnemployeecenter.TextAlign = ContentAlignment.BottomCenter;
            btnemployeecenter.UseVisualStyleBackColor = false;
            btnemployeecenter.Click += btnemployee_Click;
            // 
            // btnpayrollcenter
            // 
            btnpayrollcenter.BackColor = SystemColors.ButtonFace;
            btnpayrollcenter.Cursor = Cursors.Hand;
            btnpayrollcenter.Font = new Font("Arial", 9F);
            btnpayrollcenter.Image = (Image)resources.GetObject("btnpayrollcenter.Image");
            btnpayrollcenter.Location = new Point(808, 219);
            btnpayrollcenter.Margin = new Padding(10);
            btnpayrollcenter.Name = "btnpayrollcenter";
            btnpayrollcenter.Size = new Size(170, 170);
            btnpayrollcenter.TabIndex = 1;
            btnpayrollcenter.Text = "Payroll\r\nProcessing\r\n\r\n";
            btnpayrollcenter.TextAlign = ContentAlignment.BottomCenter;
            btnpayrollcenter.UseVisualStyleBackColor = false;
            btnpayrollcenter.Click += btnpayrollcenter_Click;
            // 
            // btnreportscenter
            // 
            btnreportscenter.BackColor = SystemColors.ButtonFace;
            btnreportscenter.Cursor = Cursors.Hand;
            btnreportscenter.Font = new Font("Arial", 9F);
            btnreportscenter.Image = (Image)resources.GetObject("btnreportscenter.Image");
            btnreportscenter.Location = new Point(998, 219);
            btnreportscenter.Margin = new Padding(10);
            btnreportscenter.Name = "btnreportscenter";
            btnreportscenter.Size = new Size(170, 170);
            btnreportscenter.TabIndex = 2;
            btnreportscenter.Text = "Reports\r\n\r\n";
            btnreportscenter.TextAlign = ContentAlignment.BottomCenter;
            btnreportscenter.UseVisualStyleBackColor = false;
            btnreportscenter.Click += btnreportscenter_Click;
            // 
            // btntax
            // 
            btntax.BackColor = SystemColors.ButtonFace;
            btntax.Cursor = Cursors.Hand;
            btntax.Font = new Font("Arial", 9F);
            btntax.Image = (Image)resources.GetObject("btntax.Image");
            btntax.Location = new Point(618, 400);
            btntax.Margin = new Padding(10);
            btntax.Name = "btntax";
            btntax.Size = new Size(170, 170);
            btntax.TabIndex = 3;
            btntax.Text = "Attendance\r\n\r\n";
            btntax.TextAlign = ContentAlignment.BottomCenter;
            btntax.UseVisualStyleBackColor = false;
            btntax.Click += btntax_Click;
            // 
            // btnbenefits
            // 
            btnbenefits.BackColor = SystemColors.ButtonFace;
            btnbenefits.Cursor = Cursors.Hand;
            btnbenefits.Font = new Font("Arial", 9F);
            btnbenefits.Image = (Image)resources.GetObject("btnbenefits.Image");
            btnbenefits.Location = new Point(808, 400);
            btnbenefits.Margin = new Padding(10);
            btnbenefits.Name = "btnbenefits";
            btnbenefits.Size = new Size(170, 170);
            btnbenefits.TabIndex = 4;
            btnbenefits.Text = "Benefits\r\nAdministration\r\n\r\n";
            btnbenefits.TextAlign = ContentAlignment.BottomCenter;
            btnbenefits.UseVisualStyleBackColor = false;
            btnbenefits.Click += btnbenefits_Click;
            // 
            // btnsettings
            // 
            btnsettings.BackColor = SystemColors.ButtonFace;
            btnsettings.Cursor = Cursors.Hand;
            btnsettings.Font = new Font("Arial", 9F);
            btnsettings.Image = (Image)resources.GetObject("btnsettings.Image");
            btnsettings.Location = new Point(998, 400);
            btnsettings.Margin = new Padding(10);
            btnsettings.Name = "btnsettings";
            btnsettings.Size = new Size(170, 170);
            btnsettings.TabIndex = 5;
            btnsettings.Text = "Settings\r\n\r\n";
            btnsettings.TextAlign = ContentAlignment.BottomCenter;
            btnsettings.UseVisualStyleBackColor = false;
            btnsettings.Click += btnsettings_Click;
            // 
            // emp_list
            // 
            emp_list.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            emp_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            emp_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            emp_list.GridColor = SystemColors.ControlLight;
            emp_list.Location = new Point(32, 224);
            emp_list.Name = "emp_list";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            emp_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            emp_list.Size = new Size(543, 165);
            emp_list.TabIndex = 6;
            // 
            // emp_panel
            // 
            emp_panel.BorderStyle = BorderStyle.FixedSingle;
            emp_panel.Controls.Add(label2);
            emp_panel.Controls.Add(total_emp);
            emp_panel.Controls.Add(total_emp_value);
            emp_panel.Location = new Point(32, 24);
            emp_panel.Name = "emp_panel";
            emp_panel.Size = new Size(242, 145);
            emp_panel.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 26);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(115, 17);
            label2.TabIndex = 28;
            label2.Text = "Total Employees";
            // 
            // total_emp
            // 
            total_emp.AutoSize = true;
            total_emp.Font = new Font("Arial", 26.25F);
            total_emp.Location = new Point(95, 62);
            total_emp.Margin = new Padding(0);
            total_emp.Name = "total_emp";
            total_emp.Size = new Size(36, 40);
            total_emp.TabIndex = 27;
            total_emp.Text = "1";
            // 
            // total_emp_value
            // 
            total_emp_value.AutoSize = true;
            total_emp_value.Font = new Font("Arial", 26.25F);
            total_emp_value.Location = new Point(100, 57);
            total_emp_value.Margin = new Padding(0);
            total_emp_value.Name = "total_emp_value";
            total_emp_value.Size = new Size(36, 40);
            total_emp_value.TabIndex = 26;
            total_emp_value.Text = "1";
            // 
            // expense_panel
            // 
            expense_panel.BorderStyle = BorderStyle.FixedSingle;
            expense_panel.Controls.Add(label3);
            expense_panel.Controls.Add(total_expense);
            expense_panel.Location = new Point(333, 24);
            expense_panel.Name = "expense_panel";
            expense_panel.Size = new Size(242, 145);
            expense_panel.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 26);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(119, 17);
            label3.TabIndex = 30;
            label3.Text = "Total Expenditure";
            // 
            // total_expense
            // 
            total_expense.AutoSize = true;
            total_expense.Font = new Font("Arial", 26.25F);
            total_expense.Location = new Point(102, 62);
            total_expense.Margin = new Padding(0);
            total_expense.Name = "total_expense";
            total_expense.Size = new Size(36, 40);
            total_expense.TabIndex = 29;
            total_expense.Text = "1";
            // 
            // departments_panel
            // 
            departments_panel.BorderStyle = BorderStyle.FixedSingle;
            departments_panel.Controls.Add(label7);
            departments_panel.Controls.Add(total_departments);
            departments_panel.Location = new Point(926, 24);
            departments_panel.Name = "departments_panel";
            departments_panel.Size = new Size(242, 145);
            departments_panel.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(62, 26);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(127, 17);
            label7.TabIndex = 34;
            label7.Text = "Total Departments";
            // 
            // total_departments
            // 
            total_departments.AutoSize = true;
            total_departments.Font = new Font("Arial", 26.25F);
            total_departments.Location = new Point(107, 62);
            total_departments.Margin = new Padding(0);
            total_departments.Name = "total_departments";
            total_departments.Size = new Size(36, 40);
            total_departments.TabIndex = 33;
            total_departments.Text = "2";
            // 
            // ave_pay_panel
            // 
            ave_pay_panel.BorderStyle = BorderStyle.FixedSingle;
            ave_pay_panel.Controls.Add(label5);
            ave_pay_panel.Controls.Add(ave_pay);
            ave_pay_panel.Location = new Point(618, 24);
            ave_pay_panel.Name = "ave_pay_panel";
            ave_pay_panel.Size = new Size(242, 145);
            ave_pay_panel.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(79, 26);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(90, 17);
            label5.TabIndex = 32;
            label5.Text = "Average Pay";
            // 
            // ave_pay
            // 
            ave_pay.AutoSize = true;
            ave_pay.Font = new Font("Arial", 26.25F);
            ave_pay.Location = new Point(57, 62);
            ave_pay.Margin = new Padding(0);
            ave_pay.Name = "ave_pay";
            ave_pay.Size = new Size(126, 40);
            ave_pay.TabIndex = 31;
            ave_pay.Text = "₱1,100";
            // 
            // dept_list
            // 
            dept_list.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dept_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dept_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dept_list.GridColor = SystemColors.ControlLight;
            dept_list.Location = new Point(32, 446);
            dept_list.Name = "dept_list";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dept_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dept_list.Size = new Size(543, 124);
            dept_list.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 203);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(107, 18);
            label1.TabIndex = 33;
            label1.Text = "Employee List";
            // 
            // pnlcenter
            // 
            pnlcenter.BackColor = SystemColors.Control;
            pnlcenter.Controls.Add(label4);
            pnlcenter.Controls.Add(label1);
            pnlcenter.Controls.Add(dept_list);
            pnlcenter.Controls.Add(ave_pay_panel);
            pnlcenter.Controls.Add(departments_panel);
            pnlcenter.Controls.Add(expense_panel);
            pnlcenter.Controls.Add(emp_panel);
            pnlcenter.Controls.Add(emp_list);
            pnlcenter.Controls.Add(btnsettings);
            pnlcenter.Controls.Add(btnbenefits);
            pnlcenter.Controls.Add(btntax);
            pnlcenter.Controls.Add(btnreportscenter);
            pnlcenter.Controls.Add(btnpayrollcenter);
            pnlcenter.Controls.Add(btnemployeecenter);
            pnlcenter.Location = new Point(-3, 67);
            pnlcenter.Name = "pnlcenter";
            pnlcenter.Size = new Size(1188, 591);
            pnlcenter.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 426);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(129, 18);
            label4.TabIndex = 34;
            label4.Text = "Departments List";
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 651);
            Controls.Add(gradientPanel1);
            Controls.Add(pnlcenter);
            Name = "dashboard";
            Text = "dashboard";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emp_list).EndInit();
            emp_panel.ResumeLayout(false);
            emp_panel.PerformLayout();
            expense_panel.ResumeLayout(false);
            expense_panel.PerformLayout();
            departments_panel.ResumeLayout(false);
            departments_panel.PerformLayout();
            ave_pay_panel.ResumeLayout(false);
            ave_pay_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dept_list).EndInit();
            pnlcenter.ResumeLayout(false);
            pnlcenter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox logo;
        private Label label8;
        private Label logout;
        private Label home;
        private GradientPanel gradientPanel1;
        private Button btnemployeecenter;
        private Button btnpayrollcenter;
        private Button btnreportscenter;
        private Button btntax;
        private Button btnbenefits;
        private Button btnsettings;
        private DataGridView emp_list;
        private Panel emp_panel;
        private Label label2;
        private Label total_emp;
        private Label total_emp_value;
        private Panel expense_panel;
        private Label label3;
        private Label total_expense;
        private Panel departments_panel;
        private Label label7;
        private Label total_departments;
        private Panel ave_pay_panel;
        private Label label5;
        private Label ave_pay;
        private DataGridView dept_list;
        private Label label1;
        private Panel pnlcenter;
        private Label label4;
    }
}