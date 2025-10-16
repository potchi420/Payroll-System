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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employeedashboard));
            btnaddemployee = new Button();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            dataGridViewEmployees = new DataGridView();
            gradientPanel1 = new GradientPanel();
            home = new Label();
            logout = new Label();
            label8 = new Label();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // btnaddemployee
            // 
            btnaddemployee.BackColor = SystemColors.MenuHighlight;
            btnaddemployee.Cursor = Cursors.Hand;
            btnaddemployee.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnaddemployee.ForeColor = SystemColors.HighlightText;
            btnaddemployee.Location = new Point(57, 171);
            btnaddemployee.Name = "btnaddemployee";
            btnaddemployee.Size = new Size(131, 43);
            btnaddemployee.TabIndex = 2;
            btnaddemployee.Text = "+ Add New Employee";
            btnaddemployee.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 106);
            label2.Name = "label2";
            label2.Size = new Size(184, 40);
            label2.TabIndex = 24;
            label2.Text = "Employees";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Transparent;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.FromArgb(133, 133, 133);
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(57, 146);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(1078, 15);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = resources.GetString("linkLabel1.Text");
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1026, 234);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(109, 23);
            comboBox1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(964, 236);
            label1.Name = "label1";
            label1.Size = new Size(56, 16);
            label1.TabIndex = 27;
            label1.Text = "Search:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 234);
            label3.Name = "label3";
            label3.Size = new Size(101, 16);
            label3.TabIndex = 28;
            label3.Text = "Showing Entries";
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.BackgroundColor = SystemColors.Control;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(57, 284);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.Size = new Size(1078, 259);
            dataGridViewEmployees.TabIndex = 29;
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
            gradientPanel1.TabIndex = 30;
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
            home.Click += home_Click;
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
            logo.Click += logo_Click;
            // 
            // Employeedashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 651);
            Controls.Add(gradientPanel1);
            Controls.Add(dataGridViewEmployees);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(btnaddemployee);
            Name = "Employeedashboard";
            Text = "Employeedashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnaddemployee;
        private Label label2;
        private LinkLabel linkLabel1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label3;
        private DataGridView dataGridViewEmployees;
        private GradientPanel gradientPanel1;
        private Label home;
        private Label logout;
        private Label label8;
        private PictureBox logo;
    }
}