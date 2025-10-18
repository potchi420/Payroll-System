namespace Payroll_System
{
    partial class BenefitCatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BenefitCatalog));
            home = new Label();
            logout = new Label();
            label8 = new Label();
            logo = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            linkLabel1 = new LinkLabel();
            benefits_administration_label = new Label();
            dataGridViewEmployees = new DataGridView();
            back_btn = new Button();
            save_btn = new Button();
            label1 = new Label();
            gradientPanel1 = new GradientPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            home.Click += home_Click;
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
            logout.Click += logout_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // button1
            // 
            button1.Font = new Font("Arial", 11.25F);
            button1.Location = new Point(793, 220);
            button1.Name = "button1";
            button1.Size = new Size(120, 42);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 11.25F);
            button2.Location = new Point(793, 286);
            button2.Name = "button2";
            button2.Size = new Size(120, 42);
            button2.TabIndex = 2;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 11.25F);
            button3.Location = new Point(793, 353);
            button3.Name = "button3";
            button3.Size = new Size(120, 42);
            button3.TabIndex = 3;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
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
            linkLabel1.TabIndex = 40;
            linkLabel1.TabStop = true;
            linkLabel1.Text = resources.GetString("linkLabel1.Text");
            // 
            // benefits_administration_label
            // 
            benefits_administration_label.AutoSize = true;
            benefits_administration_label.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            benefits_administration_label.Location = new Point(60, 105);
            benefits_administration_label.Name = "benefits_administration_label";
            benefits_administration_label.Size = new Size(202, 29);
            benefits_administration_label.TabIndex = 39;
            benefits_administration_label.Text = "Benefits Catalog";
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.BackgroundColor = SystemColors.Control;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(79, 220);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.Size = new Size(679, 259);
            dataGridViewEmployees.TabIndex = 41;
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Arial", 11.25F);
            back_btn.Location = new Point(79, 508);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(120, 42);
            back_btn.TabIndex = 42;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            save_btn.Font = new Font("Arial", 11.25F);
            save_btn.Location = new Point(217, 508);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(120, 42);
            save_btn.TabIndex = 43;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 180);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 44;
            label1.Text = "Benefits";
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(label3);
            gradientPanel1.Controls.Add(label4);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel1.Location = new Point(-3, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1191, 76);
            gradientPanel1.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(1018, 30);
            label2.Name = "label2";
            label2.Size = new Size(66, 24);
            label2.TabIndex = 24;
            label2.Text = "Home";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(1090, 30);
            label3.Name = "label3";
            label3.Size = new Size(85, 24);
            label3.TabIndex = 24;
            label3.Text = "Log Out";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(82, 30);
            label4.Name = "label4";
            label4.Size = new Size(258, 24);
            label4.TabIndex = 23;
            label4.Text = "PCU PAYROLL SYSTEM";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // BenefitCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 651);
            Controls.Add(gradientPanel1);
            Controls.Add(label1);
            Controls.Add(save_btn);
            Controls.Add(back_btn);
            Controls.Add(dataGridViewEmployees);
            Controls.Add(linkLabel1);
            Controls.Add(benefits_administration_label);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "BenefitCatalog";
            Text = "BenefitCatalog";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label home;
        private Label logout;
        private Label label8;
        private PictureBox logo;
        private Button button1;
        private Button button2;
        private Button button3;
        private LinkLabel linkLabel1;
        private Label benefits_administration_label;
        private DataGridView dataGridViewEmployees;
        private Button back_btn;
        private Button save_btn;
        private Label label1;
        private GradientPanel gradientPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}