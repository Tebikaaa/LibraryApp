namespace LibraryUI.Forms.SubForms.Member
{
    partial class FrmMemberAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMemberAdd));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            txtAdSoyad = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            txtEmail = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            txtTelefon = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            cmbDurum = new ComboBox();
            label4 = new Label();
            btnAdd = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(414, 251);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtAdSoyad);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(407, 39);
            panel2.TabIndex = 3;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Segoe UI", 14F);
            txtAdSoyad.Location = new Point(136, 3);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(268, 32);
            txtAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(19, 3);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 0;
            label2.Text = "Adı Soyadı:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 39);
            panel1.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(82, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(322, 32);
            txtEmail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(19, 3);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Email :";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTelefon);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(407, 39);
            panel3.TabIndex = 5;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Segoe UI", 14F);
            txtTelefon.Location = new Point(98, 4);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(306, 32);
            txtTelefon.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(19, 4);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 0;
            label3.Text = "Telefon :";
            // 
            // panel4
            // 
            panel4.Controls.Add(cmbDurum);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 138);
            panel4.Name = "panel4";
            panel4.Size = new Size(407, 39);
            panel4.TabIndex = 6;
            // 
            // cmbDurum
            // 
            cmbDurum.Font = new Font("Segoe UI", 12F);
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(145, 6);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(259, 29);
            cmbDurum.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(19, 3);
            label4.Name = "label4";
            label4.Size = new Size(131, 28);
            label4.TabIndex = 2;
            label4.Text = "Üye Durumu :";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 16F);
            btnAdd.Location = new Point(3, 183);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(407, 59);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Üyeyi Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // FrmMemberAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 251);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMemberAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Ekleme Formu";
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private TextBox txtAdSoyad;
        private Label label2;
        private Panel panel1;
        private TextBox txtEmail;
        private Label label1;
        private Panel panel3;
        private TextBox txtTelefon;
        private Label label3;
        private Button btnAdd;
        private Panel panel4;
        private ComboBox cmbDurum;
        private Label label4;
    }
}