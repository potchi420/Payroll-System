namespace Payroll_System
{
    partial class EditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployee));
            contextMenuStrip1 = new ContextMenuStrip(components);
            linkLabel1 = new LinkLabel();
            benefits_administration_label = new Label();
            back_btn = new Button();
            logout = new Label();
            label8 = new Label();
            logo = new PictureBox();
            home = new Label();
            save_btn = new Button();
            gradientPanel1 = new GradientPanel();
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
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            gradientPanel1.SuspendLayout();
            curved_panel.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Transparent;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.FromArgb(133, 133, 133);
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(66, 167);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(1437, 20);
            linkLabel1.TabIndex = 54;
            linkLabel1.TabStop = true;
            linkLabel1.Text = resources.GetString("linkLabel1.Text");
            // 
            // benefits_administration_label
            // 
            benefits_administration_label.AutoSize = true;
            benefits_administration_label.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            benefits_administration_label.Location = new Point(63, 128);
            benefits_administration_label.Name = "benefits_administration_label";
            benefits_administration_label.Size = new Size(219, 35);
            benefits_administration_label.TabIndex = 52;
            benefits_administration_label.Text = "Edit Employee";
            // 
            // back_btn
            // 
            back_btn.Cursor = Cursors.Hand;
            back_btn.Font = new Font("Arial", 11.25F);
            back_btn.Location = new Point(839, 757);
            back_btn.Margin = new Padding(3, 4, 3, 4);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(149, 57);
            back_btn.TabIndex = 56;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // logout
            // 
            logout.AutoSize = true;
            logout.BackColor = Color.Transparent;
            logout.Cursor = Cursors.Hand;
            logout.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.Transparent;
            logout.Location = new Point(1246, 41);
            logout.Name = "logout";
            logout.Size = new Size(111, 31);
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
            label8.Location = new Point(94, 41);
            label8.Name = "label8";
            label8.Size = new Size(332, 31);
            label8.TabIndex = 23;
            label8.Text = "PCU PAYROLL SYSTEM";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Cursor = Cursors.Hand;
            logo.Image = Properties.Resources.icon;
            logo.Location = new Point(0, 5);
            logo.Margin = new Padding(3, 4, 3, 4);
            logo.Name = "logo";
            logo.Size = new Size(87, 100);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 22;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // home
            // 
            home.AutoSize = true;
            home.BackColor = Color.Transparent;
            home.Cursor = Cursors.Hand;
            home.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home.ForeColor = Color.Transparent;
            home.Location = new Point(1163, 41);
            home.Name = "home";
            home.Size = new Size(86, 31);
            home.TabIndex = 24;
            home.Text = "Home";
            home.TextAlign = ContentAlignment.TopCenter;
            home.Click += home_Click;
            // 
            // save_btn
            // 
            save_btn.Cursor = Cursors.Hand;
            save_btn.Font = new Font("Arial", 11.25F);
            save_btn.Location = new Point(1006, 757);
            save_btn.Margin = new Padding(3, 4, 3, 4);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(149, 57);
            save_btn.TabIndex = 53;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
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
            gradientPanel1.Margin = new Padding(3, 4, 3, 4);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1361, 101);
            gradientPanel1.TabIndex = 51;
            // 
            // curved_panel
            // 
            curved_panel.BorderStyle = BorderStyle.FixedSingle;
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
            curved_panel.Location = new Point(202, 208);
            curved_panel.Margin = new Padding(3, 4, 3, 4);
            curved_panel.Name = "curved_panel";
            curved_panel.Size = new Size(952, 541);
            curved_panel.TabIndex = 57;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F);
            label6.Location = new Point(63, 327);
            label6.Name = "label6";
            label6.Size = new Size(91, 32);
            label6.TabIndex = 70;
            label6.Text = "Salary";
            // 
            // Salary
            // 
            Salary.Anchor = AnchorStyles.None;
            Salary.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Salary.Location = new Point(69, 375);
            Salary.Margin = new Padding(3, 4, 3, 4);
            Salary.Multiline = true;
            Salary.Name = "Salary";
            Salary.Size = new Size(372, 37);
            Salary.TabIndex = 69;
            Salary.KeyPress += Salary_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F);
            label5.Location = new Point(506, 208);
            label5.Name = "label5";
            label5.Size = new Size(155, 32);
            label5.TabIndex = 68;
            label5.Text = "Contact no.";
            // 
            // contact_no
            // 
            contact_no.Anchor = AnchorStyles.None;
            contact_no.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contact_no.Location = new Point(512, 256);
            contact_no.Margin = new Padding(3, 4, 3, 4);
            contact_no.Multiline = true;
            contact_no.Name = "contact_no";
            contact_no.Size = new Size(372, 37);
            contact_no.TabIndex = 67;
            contact_no.KeyPress += contact_no_TextChanged;
            // 
            // department
            // 
            department.Anchor = AnchorStyles.None;
            department.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            department.FormattingEnabled = true;
            department.Location = new Point(69, 256);
            department.Margin = new Padding(3, 4, 3, 4);
            department.Name = "department";
            department.Size = new Size(372, 31);
            department.TabIndex = 66;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F);
            label4.Location = new Point(63, 208);
            label4.Name = "label4";
            label4.Size = new Size(156, 32);
            label4.TabIndex = 65;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F);
            label3.Location = new Point(507, 327);
            label3.Name = "label3";
            label3.Size = new Size(114, 32);
            label3.TabIndex = 64;
            label3.Text = "Address";
            // 
            // Address
            // 
            Address.Anchor = AnchorStyles.None;
            Address.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Address.Location = new Point(512, 373);
            Address.Margin = new Padding(3, 4, 3, 4);
            Address.Multiline = true;
            Address.Name = "Address";
            Address.Size = new Size(373, 95);
            Address.TabIndex = 63;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F);
            label2.Location = new Point(507, 69);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 62;
            label2.Text = "Last Name";
            // 
            // last_name
            // 
            last_name.Anchor = AnchorStyles.None;
            last_name.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            last_name.Location = new Point(507, 117);
            last_name.Margin = new Padding(3, 4, 3, 4);
            last_name.Multiline = true;
            last_name.Name = "last_name";
            last_name.Size = new Size(372, 37);
            last_name.TabIndex = 61;
            last_name.KeyPress += last_name_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F);
            label1.Location = new Point(63, 69);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 60;
            label1.Text = "First Name";
            // 
            // first_name
            // 
            first_name.Anchor = AnchorStyles.None;
            first_name.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            first_name.Location = new Point(69, 117);
            first_name.Margin = new Padding(3, 4, 3, 4);
            first_name.Multiline = true;
            first_name.Name = "first_name";
            first_name.Size = new Size(372, 37);
            first_name.TabIndex = 59;
            first_name.KeyPress += first_name_TextChanged;
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 868);
            Controls.Add(curved_panel);
            Controls.Add(linkLabel1);
            Controls.Add(benefits_administration_label);
            Controls.Add(back_btn);
            Controls.Add(save_btn);
            Controls.Add(gradientPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditEmployee";
            Text = "EditEmployee";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            curved_panel.ResumeLayout(false);
            curved_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private LinkLabel linkLabel1;
        private Label benefits_administration_label;
        private Button back_btn;
        private Label logout;
        private Label label8;
        private PictureBox logo;
        private Label home;
        private Button save_btn;
        private GradientPanel gradientPanel1;
        private GradientPanel curved_panel;
        private Label label6;
        private TextBox Salary;
        private Label label5;
        private TextBox contact_no;
        private ComboBox department;
        private Label label4;
        private Label label3;
        private TextBox Address;
        private Label label2;
        private TextBox last_name;
        private Label label1;
        private TextBox first_name;
    }
}