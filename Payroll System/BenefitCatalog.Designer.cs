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
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            linkLabel1 = new LinkLabel();
            benefits_administration_label = new Label();
            dataGridViewEmployees = new DataGridView();
            benefit_id = new DataGridViewTextBoxColumn();
            benefit_type = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            default_amount = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
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
            // btn_add
            // 
            btn_add.Font = new Font("Arial", 11.25F);
            btn_add.Location = new Point(906, 293);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(137, 56);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Font = new Font("Arial", 11.25F);
            btn_edit.Location = new Point(906, 381);
            btn_edit.Margin = new Padding(3, 4, 3, 4);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(137, 56);
            btn_edit.TabIndex = 2;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Arial", 11.25F);
            btn_delete.Location = new Point(906, 471);
            btn_delete.Margin = new Padding(3, 4, 3, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(137, 56);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Transparent;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.FromArgb(133, 133, 133);
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(72, 179);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(1437, 20);
            linkLabel1.TabIndex = 40;
            linkLabel1.TabStop = true;
            linkLabel1.Text = resources.GetString("linkLabel1.Text");
            // 
            // benefits_administration_label
            // 
            benefits_administration_label.AutoSize = true;
            benefits_administration_label.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            benefits_administration_label.Location = new Point(69, 140);
            benefits_administration_label.Name = "benefits_administration_label";
            benefits_administration_label.Size = new Size(251, 35);
            benefits_administration_label.TabIndex = 39;
            benefits_administration_label.Text = "Benefits Catalog";
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.BackgroundColor = SystemColors.Control;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Columns.AddRange(new DataGridViewColumn[] { benefit_id, benefit_type, description, default_amount });
            dataGridViewEmployees.Location = new Point(90, 293);
            dataGridViewEmployees.Margin = new Padding(3, 4, 3, 4);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowHeadersWidth = 51;
            dataGridViewEmployees.Size = new Size(776, 345);
            dataGridViewEmployees.TabIndex = 41;
            // 
            // benefit_id
            // 
            benefit_id.HeaderText = "Number";
            benefit_id.MinimumWidth = 6;
            benefit_id.Name = "benefit_id";
            benefit_id.Visible = false;
            benefit_id.Width = 125;
            // 
            // benefit_type
            // 
            benefit_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            benefit_type.HeaderText = "Name";
            benefit_type.MinimumWidth = 6;
            benefit_type.Name = "benefit_type";
            // 
            // description
            // 
            description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            description.HeaderText = "Description";
            description.MinimumWidth = 6;
            description.Name = "description";
            // 
            // default_amount
            // 
            default_amount.HeaderText = "Amount";
            default_amount.MinimumWidth = 6;
            default_amount.Name = "default_amount";
            default_amount.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 240);
            label1.Name = "label1";
            label1.Size = new Size(99, 27);
            label1.TabIndex = 44;
            label1.Text = "Benefits";
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 868);
            Controls.Add(label1);
            Controls.Add(dataGridViewEmployees);
            Controls.Add(linkLabel1);
            Controls.Add(benefits_administration_label);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BenefitCatalog";
            Text = "BenefitCatalog";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label home;
        private Label logout;
        private Label label8;
        private PictureBox logo;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
        private LinkLabel linkLabel1;
        private Label benefits_administration_label;
        private DataGridView dataGridViewEmployees;
        private Label label1;
        private GradientPanel gradientPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn benefit_id;
        private DataGridViewTextBoxColumn benefit_type;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn default_amount;
    }
}