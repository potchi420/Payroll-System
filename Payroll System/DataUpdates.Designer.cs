namespace Payroll_System
{
    partial class DataUpdates
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
            gradientPanel1 = new GradientPanel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pnlside = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnemployeeside = new Button();
            btnhome = new Button();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlside.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(label5);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel1.Location = new Point(-8, 6);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1431, 76);
            gradientPanel1.TabIndex = 30;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
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
            pnlside.Location = new Point(-2, 80);
            pnlside.Name = "pnlside";
            pnlside.Size = new Size(176, 575);
            pnlside.TabIndex = 29;
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
            btnemployeeside.BackColor = SystemColors.Control;
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
            btnhome.BackColor = Color.FromArgb(33, 145, 245);
            btnhome.Cursor = Cursors.Hand;
            btnhome.ForeColor = SystemColors.InfoText;
            btnhome.Location = new Point(0, 3);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(176, 64);
            btnhome.TabIndex = 0;
            btnhome.Text = "Home";
            btnhome.UseVisualStyleBackColor = false;
            // 
            // DataUpdates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 651);
            Controls.Add(gradientPanel1);
            Controls.Add(pnlside);
            Name = "DataUpdates";
            Text = "DataUpdates";
            Load += DataUpdates_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlside.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel pnlside;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnemployeeside;
        private Button btnhome;
    }
}