namespace LibraryUI.Forms
{
    partial class FrmBookContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookContract));
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnYenile = new Button();
            btnNew = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            lblSonuc = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label2 = new Label();
            cmbDurum = new ComboBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label3 = new Label();
            cmbTarih = new ComboBox();
            panel5 = new Panel();
            rdbZA = new RadioButton();
            rdbAZ = new RadioButton();
            label5 = new Label();
            btnClearFilter = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.FromArgb(254, 249, 242);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 67);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1003, 440);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 67);
            panel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 130, 130);
            flowLayoutPanel1.Controls.Add(btnYenile);
            flowLayoutPanel1.Controls.Add(btnNew);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtSearch);
            flowLayoutPanel1.Controls.Add(lblSonuc);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(btnClearFilter);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.No;
            flowLayoutPanel1.Size = new Size(1003, 67);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnYenile
            // 
            btnYenile.Anchor = AnchorStyles.Right;
            btnYenile.BackColor = Color.White;
            btnYenile.BackgroundImage = Properties.Resources.guncelle1;
            btnYenile.BackgroundImageLayout = ImageLayout.Zoom;
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnYenile.FlatStyle = FlatStyle.Popup;
            btnYenile.Location = new Point(967, 15);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(33, 36);
            btnYenile.TabIndex = 3;
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Right;
            btnNew.BackColor = Color.White;
            btnNew.BackgroundImage = Properties.Resources.ekle;
            btnNew.BackgroundImageLayout = ImageLayout.Zoom;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnNew.FlatStyle = FlatStyle.Popup;
            btnNew.Location = new Point(929, 16);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(32, 34);
            btnNew.TabIndex = 4;
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(721, 23);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 5;
            label1.Text = "Teslim Alma/Etme İşlemleri";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.Location = new Point(521, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Teslimat İşlemi İçin Arayın";
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.Size = new Size(194, 29);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSonuc
            // 
            lblSonuc.Anchor = AnchorStyles.Right;
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblSonuc.ForeColor = SystemColors.ButtonHighlight;
            lblSonuc.Location = new Point(436, 25);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.RightToLeft = RightToLeft.No;
            lblSonuc.Size = new Size(79, 17);
            lblSonuc.TabIndex = 0;
            lblSonuc.Text = "label Sonuc";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Right;
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(cmbDurum);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(340, 11);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.RightToLeft = RightToLeft.No;
            flowLayoutPanel3.Size = new Size(90, 45);
            flowLayoutPanel3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(82, 15);
            label2.TabIndex = 0;
            label2.Text = "Duruma Göre";
            // 
            // cmbDurum
            // 
            cmbDurum.Font = new Font("Segoe UI", 7F);
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(3, 18);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(82, 20);
            cmbDurum.TabIndex = 1;
            cmbDurum.SelectedIndexChanged += cmbDurum_SelectedIndexChanged;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Right;
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(cmbTarih);
            flowLayoutPanel4.Location = new Point(206, 11);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.RightToLeft = RightToLeft.No;
            flowLayoutPanel4.Size = new Size(128, 45);
            flowLayoutPanel4.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(118, 15);
            label3.TabIndex = 0;
            label3.Text = "Teslimat Tipine Göre";
            // 
            // cmbTarih
            // 
            cmbTarih.Font = new Font("Segoe UI", 7F);
            cmbTarih.FormattingEnabled = true;
            cmbTarih.Location = new Point(3, 18);
            cmbTarih.Name = "cmbTarih";
            cmbTarih.Size = new Size(118, 20);
            cmbTarih.TabIndex = 1;
            cmbTarih.SelectedIndexChanged += cmbOduncTipi_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.Controls.Add(rdbZA);
            panel5.Controls.Add(rdbAZ);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(122, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(78, 61);
            panel5.TabIndex = 13;
            // 
            // rdbZA
            // 
            rdbZA.AutoSize = true;
            rdbZA.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            rdbZA.ForeColor = SystemColors.ButtonHighlight;
            rdbZA.Location = new Point(16, 35);
            rdbZA.Name = "rdbZA";
            rdbZA.RightToLeft = RightToLeft.No;
            rdbZA.Size = new Size(45, 19);
            rdbZA.TabIndex = 2;
            rdbZA.Text = "Z-A";
            rdbZA.UseVisualStyleBackColor = true;
            rdbZA.CheckedChanged += rdbZA_CheckedChanged;
            // 
            // rdbAZ
            // 
            rdbAZ.Anchor = AnchorStyles.Top;
            rdbAZ.AutoSize = true;
            rdbAZ.Checked = true;
            rdbAZ.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            rdbAZ.ForeColor = SystemColors.ButtonHighlight;
            rdbAZ.Location = new Point(16, 18);
            rdbAZ.Name = "rdbAZ";
            rdbAZ.RightToLeft = RightToLeft.No;
            rdbAZ.Size = new Size(45, 19);
            rdbAZ.TabIndex = 1;
            rdbAZ.TabStop = true;
            rdbAZ.Text = "A-Z";
            rdbAZ.UseVisualStyleBackColor = true;
            rdbAZ.CheckedChanged += rdbAZ_CheckedChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 0;
            label5.Text = "Adına Göre";
            // 
            // btnClearFilter
            // 
            btnClearFilter.Anchor = AnchorStyles.Right;
            btnClearFilter.Location = new Point(53, 12);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(63, 43);
            btnClearFilter.TabIndex = 16;
            btnClearFilter.Text = "Filtreleri Temizle";
            btnClearFilter.UseVisualStyleBackColor = true;
            btnClearFilter.Click += btnTemizle_Click;
            // 
            // FrmBookContract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 507);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmBookContract";
            Text = "Ödünç Alma Formu";
            Load += FrmBookContract_Load_1;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnYenile;
        private Button btnNew;
        private Label label1;
        private TextBox txtSearch;
        private Label lblSonuc;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private ComboBox cmbDurum;
        private Panel panel5;
        private RadioButton rdbZA;
        private RadioButton rdbAZ;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label3;
        private ComboBox cmbTarih;
        private Button btnClearFilter;
    }
}