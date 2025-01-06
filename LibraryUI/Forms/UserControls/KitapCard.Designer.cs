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
            components = new System.ComponentModel.Container();
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
            toolTip1 = new ToolTip(components);
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
            btnDetay.Anchor = AnchorStyles.Right;
            btnDetay.BackColor = Color.FromArgb(201, 233, 210);
            btnDetay.BackgroundImage = Properties.Resources.details;
            btnDetay.BackgroundImageLayout = ImageLayout.Zoom;
            btnDetay.FlatStyle = FlatStyle.Popup;
            btnDetay.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetay.Location = new Point(990, 3);
            btnDetay.Name = "btnDetay";
            btnDetay.Size = new Size(62, 65);
            btnDetay.TabIndex = 5;
            btnDetay.TextAlign = ContentAlignment.MiddleRight;
            btnDetay.UseVisualStyleBackColor = false;
            btnDetay.Click += btnDetay_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Right;
            btnSil.BackColor = Color.FromArgb(201, 233, 210);
            btnSil.BackgroundImage = Properties.Resources.delete_24dp_EA3323_FILL0_wght400_GRAD0_opsz24;
            btnSil.BackgroundImageLayout = ImageLayout.Zoom;
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.Location = new Point(923, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(61, 65);
            btnSil.TabIndex = 7;
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(201, 233, 210);
            btnUpdate.BackgroundImage = Properties.Resources.edit_24dp_F19E39_FILL0_wght400_GRAD0_opsz24;
            btnUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(853, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(64, 65);
            btnUpdate.TabIndex = 8;
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(201, 233, 210);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(771, 75);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Left;
            flowLayoutPanel2.Controls.Add(lblId);
            flowLayoutPanel2.Controls.Add(txtId);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(129, 71);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblId.ForeColor = SystemColors.HighlightText;
            lblId.Location = new Point(3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(107, 30);
            lblId.TabIndex = 19;
            lblId.Text = "Numarası";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(3, 33);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(104, 25);
            txtId.TabIndex = 16;
            txtId.Text = "5";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Left;
            flowLayoutPanel3.Controls.Add(lblKitapAdi);
            flowLayoutPanel3.Controls.Add(txtKitapAdi);
            flowLayoutPanel3.Location = new Point(138, 6);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(165, 65);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // lblKitapAdi
            // 
            lblKitapAdi.AutoSize = true;
            lblKitapAdi.Dock = DockStyle.Fill;
            lblKitapAdi.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            lblKitapAdi.ForeColor = SystemColors.ButtonHighlight;
            lblKitapAdi.Location = new Point(3, 0);
            lblKitapAdi.Name = "lblKitapAdi";
            lblKitapAdi.Size = new Size(44, 28);
            lblKitapAdi.TabIndex = 13;
            lblKitapAdi.Text = "Adı";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Font = new Font("Segoe UI", 10F);
            txtKitapAdi.Location = new Point(3, 31);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.ReadOnly = true;
            txtKitapAdi.Size = new Size(134, 25);
            txtKitapAdi.TabIndex = 14;
            txtKitapAdi.Text = "Kitap";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Left;
            flowLayoutPanel4.Controls.Add(lblStok);
            flowLayoutPanel4.Controls.Add(txtStokAdedi);
            flowLayoutPanel4.Location = new Point(309, 6);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(142, 65);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            lblStok.ForeColor = SystemColors.ControlLightLight;
            lblStok.Location = new Point(3, 0);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(114, 28);
            lblStok.TabIndex = 17;
            lblStok.Text = "Stok Sayısı";
            // 
            // txtStokAdedi
            // 
            txtStokAdedi.Font = new Font("Segoe UI", 10F);
            txtStokAdedi.Location = new Point(3, 31);
            txtStokAdedi.Name = "txtStokAdedi";
            txtStokAdedi.ReadOnly = true;
            txtStokAdedi.Size = new Size(114, 25);
            txtStokAdedi.TabIndex = 20;
            txtStokAdedi.Text = "5";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Anchor = AnchorStyles.Left;
            flowLayoutPanel5.Controls.Add(lblYazar);
            flowLayoutPanel5.Controls.Add(txtYazar);
            flowLayoutPanel5.Location = new Point(457, 6);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(151, 65);
            flowLayoutPanel5.TabIndex = 3;
            // 
            // lblYazar
            // 
            lblYazar.AutoSize = true;
            lblYazar.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            lblYazar.ForeColor = SystemColors.ControlLightLight;
            lblYazar.Location = new Point(3, 0);
            lblYazar.Name = "lblYazar";
            lblYazar.Size = new Size(68, 28);
            lblYazar.TabIndex = 14;
            lblYazar.Text = "Yazarı";
            // 
            // txtYazar
            // 
            txtYazar.Font = new Font("Segoe UI", 10F);
            txtYazar.Location = new Point(3, 31);
            txtYazar.Name = "txtYazar";
            txtYazar.ReadOnly = true;
            txtYazar.Size = new Size(121, 25);
            txtYazar.TabIndex = 15;
            txtYazar.Text = "Kerem";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Anchor = AnchorStyles.Left;
            flowLayoutPanel6.Controls.Add(lblKategori);
            flowLayoutPanel6.Controls.Add(txtKategori);
            flowLayoutPanel6.Location = new Point(614, 6);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(146, 65);
            flowLayoutPanel6.TabIndex = 4;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            lblKategori.ForeColor = SystemColors.ControlLightLight;
            lblKategori.Location = new Point(3, 0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(108, 28);
            lblKategori.TabIndex = 16;
            lblKategori.Text = "Kategorisi";
            // 
            // txtKategori
            // 
            txtKategori.Font = new Font("Segoe UI", 10F);
            txtKategori.Location = new Point(3, 31);
            txtKategori.Name = "txtKategori";
            txtKategori.ReadOnly = true;
            txtKategori.Size = new Size(108, 25);
            txtKategori.TabIndex = 16;
            txtKategori.Text = "Roman";
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Anchor = AnchorStyles.Left;
            flowLayoutPanel7.Controls.Add(lblYayinYili);
            flowLayoutPanel7.Controls.Add(txtYayinYili);
            flowLayoutPanel7.Location = new Point(3, 80);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(117, 65);
            flowLayoutPanel7.TabIndex = 5;
            // 
            // lblYayinYili
            // 
            lblYayinYili.AutoSize = true;
            lblYayinYili.Font = new Font("Segoe UI", 14F);
            lblYayinYili.ForeColor = SystemColors.ButtonHighlight;
            lblYayinYili.Location = new Point(3, 0);
            lblYayinYili.Name = "lblYayinYili";
            lblYayinYili.Size = new Size(87, 25);
            lblYayinYili.TabIndex = 15;
            lblYayinYili.Text = "Yayın Yılı";
            // 
            // txtYayinYili
            // 
            txtYayinYili.Font = new Font("Segoe UI", 10F);
            txtYayinYili.Location = new Point(3, 28);
            txtYayinYili.Name = "txtYayinYili";
            txtYayinYili.ReadOnly = true;
            txtYayinYili.Size = new Size(103, 25);
            txtYayinYili.TabIndex = 16;
            txtYayinYili.Text = "2001";
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.FromArgb(120, 157, 188);
            toolTip1.ForeColor = SystemColors.HighlightText;
            toolTip1.ShowAlways = true;
            // 
            // KitapCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 233, 210);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnUpdate);
            Controls.Add(btnSil);
            Controls.Add(btnDetay);
            Name = "KitapCard";
            Size = new Size(1102, 75);
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
        private ToolTip toolTip1;
    }
}
