
namespace LibraryUI.Forms
{
    partial class FrmMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMember));
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
            flowLayoutPanel5 = new FlowLayoutPanel();
            label4 = new Label();
            cmbEmail = new ComboBox();
            panel5 = new Panel();
            rdbZA = new RadioButton();
            rdbAZ = new RadioButton();
            label5 = new Label();
            btnClearFilter = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
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
            flowLayoutPanel2.Size = new Size(849, 361);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 67);
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
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(btnClearFilter);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(849, 67);
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
            btnYenile.Location = new Point(814, 15);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(32, 36);
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
            btnNew.Location = new Point(776, 16);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(32, 35);
            btnNew.TabIndex = 4;
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(648, 21);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 5;
            label1.Text = "Üye İşlemleri";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(493, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Üyeler için arayın";
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.Size = new Size(149, 25);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSonuc
            // 
            lblSonuc.Anchor = AnchorStyles.Right;
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblSonuc.ForeColor = SystemColors.ButtonHighlight;
            lblSonuc.Location = new Point(408, 25);
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
            flowLayoutPanel3.Location = new Point(316, 12);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.RightToLeft = RightToLeft.No;
            flowLayoutPanel3.Size = new Size(86, 43);
            flowLayoutPanel3.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(79, 15);
            label2.TabIndex = 0;
            label2.Text = "Duruma Göre";
            // 
            // cmbDurum
            // 
            cmbDurum.Font = new Font("Segoe UI", 7F);
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(3, 18);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(79, 20);
            cmbDurum.TabIndex = 1;
            cmbDurum.SelectedIndexChanged += cmbDurum_SelectedIndexChanged;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Right;
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(cmbTarih);
            flowLayoutPanel4.Location = new Point(237, 12);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.RightToLeft = RightToLeft.No;
            flowLayoutPanel4.Size = new Size(73, 43);
            flowLayoutPanel4.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(67, 15);
            label3.TabIndex = 0;
            label3.Text = "Tarihe Göre";
            // 
            // cmbTarih
            // 
            cmbTarih.Font = new Font("Segoe UI", 7F);
            cmbTarih.FormattingEnabled = true;
            cmbTarih.Location = new Point(3, 18);
            cmbTarih.Name = "cmbTarih";
            cmbTarih.Size = new Size(67, 20);
            cmbTarih.TabIndex = 1;
            cmbTarih.SelectedIndexChanged += cmbTarih_SelectedIndexChanged;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Anchor = AnchorStyles.Right;
            flowLayoutPanel5.Controls.Add(label4);
            flowLayoutPanel5.Controls.Add(cmbEmail);
            flowLayoutPanel5.Location = new Point(154, 12);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.RightToLeft = RightToLeft.No;
            flowLayoutPanel5.Size = new Size(77, 43);
            flowLayoutPanel5.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(70, 15);
            label4.TabIndex = 0;
            label4.Text = "Emaile Göre";
            // 
            // cmbEmail
            // 
            cmbEmail.Font = new Font("Segoe UI", 7F);
            cmbEmail.FormattingEnabled = true;
            cmbEmail.Location = new Point(3, 18);
            cmbEmail.Name = "cmbEmail";
            cmbEmail.Size = new Size(70, 20);
            cmbEmail.TabIndex = 1;
            cmbEmail.SelectedIndexChanged += cmbEmail_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(rdbZA);
            panel5.Controls.Add(rdbAZ);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(74, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(74, 61);
            panel5.TabIndex = 12;
            // 
            // rdbZA
            // 
            rdbZA.AutoSize = true;
            rdbZA.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic);
            rdbZA.ForeColor = SystemColors.ButtonHighlight;
            rdbZA.Location = new Point(15, 42);
            rdbZA.Name = "rdbZA";
            rdbZA.RightToLeft = RightToLeft.No;
            rdbZA.Size = new Size(42, 17);
            rdbZA.TabIndex = 2;
            rdbZA.Text = "Z-A";
            rdbZA.UseVisualStyleBackColor = true;
            rdbZA.CheckedChanged += rdbZA_CheckedChanged;
            // 
            // rdbAZ
            // 
            rdbAZ.AutoSize = true;
            rdbAZ.Checked = true;
            rdbAZ.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic);
            rdbAZ.ForeColor = SystemColors.ButtonHighlight;
            rdbAZ.Location = new Point(15, 21);
            rdbAZ.Name = "rdbAZ";
            rdbAZ.RightToLeft = RightToLeft.No;
            rdbAZ.Size = new Size(42, 17);
            rdbAZ.TabIndex = 1;
            rdbAZ.TabStop = true;
            rdbAZ.Text = "A-Z";
            rdbAZ.UseVisualStyleBackColor = true;
            rdbAZ.CheckedChanged += rdbAZ_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(3, 6);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 0;
            label5.Text = "Adına Göre";
            // 
            // btnClearFilter
            // 
            btnClearFilter.Anchor = AnchorStyles.Right;
            btnClearFilter.Location = new Point(8, 13);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(60, 40);
            btnClearFilter.TabIndex = 15;
            btnClearFilter.Text = "Filtreleri Temizle";
            btnClearFilter.UseVisualStyleBackColor = true;
            btnClearFilter.Click += btnFiltreTemizle_Click;
            // 
            // FrmMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 428);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Formu";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
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
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label3;
        private ComboBox cmbTarih;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label4;
        private ComboBox cmbEmail;
        private Panel panel5;
        private RadioButton rdbZA;
        private RadioButton rdbAZ;
        private Label label5;
        private Button btnClearFilter;
    }
}