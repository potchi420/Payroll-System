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
            comboBox1 = new ComboBox();
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
            payroll_breakdown_box = new GroupBox();
            dataGridView1 = new DataGridView();
            btnhome = new Button();
            btnemployeeside = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            pnlside = new Panel();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            gradientPanel1 = new GradientPanel();
            deductions_box.SuspendLayout();
            load_employee_box.SuspendLayout();
            payroll_computation_box.SuspendLayout();
            payroll_summary_box.SuspendLayout();
            actions_box.SuspendLayout();
            payroll_breakdown_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            deductions_box.Location = new Point(665, 331);
            deductions_box.Name = "deductions_box";
            deductions_box.Size = new Size(403, 141);
            deductions_box.TabIndex = 14;
            deductions_box.TabStop = false;
            deductions_box.Text = "Deductions";
            // 
            // pagibig_value
            // 
            pagibig_value.AutoSize = true;
            pagibig_value.Location = new Point(336, 101);
            pagibig_value.Name = "pagibig_value";
            pagibig_value.Size = new Size(46, 17);
            pagibig_value.TabIndex = 14;
            pagibig_value.Text = "₱0.00";
            // 
            // philhealth_value
            // 
            philhealth_value.AutoSize = true;
            philhealth_value.Location = new Point(336, 67);
            philhealth_value.Name = "philhealth_value";
            philhealth_value.Size = new Size(46, 17);
            philhealth_value.TabIndex = 13;
            philhealth_value.Text = "₱0.00";
            philhealth_value.Click += label3_Click;
            // 
            // sss_value
            // 
            sss_value.AutoSize = true;
            sss_value.Location = new Point(336, 33);
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
            load_employee_box.Controls.Add(comboBox1);
            load_employee_box.Controls.Add(employee_label);
            load_employee_box.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            load_employee_box.Location = new Point(216, 107);
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(324, 26);
            comboBox1.TabIndex = 1;
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
            payroll_computation_box.Location = new Point(216, 331);
            payroll_computation_box.Name = "payroll_computation_box";
            payroll_computation_box.Size = new Size(403, 141);
            payroll_computation_box.TabIndex = 16;
            payroll_computation_box.TabStop = false;
            payroll_computation_box.Text = "Payroll Computation";
            // 
            // gross_pay_value
            // 
            gross_pay_value.AutoSize = true;
            gross_pay_value.Location = new Point(334, 101);
            gross_pay_value.Name = "gross_pay_value";
            gross_pay_value.Size = new Size(46, 17);
            gross_pay_value.TabIndex = 8;
            gross_pay_value.Text = "₱0.00";
            // 
            // overtime_value
            // 
            overtime_value.AutoSize = true;
            overtime_value.Location = new Point(334, 67);
            overtime_value.Name = "overtime_value";
            overtime_value.Size = new Size(46, 17);
            overtime_value.TabIndex = 7;
            overtime_value.Text = "₱0.00";
            // 
            // basic_salary_value
            // 
            basic_salary_value.AutoSize = true;
            basic_salary_value.Location = new Point(334, 33);
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
            payroll_summary_box.Location = new Point(216, 494);
            payroll_summary_box.Name = "payroll_summary_box";
            payroll_summary_box.Size = new Size(403, 141);
            payroll_summary_box.TabIndex = 15;
            payroll_summary_box.TabStop = false;
            payroll_summary_box.Text = "Payroll Summary";
            // 
            // total_deductions_value
            // 
            total_deductions_value.AutoSize = true;
            total_deductions_value.Location = new Point(334, 38);
            total_deductions_value.Name = "total_deductions_value";
            total_deductions_value.Size = new Size(46, 17);
            total_deductions_value.TabIndex = 3;
            total_deductions_value.Text = "₱0.00";
            // 
            // net_pay_value
            // 
            net_pay_value.AutoSize = true;
            net_pay_value.Location = new Point(334, 80);
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
            actions_box.Location = new Point(665, 494);
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
            print_payslip_btn.Click += button3_Click;
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
            // 
            // payroll_breakdown_box
            // 
            payroll_breakdown_box.Controls.Add(dataGridView1);
            payroll_breakdown_box.Font = new Font("Arial", 11F);
            payroll_breakdown_box.Location = new Point(1105, 107);
            payroll_breakdown_box.Name = "payroll_breakdown_box";
            payroll_breakdown_box.Size = new Size(301, 528);
            payroll_breakdown_box.TabIndex = 18;
            payroll_breakdown_box.TabStop = false;
            payroll_breakdown_box.Text = "Payroll Breakdown";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(213, 410);
            dataGridView1.TabIndex = 0;
            // 
            // btnhome
            // 
            btnhome.BackColor = SystemColors.Control;
            btnhome.ForeColor = SystemColors.InfoText;
            btnhome.Location = new Point(0, 3);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(176, 64);
            btnhome.TabIndex = 0;
            btnhome.Text = "Home";
            btnhome.UseVisualStyleBackColor = false;
            btnhome.Click += btnhome_Click_1;
            // 
            // btnemployeeside
            // 
            btnemployeeside.BackColor = Color.Transparent;
            btnemployeeside.ForeColor = SystemColors.InfoText;
            btnemployeeside.Location = new Point(0, 73);
            btnemployeeside.Name = "btnemployeeside";
            btnemployeeside.Size = new Size(176, 36);
            btnemployeeside.TabIndex = 1;
            btnemployeeside.Text = "Add Category";
            btnemployeeside.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(0, 117);
            button1.Name = "button1";
            button1.Size = new Size(176, 36);
            button1.TabIndex = 2;
            button1.Text = "Add Employees";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.ForeColor = SystemColors.InfoText;
            button2.Location = new Point(0, 162);
            button2.Name = "button2";
            button2.Size = new Size(176, 36);
            button2.TabIndex = 3;
            button2.Text = "Employee Report";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.ForeColor = SystemColors.InfoText;
            button3.Location = new Point(0, 208);
            button3.Name = "button3";
            button3.Size = new Size(176, 36);
            button3.TabIndex = 4;
            button3.Text = "Salary Report";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.ForeColor = SystemColors.InfoText;
            button4.Location = new Point(0, 254);
            button4.Name = "button4";
            button4.Size = new Size(176, 36);
            button4.TabIndex = 5;
            button4.Text = "Monthly Report";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.ForeColor = SystemColors.InfoText;
            button5.Location = new Point(0, 301);
            button5.Name = "button5";
            button5.Size = new Size(176, 36);
            button5.TabIndex = 6;
            button5.Text = "Early Report";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.ForeColor = SystemColors.InfoText;
            button6.Location = new Point(0, 350);
            button6.Name = "button6";
            button6.Size = new Size(176, 36);
            button6.TabIndex = 7;
            button6.Text = "Change Password";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.ForeColor = SystemColors.InfoText;
            button7.Location = new Point(0, 400);
            button7.Name = "button7";
            button7.Size = new Size(176, 36);
            button7.TabIndex = 8;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = false;
            // 
            // pnlside
            // 
            pnlside.BackColor = SystemColors.GradientInactiveCaption;
            pnlside.Controls.Add(button7);
            pnlside.Controls.Add(button6);
            pnlside.Controls.Add(button5);
            pnlside.Controls.Add(button4);
            pnlside.Controls.Add(button3);
            pnlside.Controls.Add(button2);
            pnlside.Controls.Add(button1);
            pnlside.Controls.Add(btnemployeeside);
            pnlside.Controls.Add(btnhome);
            pnlside.Location = new Point(2, 75);
            pnlside.Name = "pnlside";
            pnlside.Size = new Size(176, 575);
            pnlside.TabIndex = 19;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.icon;
            pictureBox5.Location = new Point(0, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(76, 75);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
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
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(label8);
            gradientPanel1.Controls.Add(pictureBox5);
            gradientPanel1.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel1.Location = new Point(2, 1);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1425, 76);
            gradientPanel1.TabIndex = 20;
            // 
            // Payroll_process
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 651);
            Controls.Add(gradientPanel1);
            Controls.Add(pnlside);
            Controls.Add(payroll_breakdown_box);
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
            payroll_breakdown_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private ComboBox comboBox1;
        private Label employee_label;
        private Button load_employee_btn;
        private GroupBox payroll_breakdown_box;
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
        private DataGridView dataGridView1;
        private Button btnhome;
        private Button btnemployeeside;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Panel pnlside;
        private PictureBox pictureBox5;
        private Label label8;
        private GradientPanel gradientPanel1;
    }
}