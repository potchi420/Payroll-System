namespace Payroll_System
{
    partial class AssignBenefits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignBenefits));
            gradientPanel1 = new GradientPanel();
            home = new Label();
            logout = new Label();
            label5 = new Label();
            logo = new PictureBox();
            benefits_administration_label = new Label();
            linkLabel1 = new LinkLabel();
            dataGridView1 = new DataGridView();
            curved_panel = new GradientPanel();
            search_lb = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button5 = new Button();
            button1 = new Button();
            button3 = new Button();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            curved_panel.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(home);
            gradientPanel1.Controls.Add(logout);
            gradientPanel1.Controls.Add(label5);
            gradientPanel1.Controls.Add(logo);
            gradientPanel1.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel1.Location = new Point(-3, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1191, 76);
            gradientPanel1.TabIndex = 28;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            logo.Click += logo_Click;
            // 
            // benefits_administration_label
            // 
            benefits_administration_label.AutoSize = true;
            benefits_administration_label.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            benefits_administration_label.Location = new Point(60, 105);
            benefits_administration_label.Name = "benefits_administration_label";
            benefits_administration_label.Size = new Size(194, 29);
            benefits_administration_label.TabIndex = 31;
            benefits_administration_label.Text = "Assign Benefits";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Transparent;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.FromArgb(133, 133, 133);
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(63, 134);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(1078, 15);
            linkLabel1.TabIndex = 38;
            linkLabel1.TabStop = true;
            linkLabel1.Text = resources.GetString("linkLabel1.Text");
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(596, 259);
            dataGridView1.TabIndex = 0;
            // 
            // curved_panel
            // 
            curved_panel.BorderStyle = BorderStyle.FixedSingle;
            curved_panel.Controls.Add(button3);
            curved_panel.Controls.Add(button1);
            curved_panel.Controls.Add(button2);
            curved_panel.Controls.Add(textBox1);
            curved_panel.Controls.Add(search_lb);
            curved_panel.Controls.Add(dataGridView1);
            curved_panel.gradientBottom = Color.Empty;
            curved_panel.gradientTop = Color.Empty;
            curved_panel.Location = new Point(154, 191);
            curved_panel.Name = "curved_panel";
            curved_panel.Size = new Size(886, 351);
            curved_panel.TabIndex = 44;
            // 
            // search_lb
            // 
            search_lb.AutoSize = true;
            search_lb.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_lb.Location = new Point(36, 27);
            search_lb.Name = "search_lb";
            search_lb.Size = new Size(123, 16);
            search_lb.TabIndex = 29;
            search_lb.Text = "Employee Search:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(165, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 21);
            textBox1.TabIndex = 30;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 11.25F);
            button2.Location = new Point(703, 66);
            button2.Name = "button2";
            button2.Size = new Size(130, 43);
            button2.TabIndex = 31;
            button2.Text = "Add Benefit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Arial", 11.25F);
            button5.Location = new Point(858, 558);
            button5.Name = "button5";
            button5.Size = new Size(130, 43);
            button5.TabIndex = 35;
            button5.Text = "Save";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 11.25F);
            button1.Location = new Point(703, 128);
            button1.Name = "button1";
            button1.Size = new Size(130, 43);
            button1.TabIndex = 32;
            button1.Text = "Edit Benefit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 11.25F);
            button3.Location = new Point(703, 189);
            button3.Name = "button3";
            button3.Size = new Size(130, 43);
            button3.TabIndex = 33;
            button3.Text = "Remove Benefit";
            button3.UseVisualStyleBackColor = true;
            // 
            // AssignBenefits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 651);
            Controls.Add(button5);
            Controls.Add(curved_panel);
            Controls.Add(linkLabel1);
            Controls.Add(benefits_administration_label);
            Controls.Add(gradientPanel1);
            Name = "AssignBenefits";
            Text = "AssignBenefits";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            curved_panel.ResumeLayout(false);
            curved_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label home;
        private Label logout;
        private Label label5;
        private PictureBox logo;
        private Label benefits_administration_label;
        private LinkLabel linkLabel1;
        private DataGridView dataGridView1;
        private GradientPanel curved_panel;
        private Button button2;
        private TextBox textBox1;
        private Label search_lb;
        private Button button5;
        private Button button3;
        private Button button1;
    }
}