namespace Payroll_System
{
    partial class attendance
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
            home = new Label();
            logout = new Label();
            label5 = new Label();
            logo = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            attendance_date = new DateTimePicker();
            label6 = new Label();
            clearBTN = new Button();
            saveAttendanceBTN = new Button();
            overtimed_hours = new NumericUpDown();
            label4 = new Label();
            days_worked = new NumericUpDown();
            label3 = new Label();
            employee_searchbox = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            attendance_table = new DataGridView();
            gradientPanel1 = new GradientPanel();
            home1 = new Label();
            logout1 = new Label();
            label8 = new Label();
            logo1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)overtimed_hours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)days_worked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)attendance_table).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo1).BeginInit();
            SuspendLayout();
            // 
            // home
            // 
            home.AutoSize = true;
            home.BackColor = Color.Transparent;
            home.Cursor = Cursors.Hand;
            home.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            logout.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.Transparent;
            logout.Location = new Point(1090, 30);
            logout.Name = "logout";
            logout.Size = new Size(85, 24);
            logout.TabIndex = 24;
            logout.Text = "Log Out";
            logout.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(82, 30);
            label5.Name = "label5";
            label5.Size = new Size(258, 24);
            label5.TabIndex = 23;
            label5.Text = "PCU PAYROLL SYSTEM";
            label5.TextAlign = ContentAlignment.TopCenter;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(89, 173);
            label1.Name = "label1";
            label1.Size = new Size(216, 24);
            label1.TabIndex = 0;
            label1.Text = "Attendance Checker";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(attendance_date);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(clearBTN);
            panel1.Controls.Add(saveAttendanceBTN);
            panel1.Controls.Add(overtimed_hours);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(days_worked);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(employee_searchbox);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(89, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 322);
            panel1.TabIndex = 1;
            // 
            // attendance_date
            // 
            attendance_date.Location = new Point(12, 201);
            attendance_date.Name = "attendance_date";
            attendance_date.Size = new Size(200, 20);
            attendance_date.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F);
            label6.Location = new Point(12, 182);
            label6.Name = "label6";
            label6.Size = new Size(104, 16);
            label6.TabIndex = 7;
            label6.Text = "Attendance Date";
            // 
            // clearBTN
            // 
            clearBTN.BackColor = Color.SteelBlue;
            clearBTN.Cursor = Cursors.Hand;
            clearBTN.FlatAppearance.BorderSize = 0;
            clearBTN.FlatStyle = FlatStyle.Flat;
            clearBTN.Font = new Font("Arial", 9.75F);
            clearBTN.ForeColor = Color.White;
            clearBTN.Location = new Point(12, 272);
            clearBTN.Name = "clearBTN";
            clearBTN.Size = new Size(214, 31);
            clearBTN.TabIndex = 6;
            clearBTN.Text = "Clear Fields";
            clearBTN.UseVisualStyleBackColor = false;
            clearBTN.Click += clearBTN_Click;
            // 
            // saveAttendanceBTN
            // 
            saveAttendanceBTN.BackColor = Color.SteelBlue;
            saveAttendanceBTN.Cursor = Cursors.Hand;
            saveAttendanceBTN.FlatAppearance.BorderSize = 0;
            saveAttendanceBTN.FlatStyle = FlatStyle.Flat;
            saveAttendanceBTN.Font = new Font("Arial", 9.75F);
            saveAttendanceBTN.ForeColor = Color.White;
            saveAttendanceBTN.Location = new Point(12, 235);
            saveAttendanceBTN.Name = "saveAttendanceBTN";
            saveAttendanceBTN.Size = new Size(214, 31);
            saveAttendanceBTN.TabIndex = 3;
            saveAttendanceBTN.Text = "Save Attendance";
            saveAttendanceBTN.UseVisualStyleBackColor = false;
            saveAttendanceBTN.Click += saveAttendanceBTN_Click;
            // 
            // overtimed_hours
            // 
            overtimed_hours.Location = new Point(12, 150);
            overtimed_hours.Name = "overtimed_hours";
            overtimed_hours.Size = new Size(214, 20);
            overtimed_hours.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F);
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(92, 16);
            label4.TabIndex = 4;
            label4.Text = "Ovetime Hours";
            // 
            // days_worked
            // 
            days_worked.Location = new Point(12, 97);
            days_worked.Name = "days_worked";
            days_worked.Size = new Size(214, 20);
            days_worked.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(86, 16);
            label3.TabIndex = 2;
            label3.Text = "Days Worked";
            // 
            // employee_searchbox
            // 
            employee_searchbox.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employee_searchbox.FormattingEnabled = true;
            employee_searchbox.Location = new Point(12, 44);
            employee_searchbox.Name = "employee_searchbox";
            employee_searchbox.Size = new Size(312, 28);
            employee_searchbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(103, 16);
            label2.TabIndex = 0;
            label2.Text = "Employee Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(456, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 297);
            panel2.TabIndex = 2;
            // 
            // attendance_table
            // 
            attendance_table.BackgroundColor = SystemColors.ButtonHighlight;
            attendance_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendance_table.Location = new Point(456, 214);
            attendance_table.Name = "attendance_table";
            attendance_table.Size = new Size(684, 322);
            attendance_table.TabIndex = 0;
            attendance_table.CellContentClick += dataGridView1_CellContentClick;
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(home1);
            gradientPanel1.Controls.Add(logout1);
            gradientPanel1.Controls.Add(label8);
            gradientPanel1.Controls.Add(logo1);
            gradientPanel1.Font = new Font("Arial", 9.75F);
            gradientPanel1.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel1.Location = new Point(-3, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1191, 76);
            gradientPanel1.TabIndex = 5;
            // 
            // home1
            // 
            home1.AutoSize = true;
            home1.BackColor = Color.Transparent;
            home1.Cursor = Cursors.Hand;
            home1.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home1.ForeColor = Color.Transparent;
            home1.Location = new Point(1018, 30);
            home1.Name = "home1";
            home1.Size = new Size(66, 24);
            home1.TabIndex = 24;
            home1.Text = "Home";
            home1.TextAlign = ContentAlignment.TopCenter;
            home1.Click += home1_Click;
            // 
            // logout1
            // 
            logout1.AutoSize = true;
            logout1.BackColor = Color.Transparent;
            logout1.Cursor = Cursors.Hand;
            logout1.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout1.ForeColor = Color.Transparent;
            logout1.Location = new Point(1090, 30);
            logout1.Name = "logout1";
            logout1.Size = new Size(85, 24);
            logout1.TabIndex = 24;
            logout1.Text = "Log Out";
            logout1.TextAlign = ContentAlignment.TopCenter;
            logout1.Click += logout1_Click;
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
            // logo1
            // 
            logo1.BackColor = Color.Transparent;
            logo1.Cursor = Cursors.Hand;
            logo1.Image = Properties.Resources.icon;
            logo1.Location = new Point(0, 3);
            logo1.Name = "logo1";
            logo1.Size = new Size(76, 75);
            logo1.SizeMode = PictureBoxSizeMode.StretchImage;
            logo1.TabIndex = 22;
            logo1.TabStop = false;
            logo1.Click += logo1_Click;
            // 
            // attendance
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 651);
            Controls.Add(gradientPanel1);
            Controls.Add(attendance_table);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "attendance";
            Text = "attendance";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)overtimed_hours).EndInit();
            ((System.ComponentModel.ISupportInitialize)days_worked).EndInit();
            ((System.ComponentModel.ISupportInitialize)attendance_table).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label home;
        private Label logout;
        private Label label5;
        private PictureBox logo;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button clearBTN;
        private Button saveAttendanceBTN;
        private NumericUpDown overtimed_hours;
        private Label label4;
        private NumericUpDown days_worked;
        private Label label3;
        private ComboBox employee_searchbox;
        private DataGridView attendance_table;
        private Label home1;
        private Label logout1;
        private Label label8;
        private PictureBox logo1;
        private Label label6;
        private DateTimePicker attendance_date;
    }
}