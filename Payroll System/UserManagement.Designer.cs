namespace Payroll_System
{
    partial class UserManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            gradientPanel1 = new GradientPanel();
            home_btn = new Label();
            logout_btn = new Label();
            label6 = new Label();
            logo_btn = new PictureBox();
            userAccounts = new DataGridView();
            employee_entries = new Label();
            label1 = new Label();
            searchbox = new ComboBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            add_admin = new Button();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userAccounts).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BackColor = Color.FromArgb(33, 145, 245);
            gradientPanel1.Controls.Add(home_btn);
            gradientPanel1.Controls.Add(logout_btn);
            gradientPanel1.Controls.Add(label6);
            gradientPanel1.Controls.Add(logo_btn);
            gradientPanel1.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel1.Location = new Point(-3, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1191, 76);
            gradientPanel1.TabIndex = 33;
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
            // userAccounts
            // 
            userAccounts.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            userAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            userAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            userAccounts.DefaultCellStyle = dataGridViewCellStyle2;
            userAccounts.Location = new Point(58, 285);
            userAccounts.Name = "userAccounts";
            userAccounts.Size = new Size(1078, 259);
            userAccounts.TabIndex = 40;
            // 
            // employee_entries
            // 
            employee_entries.AutoSize = true;
            employee_entries.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employee_entries.Location = new Point(58, 254);
            employee_entries.Name = "employee_entries";
            employee_entries.Size = new Size(101, 16);
            employee_entries.TabIndex = 39;
            employee_entries.Text = "Showing Entries";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(920, 249);
            label1.Name = "label1";
            label1.Size = new Size(56, 16);
            label1.TabIndex = 38;
            label1.Text = "Search:";
            // 
            // searchbox
            // 
            searchbox.FormattingEnabled = true;
            searchbox.Location = new Point(976, 247);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(160, 23);
            searchbox.TabIndex = 37;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Transparent;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.FromArgb(133, 133, 133);
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(58, 147);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(1078, 15);
            linkLabel1.TabIndex = 36;
            linkLabel1.TabStop = true;
            linkLabel1.Text = resources.GetString("linkLabel1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 107);
            label2.Name = "label2";
            label2.Size = new Size(297, 40);
            label2.TabIndex = 35;
            label2.Text = "User Management";
            // 
            // add_admin
            // 
            add_admin.BackColor = SystemColors.MenuHighlight;
            add_admin.Cursor = Cursors.Hand;
            add_admin.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_admin.ForeColor = SystemColors.HighlightText;
            add_admin.Location = new Point(58, 172);
            add_admin.Name = "add_admin";
            add_admin.Size = new Size(131, 43);
            add_admin.TabIndex = 34;
            add_admin.Text = "+ Add New Admin";
            add_admin.UseVisualStyleBackColor = false;
            add_admin.Click += add_admin_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 651);
            Controls.Add(userAccounts);
            Controls.Add(employee_entries);
            Controls.Add(label1);
            Controls.Add(searchbox);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(add_admin);
            Controls.Add(gradientPanel1);
            Name = "UserManagement";
            Text = "UserManagement";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)userAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label home_btn;
        private Label logout_btn;
        private Label label6;
        private PictureBox logo_btn;
        private DataGridView userAccounts;
        private Label employee_entries;
        private Label label1;
        private ComboBox searchbox;
        private LinkLabel linkLabel1;
        private Label label2;
        private Button add_admin;
    }
}