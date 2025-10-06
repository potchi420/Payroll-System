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
            gradientPanel1 = new GradientPanel();
            label8 = new Label();
            pictureBox5 = new PictureBox();
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnemployeeside = new Button();
            btnhome = new Button();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            dataGridViewEmployees = new DataGridView();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // btnaddemployee
            // 
            btnaddemployee.BackColor = SystemColors.MenuHighlight;
            btnaddemployee.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnaddemployee.ForeColor = SystemColors.HighlightText;
            btnaddemployee.Location = new Point(211, 163);
            btnaddemployee.Name = "btnaddemployee";
            btnaddemployee.Size = new Size(131, 43);
            btnaddemployee.TabIndex = 2;
            btnaddemployee.Text = "+ Add New Employee";
            btnaddemployee.UseVisualStyleBackColor = false;
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
            gradientPanel1.TabIndex = 22;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnemployeeside);
            panel1.Controls.Add(btnhome);
            panel1.Location = new Point(2, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 575);
            panel1.TabIndex = 21;
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
            btnhome.Click += btnhome_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(202, 102);
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
            linkLabel1.Location = new Point(211, 142);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(1183, 15);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = resources.GetString("linkLabel1.Text");
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1285, 228);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(109, 23);
            comboBox1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1223, 230);
            label1.Name = "label1";
            label1.Size = new Size(56, 16);
            label1.TabIndex = 27;
            label1.Text = "Search:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(211, 230);
            label3.Name = "label3";
            label3.Size = new Size(101, 16);
            label3.TabIndex = 28;
            label3.Text = "Showing Entries";
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.BackgroundColor = SystemColors.Control;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(211, 280);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.Size = new Size(1183, 212);
            dataGridViewEmployees.TabIndex = 29;
            // 
            // Employeedashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 651);
            Controls.Add(dataGridViewEmployees);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(gradientPanel1);
            Controls.Add(panel1);
            Controls.Add(btnaddemployee);
            Name = "Employeedashboard";
            Text = "Employeedashboard";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnaddemployee;
        private GradientPanel gradientPanel1;
        private Label label8;
        private PictureBox pictureBox5;
        private Panel panel1;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnemployeeside;
        private Button btnhome;
        private Label label2;
        private LinkLabel linkLabel1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label3;
        private DataGridView dataGridViewEmployees;
    }
}