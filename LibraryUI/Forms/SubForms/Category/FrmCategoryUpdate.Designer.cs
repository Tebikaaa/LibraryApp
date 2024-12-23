namespace LibraryUI.Forms.SubForms.Category
{
    partial class FrmCategoryUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoryUpdate));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            txtNumara = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            txtKategoriAdi = new TextBox();
            label1 = new Label();
            btnGuncelle = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnGuncelle);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(352, 184);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtNumara);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(345, 54);
            panel2.TabIndex = 7;
            // 
            // txtNumara
            // 
            txtNumara.Font = new Font("Segoe UI", 14F);
            txtNumara.Location = new Point(176, 17);
            txtNumara.Name = "txtNumara";
            txtNumara.ReadOnly = true;
            txtNumara.Size = new Size(154, 32);
            txtNumara.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(3, 20);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 4;
            label2.Text = "Kategori Numarası :";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtKategoriAdi);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 52);
            panel1.TabIndex = 6;
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Font = new Font("Segoe UI", 14F);
            txtKategoriAdi.Location = new Point(134, 11);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(196, 32);
            txtKategoriAdi.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 7;
            label1.Text = "Kategori Adı :";
            // 
            // btnGuncelle
            // 
            btnGuncelle.FlatStyle = FlatStyle.System;
            btnGuncelle.Font = new Font("Segoe UI", 18F);
            btnGuncelle.Image = Properties.Resources.guncelle;
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.Location = new Point(3, 121);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(345, 51);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // FrmCategoryUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 184);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCategoryUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategori Güncelleme Formu";
            Load += FrmCategoryUpdate_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label lblNumara;
        private Label label2;
        private Panel panel1;
        private TextBox txtKategoriAdi;
        private Label label1;
        private Button btnGuncelle;
        private TextBox txtNumara;
    }
}