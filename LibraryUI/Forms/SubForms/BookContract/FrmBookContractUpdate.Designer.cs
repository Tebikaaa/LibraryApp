namespace LibraryUI.Forms.SubForms.BookContract
{
    partial class FrmBookContractUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookContractUpdate));
            flowLayoutPanel1 = new FlowLayoutPanel();
            label16 = new Label();
            panel14 = new Panel();
            txtNumara = new TextBox();
            label17 = new Label();
            panel9 = new Panel();
            label9 = new Label();
            panel10 = new Panel();
            dtpGeriAlinacakTarih = new DateTimePicker();
            label11 = new Label();
            panel12 = new Panel();
            cmbOduncAlmaTipi = new ComboBox();
            label12 = new Label();
            panel1 = new Panel();
            cmbOduncDurumu = new ComboBox();
            label1 = new Label();
            panel13 = new Panel();
            txtKalanGun = new TextBox();
            label15 = new Label();
            btnGuncelle = new Button();
            dtpAlindigiTarih = new DateTimePicker();
            flowLayoutPanel1.SuspendLayout();
            panel14.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel12.SuspendLayout();
            panel1.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label16);
            flowLayoutPanel1.Controls.Add(panel14);
            flowLayoutPanel1.Controls.Add(panel9);
            flowLayoutPanel1.Controls.Add(panel10);
            flowLayoutPanel1.Controls.Add(panel12);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel13);
            flowLayoutPanel1.Controls.Add(btnGuncelle);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(511, 390);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 21F);
            label16.Location = new Point(3, 0);
            label16.Name = "label16";
            label16.Size = new Size(495, 38);
            label16.TabIndex = 24;
            label16.Text = "Ödünç Alma Detayları";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            panel14.Controls.Add(txtNumara);
            panel14.Controls.Add(label17);
            panel14.Location = new Point(3, 41);
            panel14.Name = "panel14";
            panel14.Size = new Size(495, 39);
            panel14.TabIndex = 27;
            // 
            // txtNumara
            // 
            txtNumara.Font = new Font("Segoe UI", 14F);
            txtNumara.Location = new Point(183, 5);
            txtNumara.Name = "txtNumara";
            txtNumara.ReadOnly = true;
            txtNumara.Size = new Size(309, 32);
            txtNumara.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15F);
            label17.Location = new Point(84, 5);
            label17.Name = "label17";
            label17.Size = new Size(104, 28);
            label17.TabIndex = 0;
            label17.Text = "Numarası :";
            // 
            // panel9
            // 
            panel9.Controls.Add(dtpAlindigiTarih);
            panel9.Controls.Add(label9);
            panel9.Location = new Point(3, 86);
            panel9.Name = "panel9";
            panel9.Size = new Size(495, 39);
            panel9.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(53, 5);
            label9.Name = "label9";
            label9.Size = new Size(135, 28);
            label9.TabIndex = 0;
            label9.Text = "Alındığı Tarih :";
            // 
            // panel10
            // 
            panel10.Controls.Add(dtpGeriAlinacakTarih);
            panel10.Controls.Add(label11);
            panel10.Location = new Point(3, 131);
            panel10.Name = "panel10";
            panel10.Size = new Size(495, 39);
            panel10.TabIndex = 31;
            // 
            // dtpGeriAlinacakTarih
            // 
            dtpGeriAlinacakTarih.DropDownAlign = LeftRightAlignment.Right;
            dtpGeriAlinacakTarih.Enabled = false;
            dtpGeriAlinacakTarih.Font = new Font("Segoe UI", 12F);
            dtpGeriAlinacakTarih.Location = new Point(183, 7);
            dtpGeriAlinacakTarih.Name = "dtpGeriAlinacakTarih";
            dtpGeriAlinacakTarih.Size = new Size(309, 29);
            dtpGeriAlinacakTarih.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F);
            label11.Location = new Point(0, 3);
            label11.Name = "label11";
            label11.Size = new Size(188, 28);
            label11.TabIndex = 0;
            label11.Text = "Geri Alınacağı Tarih :";
            // 
            // panel12
            // 
            panel12.Controls.Add(cmbOduncAlmaTipi);
            panel12.Controls.Add(label12);
            panel12.Location = new Point(3, 176);
            panel12.Name = "panel12";
            panel12.Size = new Size(495, 39);
            panel12.TabIndex = 29;
            // 
            // cmbOduncAlmaTipi
            // 
            cmbOduncAlmaTipi.Font = new Font("Segoe UI", 12F);
            cmbOduncAlmaTipi.FormattingEnabled = true;
            cmbOduncAlmaTipi.Location = new Point(183, 6);
            cmbOduncAlmaTipi.Name = "cmbOduncAlmaTipi";
            cmbOduncAlmaTipi.Size = new Size(309, 29);
            cmbOduncAlmaTipi.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F);
            label12.Location = new Point(22, 3);
            label12.Name = "label12";
            label12.Size = new Size(166, 28);
            label12.TabIndex = 0;
            label12.Text = "Ödünç Alma Tipi :";
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbOduncDurumu);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 221);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 39);
            panel1.TabIndex = 34;
            // 
            // cmbOduncDurumu
            // 
            cmbOduncDurumu.Font = new Font("Segoe UI", 12F);
            cmbOduncDurumu.FormattingEnabled = true;
            cmbOduncDurumu.Location = new Point(183, 6);
            cmbOduncDurumu.Name = "cmbOduncDurumu";
            cmbOduncDurumu.Size = new Size(309, 29);
            cmbOduncDurumu.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(33, 7);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 11;
            label1.Text = "Ödünç Durumu :";
            // 
            // panel13
            // 
            panel13.Controls.Add(txtKalanGun);
            panel13.Controls.Add(label15);
            panel13.Location = new Point(3, 266);
            panel13.Name = "panel13";
            panel13.Size = new Size(495, 39);
            panel13.TabIndex = 36;
            // 
            // txtKalanGun
            // 
            txtKalanGun.Font = new Font("Segoe UI", 14F);
            txtKalanGun.Location = new Point(183, 7);
            txtKalanGun.Name = "txtKalanGun";
            txtKalanGun.ReadOnly = true;
            txtKalanGun.Size = new Size(309, 32);
            txtKalanGun.TabIndex = 10;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15F);
            label15.Location = new Point(78, 4);
            label15.Name = "label15";
            label15.Size = new Size(110, 28);
            label15.TabIndex = 0;
            label15.Text = "Kalan Gün :";
            // 
            // btnGuncelle
            // 
            btnGuncelle.FlatStyle = FlatStyle.System;
            btnGuncelle.Font = new Font("Segoe UI", 16F);
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.Location = new Point(3, 311);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(495, 63);
            btnGuncelle.TabIndex = 37;
            btnGuncelle.Text = "Ödünç Anlaşmasını Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // dtpAlindigiTarih
            // 
            dtpAlindigiTarih.DropDownAlign = LeftRightAlignment.Right;
            dtpAlindigiTarih.Enabled = false;
            dtpAlindigiTarih.Font = new Font("Segoe UI", 12F);
            dtpAlindigiTarih.Location = new Point(183, 5);
            dtpAlindigiTarih.Name = "dtpAlindigiTarih";
            dtpAlindigiTarih.Size = new Size(309, 29);
            dtpAlindigiTarih.TabIndex = 4;
            // 
            // FrmBookContractUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 390);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBookContractUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ödünç Anlaşmasını Güncelleme Formu";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label16;
        private Panel panel14;
        private TextBox txtNumara;
        private Label label17;
        private Panel panel9;
        private Label label9;
        private Panel panel10;
        private Label label11;
        private Panel panel12;
        private Label label12;
        private ComboBox cmbOduncAlmaTipi;
        private Panel panel1;
        private Label label1;
        private Panel panel13;
        private TextBox txtKalanGun;
        private Label label15;
        private Button btnGuncelle;
        private ComboBox cmbOduncDurumu;
        private DateTimePicker dtpGeriAlinacakTarih;
        private DateTimePicker dtpAlindigiTarih;
    }
}