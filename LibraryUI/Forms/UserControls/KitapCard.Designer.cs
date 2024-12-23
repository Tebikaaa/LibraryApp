namespace LibraryUI.Forms.UserControls
{
    partial class KitapCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDetay = new Button();
            btnSil = new Button();
            btnUpdate = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblId = new Label();
            txtId = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            lblKitapAdi = new Label();
            txtKitapAdi = new TextBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            lblStok = new Label();
            txtStokAdedi = new TextBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            lblYazar = new Label();
            txtYazar = new TextBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            lblKategori = new Label();
            txtKategori = new TextBox();
            flowLayoutPanel7 = new FlowLayoutPanel();
            lblYayinYili = new Label();
            txtYayinYili = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // btnDetay
            // 
            btnDetay.BackColor = Color.DodgerBlue;
            btnDetay.BackgroundImage = Properties.Resources.details;
            btnDetay.BackgroundImageLayout = ImageLayout.Zoom;
            btnDetay.Dock = DockStyle.Right;
            btnDetay.FlatStyle = FlatStyle.Popup;
            btnDetay.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetay.Location = new Point(1030, 0);
            btnDetay.Name = "btnDetay";
            btnDetay.Size = new Size(61, 77);
            btnDetay.TabIndex = 5;
            btnDetay.TextAlign = ContentAlignment.MiddleRight;
            btnDetay.UseVisualStyleBackColor = false;
            btnDetay.Click += btnDetay_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DodgerBlue;
            btnSil.BackgroundImage = Properties.Resources.delete;
            btnSil.BackgroundImageLayout = ImageLayout.Zoom;
            btnSil.Dock = DockStyle.Right;
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.Location = new Point(969, 0);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(61, 77);
            btnSil.TabIndex = 7;
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.BackgroundImage = Properties.Resources.guncelle;
            btnUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            btnUpdate.Dock = DockStyle.Right;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(905, 0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(64, 77);
            btnUpdate.TabIndex = 8;
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DodgerBlue;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(905, 77);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblId);
            flowLayoutPanel2.Controls.Add(txtId);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(114, 71);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 16F);
            lblId.ForeColor = SystemColors.HighlightText;
            lblId.Location = new Point(3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(104, 30);
            lblId.TabIndex = 19;
            lblId.Text = "Numarası";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.Location = new Point(3, 33);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(104, 29);
            txtId.TabIndex = 16;
            txtId.Text = "5";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(lblKitapAdi);
            flowLayoutPanel3.Controls.Add(txtKitapAdi);
            flowLayoutPanel3.Location = new Point(123, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(148, 71);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // lblKitapAdi
            // 
            lblKitapAdi.AutoSize = true;
            lblKitapAdi.Dock = DockStyle.Fill;
            lblKitapAdi.Font = new Font("Segoe UI", 16F);
            lblKitapAdi.ForeColor = SystemColors.ButtonHighlight;
            lblKitapAdi.Location = new Point(3, 0);
            lblKitapAdi.Name = "lblKitapAdi";
            lblKitapAdi.Size = new Size(45, 30);
            lblKitapAdi.TabIndex = 13;
            lblKitapAdi.Text = "Adı";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Dock = DockStyle.Fill;
            txtKitapAdi.Font = new Font("Segoe UI", 12F);
            txtKitapAdi.Location = new Point(3, 33);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.ReadOnly = true;
            txtKitapAdi.Size = new Size(145, 29);
            txtKitapAdi.TabIndex = 14;
            txtKitapAdi.Text = "Kitap";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(lblStok);
            flowLayoutPanel4.Controls.Add(txtStokAdedi);
            flowLayoutPanel4.Location = new Point(277, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(129, 74);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Font = new Font("Segoe UI", 16F);
            lblStok.ForeColor = SystemColors.ControlLightLight;
            lblStok.Location = new Point(3, 0);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(114, 30);
            lblStok.TabIndex = 17;
            lblStok.Text = "Stok Sayısı";
            // 
            // txtStokAdedi
            // 
            txtStokAdedi.Font = new Font("Segoe UI", 12F);
            txtStokAdedi.Location = new Point(3, 33);
            txtStokAdedi.Name = "txtStokAdedi";
            txtStokAdedi.ReadOnly = true;
            txtStokAdedi.Size = new Size(126, 29);
            txtStokAdedi.TabIndex = 20;
            txtStokAdedi.Text = "5";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(lblYazar);
            flowLayoutPanel5.Controls.Add(txtYazar);
            flowLayoutPanel5.Location = new Point(412, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(197, 74);
            flowLayoutPanel5.TabIndex = 3;
            // 
            // lblYazar
            // 
            lblYazar.AutoSize = true;
            lblYazar.Font = new Font("Segoe UI", 16F);
            lblYazar.ForeColor = SystemColors.ControlLightLight;
            lblYazar.Location = new Point(3, 0);
            lblYazar.Name = "lblYazar";
            lblYazar.Size = new Size(68, 30);
            lblYazar.TabIndex = 14;
            lblYazar.Text = "Yazarı";
            // 
            // txtYazar
            // 
            txtYazar.Font = new Font("Segoe UI", 12F);
            txtYazar.Location = new Point(3, 33);
            txtYazar.Name = "txtYazar";
            txtYazar.ReadOnly = true;
            txtYazar.Size = new Size(194, 29);
            txtYazar.TabIndex = 15;
            txtYazar.Text = "Kerem";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(lblKategori);
            flowLayoutPanel6.Controls.Add(txtKategori);
            flowLayoutPanel6.Location = new Point(615, 3);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(161, 74);
            flowLayoutPanel6.TabIndex = 4;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Segoe UI", 16F);
            lblKategori.ForeColor = SystemColors.ControlLightLight;
            lblKategori.Location = new Point(3, 0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(109, 30);
            lblKategori.TabIndex = 16;
            lblKategori.Text = "Kategorisi";
            // 
            // txtKategori
            // 
            txtKategori.Font = new Font("Segoe UI", 12F);
            txtKategori.Location = new Point(3, 33);
            txtKategori.Name = "txtKategori";
            txtKategori.ReadOnly = true;
            txtKategori.Size = new Size(158, 29);
            txtKategori.TabIndex = 16;
            txtKategori.Text = "Roman";
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(lblYayinYili);
            flowLayoutPanel7.Controls.Add(txtYayinYili);
            flowLayoutPanel7.Location = new Point(782, 3);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(106, 71);
            flowLayoutPanel7.TabIndex = 5;
            // 
            // lblYayinYili
            // 
            lblYayinYili.AutoSize = true;
            lblYayinYili.Font = new Font("Segoe UI", 16F);
            lblYayinYili.ForeColor = SystemColors.ButtonHighlight;
            lblYayinYili.Location = new Point(3, 0);
            lblYayinYili.Name = "lblYayinYili";
            lblYayinYili.Size = new Size(95, 30);
            lblYayinYili.TabIndex = 15;
            lblYayinYili.Text = "Yayın Yılı";
            // 
            // txtYayinYili
            // 
            txtYayinYili.Font = new Font("Segoe UI", 12F);
            txtYayinYili.Location = new Point(3, 33);
            txtYayinYili.Name = "txtYayinYili";
            txtYayinYili.ReadOnly = true;
            txtYayinYili.Size = new Size(103, 29);
            txtYayinYili.TabIndex = 16;
            txtYayinYili.Text = "2001";
            // 
            // KitapCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnUpdate);
            Controls.Add(btnSil);
            Controls.Add(btnDetay);
            Name = "KitapCard";
            Size = new Size(1091, 77);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnDetay;
        private Button btnSil;
        private Button btnUpdate;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblId;
        private Label lblStok;
        private Label lblKategori;
        private Label lblYayinYili;
        private Label lblYazar;
        private Label lblKitapAdi;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel7;
        private TextBox txtId;
        private TextBox txtKitapAdi;
        private TextBox txtYazar;
        private TextBox txtKategori;
        private TextBox txtYayinYili;
        private TextBox txtStokAdedi;
    }
}
