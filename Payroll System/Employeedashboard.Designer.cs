namespace Payroll_System
{
    partial class Employeedashboard
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
            pnlside = new Panel();
            pnltop = new Panel();
            lblemployee = new Label();
            lblpayrollsystem = new Label();
            btndashboard = new Button();
            btnemployee = new Button();
            btnpayslips = new Button();
            cbreports = new ComboBox();
            cbauditing = new ComboBox();
            cballowances = new ComboBox();
            cbdeductions = new ComboBox();
            cbsettings = new ComboBox();
            cbmessages = new ComboBox();
            btnaddemployee = new Button();
            pnlside.SuspendLayout();
            pnltop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlside
            // 
            pnlside.BackColor = SystemColors.ActiveCaption;
            pnlside.Controls.Add(cbmessages);
            pnlside.Controls.Add(cbsettings);
            pnlside.Controls.Add(cbdeductions);
            pnlside.Controls.Add(cballowances);
            pnlside.Controls.Add(cbauditing);
            pnlside.Controls.Add(cbreports);
            pnlside.Controls.Add(btnpayslips);
            pnlside.Controls.Add(btnemployee);
            pnlside.Controls.Add(btndashboard);
            pnlside.Controls.Add(lblpayrollsystem);
            pnlside.Location = new Point(2, 12);
            pnlside.Name = "pnlside";
            pnlside.Size = new Size(141, 574);
            pnlside.TabIndex = 0;
            // 
            // pnltop
            // 
            pnltop.BackColor = SystemColors.ActiveBorder;
            pnltop.Controls.Add(lblemployee);
            pnltop.Location = new Point(143, 12);
            pnltop.Name = "pnltop";
            pnltop.Size = new Size(801, 67);
            pnltop.TabIndex = 1;
            // 
            // lblemployee
            // 
            lblemployee.AutoSize = true;
            lblemployee.Location = new Point(6, 26);
            lblemployee.Name = "lblemployee";
            lblemployee.Size = new Size(64, 15);
            lblemployee.TabIndex = 0;
            lblemployee.Text = "Employees";
            lblemployee.Click += lblemployee_Click;
            // 
            // lblpayrollsystem
            // 
            lblpayrollsystem.AutoSize = true;
            lblpayrollsystem.Location = new Point(24, 22);
            lblpayrollsystem.Name = "lblpayrollsystem";
            lblpayrollsystem.Size = new Size(78, 45);
            lblpayrollsystem.TabIndex = 0;
            lblpayrollsystem.Text = "Payroll\r\nManagement\r\nSystem\r\n";
            // 
            // btndashboard
            // 
            btndashboard.BackColor = SystemColors.ActiveCaption;
            btndashboard.Location = new Point(0, 125);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(141, 46);
            btndashboard.TabIndex = 1;
            btndashboard.Text = "Dashboard";
            btndashboard.UseVisualStyleBackColor = false;
            // 
            // btnemployee
            // 
            btnemployee.BackColor = SystemColors.ActiveCaption;
            btnemployee.Location = new Point(0, 177);
            btnemployee.Name = "btnemployee";
            btnemployee.Size = new Size(141, 49);
            btnemployee.TabIndex = 2;
            btnemployee.Text = "Employees";
            btnemployee.UseVisualStyleBackColor = false;
            // 
            // btnpayslips
            // 
            btnpayslips.BackColor = SystemColors.ActiveCaption;
            btnpayslips.Location = new Point(0, 232);
            btnpayslips.Name = "btnpayslips";
            btnpayslips.Size = new Size(141, 46);
            btnpayslips.TabIndex = 3;
            btnpayslips.Text = "Payslips";
            btnpayslips.UseVisualStyleBackColor = false;
            // 
            // cbreports
            // 
            cbreports.BackColor = SystemColors.ActiveCaption;
            cbreports.FormattingEnabled = true;
            cbreports.Location = new Point(1, 284);
            cbreports.Name = "cbreports";
            cbreports.Size = new Size(139, 23);
            cbreports.TabIndex = 4;
            cbreports.Text = "Reports";
            // 
            // cbauditing
            // 
            cbauditing.BackColor = SystemColors.ActiveCaption;
            cbauditing.FormattingEnabled = true;
            cbauditing.Location = new Point(1, 313);
            cbauditing.Name = "cbauditing";
            cbauditing.Size = new Size(139, 23);
            cbauditing.TabIndex = 5;
            cbauditing.Text = "Auditing";
            cbauditing.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cballowances
            // 
            cballowances.BackColor = SystemColors.ActiveCaption;
            cballowances.FormattingEnabled = true;
            cballowances.Location = new Point(1, 342);
            cballowances.Name = "cballowances";
            cballowances.Size = new Size(139, 23);
            cballowances.TabIndex = 6;
            cballowances.Text = "Allowances";
            // 
            // cbdeductions
            // 
            cbdeductions.BackColor = SystemColors.ActiveCaption;
            cbdeductions.FormattingEnabled = true;
            cbdeductions.Location = new Point(1, 371);
            cbdeductions.Name = "cbdeductions";
            cbdeductions.Size = new Size(139, 23);
            cbdeductions.TabIndex = 7;
            cbdeductions.Text = "Deductions";
            // 
            // cbsettings
            // 
            cbsettings.BackColor = SystemColors.ActiveCaption;
            cbsettings.FormattingEnabled = true;
            cbsettings.Location = new Point(1, 400);
            cbsettings.Name = "cbsettings";
            cbsettings.Size = new Size(139, 23);
            cbsettings.TabIndex = 8;
            cbsettings.Text = "Settings";
            // 
            // cbmessages
            // 
            cbmessages.BackColor = SystemColors.ActiveCaption;
            cbmessages.FormattingEnabled = true;
            cbmessages.Location = new Point(1, 429);
            cbmessages.Name = "cbmessages";
            cbmessages.Size = new Size(139, 23);
            cbmessages.TabIndex = 9;
            cbmessages.Text = "Messages";
            // 
            // btnaddemployee
            // 
            btnaddemployee.BackColor = SystemColors.MenuHighlight;
            btnaddemployee.ForeColor = SystemColors.HighlightText;
            btnaddemployee.Location = new Point(155, 93);
            btnaddemployee.Name = "btnaddemployee";
            btnaddemployee.Size = new Size(131, 43);
            btnaddemployee.TabIndex = 2;
            btnaddemployee.Text = "+ Add New Employee";
            btnaddemployee.UseVisualStyleBackColor = false;
            // 
            // Employeedashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 598);
            Controls.Add(btnaddemployee);
            Controls.Add(pnltop);
            Controls.Add(pnlside);
            Name = "Employeedashboard";
            Text = "Employeedashboard";
            pnlside.ResumeLayout(false);
            pnlside.PerformLayout();
            pnltop.ResumeLayout(false);
            pnltop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlside;
        private Panel pnltop;
        private Label lblemployee;
        private Label lblpayrollsystem;
        private ComboBox cbreports;
        private Button btnpayslips;
        private Button btnemployee;
        private Button btndashboard;
        private ComboBox cbauditing;
        private ComboBox cbmessages;
        private ComboBox cbsettings;
        private ComboBox cbdeductions;
        private ComboBox cballowances;
        private Button btnaddemployee;
    }
}