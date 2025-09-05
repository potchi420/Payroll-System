namespace Payroll_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            gradientPanel1 = new GradientPanel();
            PCU = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            gradientPanel2 = new GradientPanel();
            textBox1 = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.ForeColor = Color.DarkBlue;
            panel1.Location = new Point(186, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 374);
            panel1.TabIndex = 1;
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Controls.Add(PCU);
            gradientPanel1.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel1.Location = new Point(186, 118);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(447, 374);
            gradientPanel1.TabIndex = 0;
            // 
            // PCU
            // 
            PCU.AutoSize = true;
            PCU.BackColor = Color.Transparent;
            PCU.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PCU.ForeColor = SystemColors.ButtonFace;
            PCU.Location = new Point(128, 103);
            PCU.Name = "PCU";
            PCU.Size = new Size(158, 37);
            PCU.TabIndex = 0;
            PCU.Text = "Welcome";
            PCU.Click += PCU_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(170, 171);
            label1.Name = "label1";
            label1.Size = new Size(68, 24);
            label1.TabIndex = 1;
            label1.Text = "to the";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.image_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(398, -25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 451);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(87, 224);
            label2.Name = "label2";
            label2.Size = new Size(246, 37);
            label2.TabIndex = 3;
            label2.Text = "Payroll System";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(527, 74);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 2;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // gradientPanel2
            // 
            gradientPanel2.gradientBottom = Color.Empty;
            gradientPanel2.gradientTop = Color.Empty;
            gradientPanel2.Location = new Point(829, 83);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(8, 8);
            gradientPanel2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(527, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(364, 178);
            label4.Name = "label4";
            label4.Size = new Size(80, 18);
            label4.TabIndex = 4;
            label4.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1190, 641);
            Controls.Add(gradientPanel2);
            Controls.Add(gradientPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private GradientPanel gradientPanel1;
        private Label PCU;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private GradientPanel gradientPanel2;
        private Label label4;
    }
}
