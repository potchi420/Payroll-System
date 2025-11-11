namespace Payroll_System
{
    partial class AddEmployee
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            gradientPanel1 = new GradientPanel();
            home = new Label();
            logout = new Label();
            label8 = new Label();
            logo = new PictureBox();
            back_btn = new Button();
            save_btn = new Button();
            curved_panel = new GradientPanel();
            label6 = new Label();
            Salary = new TextBox();
            label5 = new Label();
            contact_no = new TextBox();
            department = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            Address = new TextBox();
            label2 = new Label();
            last_name = new TextBox();
            label1 = new Label();
            first_name = new TextBox();
            linkLabel1 = new LinkLabel();
            benefits_administration_label = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label7 = new Label();
            email = new TextBox();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            curved_panel.SuspendLayout();
            SuspendLayout();
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
            gradientPanel1.TabIndex = 31;
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
            // back_btn
            // 
            back_btn.Font = new Font("Arial", 11.25F);
            back_btn.Location = new Point(734, 569);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(130, 43);
            back_btn.TabIndex = 50;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Font = new Font("Arial", 11.25F);
            save_btn.Location = new Point(880, 569);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(130, 43);
            save_btn.TabIndex = 47;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // curved_panel
            // 
            curved_panel.BorderStyle = BorderStyle.FixedSingle;
            curved_panel.Controls.Add(label7);
            curved_panel.Controls.Add(email);
            curved_panel.Controls.Add(label6);
            curved_panel.Controls.Add(Salary);
            curved_panel.Controls.Add(label5);
            curved_panel.Controls.Add(contact_no);
            curved_panel.Controls.Add(department);
            curved_panel.Controls.Add(label4);
            curved_panel.Controls.Add(label3);
            curved_panel.Controls.Add(Address);
            curved_panel.Controls.Add(label2);
            curved_panel.Controls.Add(last_name);
            curved_panel.Controls.Add(label1);
            curved_panel.Controls.Add(first_name);
            curved_panel.gradientBottom = Color.Empty;
            curved_panel.gradientTop = Color.Empty;
            curved_panel.Location = new Point(177, 166);
            curved_panel.Name = "curved_panel";
            curved_panel.Size = new Size(833, 397);
            curved_panel.TabIndex = 49;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F);
            label6.Location = new Point(58, 214);
            label6.Name = "label6";
            label6.Size = new Size(70, 24);
            label6.TabIndex = 58;
            label6.Text = "Salary";
            // 
            // Salary
            // 
            Salary.Anchor = AnchorStyles.None;
            Salary.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Salary.Location = new Point(63, 250);
            Salary.Multiline = true;
            Salary.Name = "Salary";
            Salary.Size = new Size(326, 29);
            Salary.TabIndex = 57;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F);
            label5.Location = new Point(446, 125);
            label5.Name = "label5";
            label5.Size = new Size(118, 24);
            label5.TabIndex = 56;
            label5.Text = "Contact no.";
            // 
            // contact_no
            // 
            contact_no.Anchor = AnchorStyles.None;
            contact_no.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contact_no.Location = new Point(451, 161);
            contact_no.Multiline = true;
            contact_no.Name = "contact_no";
            contact_no.Size = new Size(326, 29);
            contact_no.TabIndex = 55;
            // 
            // department
            // 
            department.Anchor = AnchorStyles.None;
            department.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            department.FormattingEnabled = true;
            department.Location = new Point(63, 161);
            department.Name = "department";
            department.Size = new Size(326, 26);
            department.TabIndex = 54;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F);
            label4.Location = new Point(58, 125);
            label4.Name = "label4";
            label4.Size = new Size(118, 24);
            label4.TabIndex = 53;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F);
            label3.Location = new Point(63, 303);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 51;
            label3.Text = "Address";
            // 
            // Address
            // 
            Address.Anchor = AnchorStyles.None;
            Address.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Address.Location = new Point(63, 339);
            Address.Multiline = true;
            Address.Name = "Address";
            Address.Size = new Size(714, 37);
            Address.TabIndex = 50;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F);
            label2.Location = new Point(447, 21);
            label2.Name = "label2";
            label2.Size = new Size(111, 24);
            label2.TabIndex = 49;
            label2.Text = "Last Name";
            // 
            // last_name
            // 
            last_name.Anchor = AnchorStyles.None;
            last_name.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            last_name.Location = new Point(447, 57);
            last_name.Multiline = true;
            last_name.Name = "last_name";
            last_name.Size = new Size(326, 29);
            last_name.TabIndex = 48;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F);
            label1.Location = new Point(58, 21);
            label1.Name = "label1";
            label1.Size = new Size(112, 24);
            label1.TabIndex = 47;
            label1.Text = "First Name";
            // 
            // first_name
            // 
            first_name.Anchor = AnchorStyles.None;
            first_name.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            first_name.Location = new Point(63, 57);
            first_name.Multiline = true;
            first_name.Name = "first_name";
            first_name.Size = new Size(326, 29);
            first_name.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Transparent;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.FromArgb(133, 133, 133);
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(58, 125);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(1078, 15);
            linkLabel1.TabIndex = 48;
            linkLabel1.TabStop = true;
            linkLabel1.Text = resources.GetString("linkLabel1.Text");
            // 
            // benefits_administration_label
            // 
            benefits_administration_label.AutoSize = true;
            benefits_administration_label.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            benefits_administration_label.Location = new Point(55, 96);
            benefits_administration_label.Name = "benefits_administration_label";
            benefits_administration_label.Size = new Size(180, 29);
            benefits_administration_label.TabIndex = 46;
            benefits_administration_label.Text = "Add Employee";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15.75F);
            label7.Location = new Point(451, 214);
            label7.Name = "label7";
            label7.Size = new Size(61, 24);
            label7.TabIndex = 60;
            label7.Text = "Email";
            // 
            // email
            // 
            email.Anchor = AnchorStyles.None;
            email.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(451, 250);
            email.Multiline = true;
            email.Name = "email";
            email.Size = new Size(326, 29);
            email.TabIndex = 59;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 651);
            Controls.Add(back_btn);
            Controls.Add(save_btn);
            Controls.Add(curved_panel);
            Controls.Add(linkLabel1);
            Controls.Add(benefits_administration_label);
            Controls.Add(gradientPanel1);
            Cursor = Cursors.Hand;
            Name = "AddEmployee";
            Text = "AddEmployee";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            curved_panel.ResumeLayout(false);
            curved_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label home;
        private Label logout;
        private Label label8;
        private PictureBox logo;
        private Button back_btn;
        private Button save_btn;
        private GradientPanel curved_panel;
        private LinkLabel linkLabel1;
        private Label benefits_administration_label;
        private TextBox first_name;
        private Label label2;
        private TextBox last_name;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private Label label5;
        private TextBox contact_no;
        private ComboBox department;
        private Label label4;
        private Label label3;
        private TextBox Address;
        private Label label6;
        private TextBox Salary;
        private Label label7;
        private TextBox email;
    }
}