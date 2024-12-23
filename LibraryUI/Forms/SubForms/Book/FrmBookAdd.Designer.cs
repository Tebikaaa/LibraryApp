namespace LibraryUI.Forms.SubForms.Book
{
    partial class FrmBookAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookAdd));
            btnEkle = new Button();
            cmbDurum = new ComboBox();
            panel9 = new Panel();
            label9 = new Label();
            label7 = new Label();
            panel7 = new Panel();
            nudStokAdedi = new NumericUpDown();
            cmbKategori = new ComboBox();
            label6 = new Label();
            panel6 = new Panel();
            txtISBN = new TextBox();
            label8 = new Label();
            label4 = new Label();
            txtYayinYili = new TextBox();
            panel8 = new Panel();
            txtYazar = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            txtKitapAdi = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStokAdedi).BeginInit();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.FlatStyle = FlatStyle.System;
            btnEkle.Font = new Font("Segoe UI", 16F);
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.Location = new Point(3, 320);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(445, 63);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Kitabı Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // cmbDurum
            // 
            cmbDurum.Font = new Font("Segoe UI", 13F);
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(119, 5);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(314, 31);
            cmbDurum.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(cmbDurum);
            panel9.Controls.Add(label9);
            panel9.Location = new Point(3, 275);
            panel9.Name = "panel9";
            panel9.Size = new Size(445, 39);
            panel9.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(21, 5);
            label9.Name = "label9";
            label9.Size = new Size(92, 28);
            label9.TabIndex = 0;
            label9.Text = "Durumu :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(9, 4);
            label7.Name = "label7";
            label7.Size = new Size(117, 28);
            label7.TabIndex = 0;
            label7.Text = "Stok Adedi :";
            // 
            // panel7
            // 
            panel7.Controls.Add(nudStokAdedi);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(3, 230);
            panel7.Name = "panel7";
            panel7.Size = new Size(445, 39);
            panel7.TabIndex = 2;
            // 
            // nudStokAdedi
            // 
            nudStokAdedi.Font = new Font("Segoe UI", 12F);
            nudStokAdedi.Location = new Point(119, 7);
            nudStokAdedi.Name = "nudStokAdedi";
            nudStokAdedi.Size = new Size(314, 29);
            nudStokAdedi.TabIndex = 1;
            nudStokAdedi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbKategori
            // 
            cmbKategori.Font = new Font("Segoe UI", 13F);
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(119, 5);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(314, 31);
            cmbKategori.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(9, 4);
            label6.Name = "label6";
            label6.Size = new Size(109, 28);
            label6.TabIndex = 0;
            label6.Text = "Kategorisi :";
            // 
            // panel6
            // 
            panel6.Controls.Add(cmbKategori);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(3, 185);
            panel6.Name = "panel6";
            panel6.Size = new Size(445, 39);
            panel6.TabIndex = 2;
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Segoe UI", 14F);
            txtISBN.Location = new Point(107, 4);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(326, 32);
            txtISBN.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(21, 5);
            label8.Name = "label8";
            label8.Size = new Size(97, 28);
            label8.TabIndex = 0;
            label8.Text = "Yayın Yılı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(50, 4);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 0;
            label4.Text = "ISBN :";
            // 
            // txtYayinYili
            // 
            txtYayinYili.Font = new Font("Segoe UI", 14F);
            txtYayinYili.Location = new Point(116, 5);
            txtYayinYili.Name = "txtYayinYili";
            txtYayinYili.Size = new Size(317, 32);
            txtYayinYili.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(txtYayinYili);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(3, 93);
            panel8.Name = "panel8";
            panel8.Size = new Size(445, 41);
            panel8.TabIndex = 3;
            // 
            // txtYazar
            // 
            txtYazar.Font = new Font("Segoe UI", 14F);
            txtYazar.Location = new Point(107, 4);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(326, 32);
            txtYazar.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(47, 4);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 0;
            label3.Text = "Yazar :";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtYazar);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 39);
            panel3.TabIndex = 2;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Font = new Font("Segoe UI", 14F);
            txtKitapAdi.Location = new Point(107, 4);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(326, 32);
            txtKitapAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(62, 4);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 0;
            label2.Text = "Adı :";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtKitapAdi);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 39);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtISBN);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 140);
            panel4.Name = "panel4";
            panel4.Size = new Size(445, 39);
            panel4.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel9);
            flowLayoutPanel1.Controls.Add(btnEkle);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(453, 389);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // FrmBookAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 389);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBookAdd";
            Text = "Kitap Ekleme Formu";
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStokAdedi).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnEkle;
        private ComboBox cmbDurum;
        private Panel panel9;
        private Label label9;
        private Label label7;
        private Panel panel7;
        private ComboBox cmbKategori;
        private Label label6;
        private Panel panel6;
        private TextBox txtISBN;
        private Label label8;
        private Label label4;
        private TextBox txtYayinYili;
        private Panel panel8;
        private TextBox txtYazar;
        private Label label3;
        private Panel panel3;
        private TextBox txtKitapAdi;
        private Label label2;
        private Panel panel2;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private NumericUpDown nudStokAdedi;
    }
}