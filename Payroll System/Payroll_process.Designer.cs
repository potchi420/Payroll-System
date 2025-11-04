namespace Payroll_System
{
    partial class Payroll_process
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
            panel2 = new Panel();
            deductions_box = new GroupBox();
            pagibig_value = new Label();
            philhealth_value = new Label();
            sss_value = new Label();
            philhealth_label = new Label();
            pagibig_label = new Label();
            sss_label = new Label();
            load_employee_box = new GroupBox();
            load_employee_btn = new Button();
            cmbname = new ComboBox();
            employee_label = new Label();
            payroll_computation_box = new GroupBox();
            gross_pay_value = new Label();
            overtime_value = new Label();
            basic_salary_value = new Label();
            label2 = new Label();
            overtime_label = new Label();
            basic_salary_label = new Label();
            payroll_summary_box = new GroupBox();
            total_deductions_value = new Label();
            net_pay_value = new Label();
            total_deductions_label = new Label();
            netpay_label = new Label();
            actions_box = new GroupBox();
            save_record_btn = new Button();
            print_payslip_btn = new Button();
            export_btn = new Button();
            generate_payslip_btn = new Button();
            pay_period_box = new GroupBox();
            label3 = new Label();
            payperiodEnd = new DateTimePicker();
            label1 = new Label();
            payperiodStart = new DateTimePicker();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            home = new Label();
            logout = new Label();
            label8 = new Label();
            logo = new PictureBox();
            logo_btn = new PictureBox();
            label6 = new Label();
            logout_btn = new Label();
            home_btn = new Label();
            gradientPanel1 = new GradientPanel();
            deductions_box.SuspendLayout();
            load_employee_box.SuspendLayout();
            payroll_computation_box.SuspendLayout();
            payroll_summary_box.SuspendLayout();
            actions_box.SuspendLayout();
            pay_period_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo_btn).BeginInit();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Location = new Point(1, 418);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 8);
            panel2.TabIndex = 13;
            // 
            // deductions_box
            // 
            deductions_box.Controls.Add(pagibig_value);
            deductions_box.Controls.Add(philhealth_value);
            deductions_box.Controls.Add(sss_value);
            deductions_box.Controls.Add(philhealth_label);
            deductions_box.Controls.Add(pagibig_label);
            deductions_box.Controls.Add(sss_label);
            deductions_box.FlatStyle = FlatStyle.Flat;
            deductions_box.Font = new Font("Arial", 11F);
            deductions_box.Location = new Point(461, 326);
            deductions_box.Name = "deductions_box";
            deductions_box.Size = new Size(403, 141);
            deductions_box.TabIndex = 14;
            deductions_box.TabStop = false;
            deductions_box.Text = "Deductions";
            // 
            // pagibig_value
            // 
            pagibig_value.AutoSize = true;
            pagibig_value.Location = new Point(297, 101);
            pagibig_value.Name = "pagibig_value";
            pagibig_value.Size = new Size(46, 17);
            pagibig_value.TabIndex = 14;
            pagibig_value.Text = "₱0.00";
            // 
            // philhealth_value
            // 
            philhealth_value.AutoSize = true;
            philhealth_value.Location = new Point(297, 67);
            philhealth_value.Name = "philhealth_value";
            philhealth_value.Size = new Size(46, 17);
            philhealth_value.TabIndex = 13;
            philhealth_value.Text = "₱0.00";
            // 
            // sss_value
            // 
            sss_value.AutoSize = true;
            sss_value.Location = new Point(297, 33);
            sss_value.Name = "sss_value";
            sss_value.Size = new Size(46, 17);
            sss_value.TabIndex = 12;
            sss_value.Text = "₱0.00";
            // 
            // philhealth_label
            // 
            philhealth_label.AutoSize = true;
            philhealth_label.Location = new Point(24, 67);
            philhealth_label.Name = "philhealth_label";
            philhealth_label.Size = new Size(77, 17);
            philhealth_label.TabIndex = 11;
            philhealth_label.Text = "PhilHealth:";
            // 
            // pagibig_label
            // 
            pagibig_label.AutoSize = true;
            pagibig_label.Location = new Point(24, 101);
            pagibig_label.Name = "pagibig_label";
            pagibig_label.Size = new Size(70, 17);
            pagibig_label.TabIndex = 10;
            pagibig_label.Text = "Pag-IBIG:";
            // 
            // sss_label
            // 
            sss_label.AutoSize = true;
            sss_label.Location = new Point(24, 33);
            sss_label.Name = "sss_label";
            sss_label.Size = new Size(46, 17);
            sss_label.TabIndex = 9;
            sss_label.Text = "SSS: ";
            // 
            // load_employee_box
            // 
            load_employee_box.BackColor = Color.Transparent;
            load_employee_box.Controls.Add(load_employee_btn);
            load_employee_box.Controls.Add(cmbname);
            load_employee_box.Controls.Add(employee_label);
            load_employee_box.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            load_employee_box.Location = new Point(12, 102);
            load_employee_box.Name = "load_employee_box";
            load_employee_box.Size = new Size(852, 202);
            load_employee_box.TabIndex = 15;
            load_employee_box.TabStop = false;
            load_employee_box.Text = "Select Employee";
            // 
            // load_employee_btn
            // 
            load_employee_btn.Cursor = Cursors.Hand;
            load_employee_btn.Font = new Font("Arial", 11F);
            load_employee_btn.Location = new Point(22, 118);
            load_employee_btn.Name = "load_employee_btn";
            load_employee_btn.Size = new Size(171, 32);
            load_employee_btn.TabIndex = 2;
            load_employee_btn.Text = "Load Employee Data";
            load_employee_btn.UseVisualStyleBackColor = true;
            load_employee_btn.Click += load_employee_btn_Click;
            // 
            // cmbname
            // 
            cmbname.FormattingEnabled = true;
            cmbname.Location = new Point(22, 74);
            cmbname.Name = "cmbname";
            cmbname.Size = new Size(324, 26);
            cmbname.TabIndex = 1;
            cmbname.SelectedIndexChanged += cmbname_SelectedIndexChanged;
            // 
            // employee_label
            // 
            employee_label.AutoSize = true;
            employee_label.Font = new Font("Arial", 11F);
            employee_label.Location = new Point(22, 38);
            employee_label.Name = "employee_label";
            employee_label.Size = new Size(73, 17);
            employee_label.TabIndex = 0;
            employee_label.Text = "Employee";
            // 
            // payroll_computation_box
            // 
            payroll_computation_box.Controls.Add(gross_pay_value);
            payroll_computation_box.Controls.Add(overtime_value);
            payroll_computation_box.Controls.Add(basic_salary_value);
            payroll_computation_box.Controls.Add(label2);
            payroll_computation_box.Controls.Add(overtime_label);
            payroll_computation_box.Controls.Add(basic_salary_label);
            payroll_computation_box.Font = new Font("Arial", 11F);
            payroll_computation_box.Location = new Point(12, 326);
            payroll_computation_box.Name = "payroll_computation_box";
            payroll_computation_box.Size = new Size(403, 141);
            payroll_computation_box.TabIndex = 16;
            payroll_computation_box.TabStop = false;
            payroll_computation_box.Text = "Payroll Computation";
            // 
            // gross_pay_value
            // 
            gross_pay_value.AutoSize = true;
            gross_pay_value.Location = new Point(300, 101);
            gross_pay_value.Name = "gross_pay_value";
            gross_pay_value.Size = new Size(46, 17);
            gross_pay_value.TabIndex = 8;
            gross_pay_value.Text = "₱0.00";
            // 
            // overtime_value
            // 
            overtime_value.AutoSize = true;
            overtime_value.Location = new Point(300, 67);
            overtime_value.Name = "overtime_value";
            overtime_value.Size = new Size(46, 17);
            overtime_value.TabIndex = 7;
            overtime_value.Text = "₱0.00";
            // 
            // basic_salary_value
            // 
            basic_salary_value.AutoSize = true;
            basic_salary_value.Location = new Point(300, 33);
            basic_salary_value.Name = "basic_salary_value";
            basic_salary_value.Size = new Size(46, 17);
            basic_salary_value.TabIndex = 6;
            basic_salary_value.Text = "₱0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 101);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 5;
            label2.Text = "Gross Pay:";
            // 
            // overtime_label
            // 
            overtime_label.AutoSize = true;
            overtime_label.Location = new Point(22, 67);
            overtime_label.Name = "overtime_label";
            overtime_label.Size = new Size(157, 17);
            overtime_label.TabIndex = 3;
            overtime_label.Text = "Overtime and Benefits:";
            // 
            // basic_salary_label
            // 
            basic_salary_label.AutoSize = true;
            basic_salary_label.Location = new Point(22, 33);
            basic_salary_label.Name = "basic_salary_label";
            basic_salary_label.Size = new Size(98, 17);
            basic_salary_label.TabIndex = 2;
            basic_salary_label.Text = "Basic Salary: ";
            // 
            // payroll_summary_box
            // 
            payroll_summary_box.Controls.Add(total_deductions_value);
            payroll_summary_box.Controls.Add(net_pay_value);
            payroll_summary_box.Controls.Add(total_deductions_label);
            payroll_summary_box.Controls.Add(netpay_label);
            payroll_summary_box.Font = new Font("Arial", 11F);
            payroll_summary_box.Location = new Point(12, 489);
            payroll_summary_box.Name = "payroll_summary_box";
            payroll_summary_box.Size = new Size(403, 141);
            payroll_summary_box.TabIndex = 15;
            payroll_summary_box.TabStop = false;
            payroll_summary_box.Text = "Payroll Summary";
            // 
            // total_deductions_value
            // 
            total_deductions_value.AutoSize = true;
            total_deductions_value.Location = new Point(300, 38);
            total_deductions_value.Name = "total_deductions_value";
            total_deductions_value.Size = new Size(46, 17);
            total_deductions_value.TabIndex = 3;
            total_deductions_value.Text = "₱0.00";
            total_deductions_value.Click += total_deductions_value_Click;
            // 
            // net_pay_value
            // 
            net_pay_value.AutoSize = true;
            net_pay_value.Location = new Point(300, 80);
            net_pay_value.Name = "net_pay_value";
            net_pay_value.Size = new Size(46, 17);
            net_pay_value.TabIndex = 2;
            net_pay_value.Text = "₱0.00";
            // 
            // total_deductions_label
            // 
            total_deductions_label.AutoSize = true;
            total_deductions_label.Location = new Point(22, 38);
            total_deductions_label.Name = "total_deductions_label";
            total_deductions_label.Size = new Size(120, 17);
            total_deductions_label.TabIndex = 1;
            total_deductions_label.Text = "Total Deductions:";
            // 
            // netpay_label
            // 
            netpay_label.AutoSize = true;
            netpay_label.Location = new Point(22, 80);
            netpay_label.Name = "netpay_label";
            netpay_label.Size = new Size(63, 17);
            netpay_label.TabIndex = 0;
            netpay_label.Text = "Net Pay:";
            // 
            // actions_box
            // 
            actions_box.Controls.Add(save_record_btn);
            actions_box.Controls.Add(print_payslip_btn);
            actions_box.Controls.Add(export_btn);
            actions_box.Controls.Add(generate_payslip_btn);
            actions_box.Font = new Font("Arial", 11F);
            actions_box.Location = new Point(461, 489);
            actions_box.Name = "actions_box";
            actions_box.Size = new Size(403, 141);
            actions_box.TabIndex = 17;
            actions_box.TabStop = false;
            actions_box.Text = "Payslip-Actions";
            // 
            // save_record_btn
            // 
            save_record_btn.Cursor = Cursors.Hand;
            save_record_btn.Location = new Point(208, 80);
            save_record_btn.Name = "save_record_btn";
            save_record_btn.Size = new Size(159, 36);
            save_record_btn.TabIndex = 3;
            save_record_btn.Text = "Save Record";
            save_record_btn.UseVisualStyleBackColor = true;
            save_record_btn.Click += save_record_btn_Click;
            // 
            // print_payslip_btn
            // 
            print_payslip_btn.Cursor = Cursors.Hand;
            print_payslip_btn.Location = new Point(34, 80);
            print_payslip_btn.Name = "print_payslip_btn";
            print_payslip_btn.Size = new Size(168, 36);
            print_payslip_btn.TabIndex = 2;
            print_payslip_btn.Text = "Print Payslip";
            print_payslip_btn.UseVisualStyleBackColor = true;
            print_payslip_btn.Click += print_payslip_btn_Click;
            // 
            // export_btn
            // 
            export_btn.Cursor = Cursors.Hand;
            export_btn.Location = new Point(208, 38);
            export_btn.Name = "export_btn";
            export_btn.Size = new Size(159, 36);
            export_btn.TabIndex = 1;
            export_btn.Text = "Export Payslip";
            export_btn.UseVisualStyleBackColor = true;
            // 
            // generate_payslip_btn
            // 
            generate_payslip_btn.Cursor = Cursors.Hand;
            generate_payslip_btn.Location = new Point(34, 38);
            generate_payslip_btn.Name = "generate_payslip_btn";
            generate_payslip_btn.Size = new Size(168, 36);
            generate_payslip_btn.TabIndex = 0;
            generate_payslip_btn.Text = "Generate Payslip";
            generate_payslip_btn.UseVisualStyleBackColor = true;
            generate_payslip_btn.Click += generate_payslip_btn_Click;
            // 
            // pay_period_box
            // 
            pay_period_box.Controls.Add(label3);
            pay_period_box.Controls.Add(payperiodEnd);
            pay_period_box.Controls.Add(label1);
            pay_period_box.Controls.Add(payperiodStart);
            pay_period_box.Controls.Add(groupBox1);
            pay_period_box.Font = new Font("Arial", 11F);
            pay_period_box.Location = new Point(901, 102);
            pay_period_box.Name = "pay_period_box";
            pay_period_box.Size = new Size(271, 202);
            pay_period_box.TabIndex = 18;
            pay_period_box.TabStop = false;
            pay_period_box.Text = "Pay Period";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 126);
            label3.Name = "label3";
            label3.Size = new Size(113, 17);
            label3.TabIndex = 25;
            label3.Text = "Pay Period End:";
            // 
            // payperiodEnd
            // 
            payperiodEnd.Location = new Point(40, 153);
            payperiodEnd.Name = "payperiodEnd";
            payperiodEnd.Size = new Size(200, 24);
            payperiodEnd.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 41);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 23;
            label1.Text = "Pay Period Start:";
            // 
            // payperiodStart
            // 
            payperiodStart.Location = new Point(40, 72);
            payperiodStart.Name = "payperiodStart";
            payperiodStart.Size = new Size(200, 24);
            payperiodStart.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Arial", 11F);
            groupBox1.Location = new Point(6, 269);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 274);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payroll Breakdown";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Arial", 11F);
            groupBox2.Location = new Point(901, 324);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(271, 306);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Payroll Breakdown";
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
            // 
            // logo_btn
            // 
            logo_btn.BackColor = Color.Transparent;
            logo_btn.Cursor = Cursors.Hand;
            logo_btn.Image = Properties.Resources.icon;
            logo_btn.Location = new Point(0, 3);
            logo_btn.Name = "logo_btn";
            logo_btn.Size = new Size(76, 75);
            logo_btn.SizeMode = PictureBoxSizeMode.StretchImage;
            logo_btn.TabIndex = 22;
            logo_btn.TabStop = false;
            logo_btn.Click += logo_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(82, 30);
            label6.Name = "label6";
            label6.Size = new Size(258, 24);
            label6.TabIndex = 23;
            label6.Text = "PCU PAYROLL SYSTEM";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // logout_btn
            // 
            logout_btn.AutoSize = true;
            logout_btn.BackColor = Color.Transparent;
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.Transparent;
            logout_btn.Location = new Point(1090, 30);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(85, 24);
            logout_btn.TabIndex = 24;
            logout_btn.Text = "Log Out";
            logout_btn.TextAlign = ContentAlignment.TopCenter;
            logout_btn.Click += logout_btn_Click;
            // 
            // home_btn
            // 
            home_btn.AutoSize = true;
            home_btn.BackColor = Color.Transparent;
            home_btn.Cursor = Cursors.Hand;
            home_btn.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home_btn.ForeColor = Color.Transparent;
            home_btn.Location = new Point(1018, 30);
            home_btn.Name = "home_btn";
            home_btn.Size = new Size(66, 24);
            home_btn.TabIndex = 24;
            home_btn.Text = "Home";
            home_btn.TextAlign = ContentAlignment.TopCenter;
            home_btn.Click += home_btn_Click;
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(home_btn);
            gradientPanel1.Controls.Add(logout_btn);
            gradientPanel1.Controls.Add(label6);
            gradientPanel1.Controls.Add(logo_btn);
            gradientPanel1.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel1.Location = new Point(-3, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1191, 76);
            gradientPanel1.TabIndex = 31;
            // 
            // Payroll_process
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 651);
            Controls.Add(gradientPanel1);
            Controls.Add(groupBox2);
            Controls.Add(pay_period_box);
            Controls.Add(actions_box);
            Controls.Add(payroll_summary_box);
            Controls.Add(payroll_computation_box);
            Controls.Add(load_employee_box);
            Controls.Add(deductions_box);
            Controls.Add(panel2);
            Name = "Payroll_process";
            Text = "Payroll_process";
            deductions_box.ResumeLayout(false);
            deductions_box.PerformLayout();
            load_employee_box.ResumeLayout(false);
            load_employee_box.PerformLayout();
            payroll_computation_box.ResumeLayout(false);
            payroll_computation_box.PerformLayout();
            payroll_summary_box.ResumeLayout(false);
            payroll_summary_box.PerformLayout();
            actions_box.ResumeLayout(false);
            pay_period_box.ResumeLayout(false);
            pay_period_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo_btn).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private GroupBox deductions_box;
        private GroupBox load_employee_box;
        private GroupBox payroll_computation_box;
        private GroupBox payroll_summary_box;
        private GroupBox groupBox4;
        private GroupBox actions_box;
        private ComboBox cmbname;
        private Label employee_label;
        private Button load_employee_btn;
        private GroupBox pay_period_box;
        private Button generate_payslip_btn;
        private Button print_payslip_btn;
        private Button export_btn;
        private Button save_record_btn;
        private Label netpay_label;
        private Label total_deductions_label;
        private Label net_pay_value;
        private Label total_deductions_value;
        private Label label2;
        private Label overtime_label;
        private Label basic_salary_label;
        private Label pagibig_value;
        private Label philhealth_value;
        private Label sss_value;
        private Label philhealth_label;
        private Label pagibig_label;
        private Label sss_label;
        private Label gross_pay_value;
        private Label overtime_value;
        private Label basic_salary_value;
        private Label label1;
        private DateTimePicker payperiodStart;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private DateTimePicker payperiodEnd;
        private Label home;
        private Label logout;
        private Label label8;
        private PictureBox logo;
        private PictureBox logo_btn;
        private Label label6;
        private Label logout_btn;
        private Label home_btn;
        private GradientPanel gradientPanel1;
    }
}