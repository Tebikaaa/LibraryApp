
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
            panel2 = new Panel();
            txtSearch = new TextBox();
            panel3 = new Panel();
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
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.FromArgb(255, 192, 192);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 67);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1589, 599);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1589, 67);
            panel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnYenile);
            flowLayoutPanel1.Controls.Add(btnNew);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(btnClearFilter);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(1589, 67);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnYenile
            // 
            btnYenile.BackgroundImage = Properties.Resources.guncelle1;
            btnYenile.BackgroundImageLayout = ImageLayout.Zoom;
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnYenile.FlatStyle = FlatStyle.Popup;
            btnYenile.Location = new Point(1544, 3);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(42, 58);
            btnYenile.TabIndex = 3;
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnNew
            // 
            btnNew.BackgroundImage = Properties.Resources.ekle;
            btnNew.BackgroundImageLayout = ImageLayout.Zoom;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnNew.FlatStyle = FlatStyle.Popup;
            btnNew.Location = new Point(1495, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(43, 58);
            btnNew.TabIndex = 4;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(1224, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 59);
            label1.TabIndex = 5;
            label1.Text = "Üye İşlemleri";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtSearch);
            panel2.Location = new Point(902, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 61);
            panel2.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18F);
            txtSearch.Location = new Point(0, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Üyeler için arayın";
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.Size = new Size(313, 39);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblSonuc);
            panel3.Location = new Point(676, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 61);
            panel3.TabIndex = 8;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 14F);
            lblSonuc.Location = new Point(3, 16);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.RightToLeft = RightToLeft.No;
            lblSonuc.Size = new Size(110, 25);
            lblSonuc.TabIndex = 0;
            lblSonuc.Text = "label Sonuc";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(cmbDurum);
            flowLayoutPanel3.Location = new Point(520, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.RightToLeft = RightToLeft.No;
            flowLayoutPanel3.Size = new Size(150, 61);
            flowLayoutPanel3.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(126, 25);
            label2.TabIndex = 0;
            label2.Text = "Duruma Göre";
            // 
            // cmbDurum
            // 
            cmbDurum.Font = new Font("Segoe UI", 10F);
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(3, 28);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(132, 25);
            cmbDurum.TabIndex = 1;
            cmbDurum.SelectedIndexChanged += cmbDurum_SelectedIndexChanged;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(cmbTarih);
            flowLayoutPanel4.Location = new Point(365, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.RightToLeft = RightToLeft.No;
            flowLayoutPanel4.Size = new Size(149, 61);
            flowLayoutPanel4.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(109, 25);
            label3.TabIndex = 0;
            label3.Text = "Tarihe Göre";
            // 
            // cmbTarih
            // 
            cmbTarih.Font = new Font("Segoe UI", 10F);
            cmbTarih.FormattingEnabled = true;
            cmbTarih.Location = new Point(3, 28);
            cmbTarih.Name = "cmbTarih";
            cmbTarih.Size = new Size(132, 25);
            cmbTarih.TabIndex = 1;
            cmbTarih.SelectedIndexChanged += cmbTarih_SelectedIndexChanged;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label4);
            flowLayoutPanel5.Controls.Add(cmbEmail);
            flowLayoutPanel5.Location = new Point(224, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.RightToLeft = RightToLeft.No;
            flowLayoutPanel5.Size = new Size(135, 61);
            flowLayoutPanel5.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(114, 25);
            label4.TabIndex = 0;
            label4.Text = "Emaile Göre";
            // 
            // cmbEmail
            // 
            cmbEmail.Font = new Font("Segoe UI", 10F);
            cmbEmail.FormattingEnabled = true;
            cmbEmail.Location = new Point(3, 28);
            cmbEmail.Name = "cmbEmail";
            cmbEmail.Size = new Size(124, 25);
            cmbEmail.TabIndex = 1;
            cmbEmail.SelectedIndexChanged += cmbEmail_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(rdbZA);
            panel5.Controls.Add(rdbAZ);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(98, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(120, 61);
            panel5.TabIndex = 12;
            // 
            // rdbZA
            // 
            rdbZA.AutoSize = true;
            rdbZA.Location = new Point(66, 27);
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
            rdbAZ.AutoSize = true;
            rdbAZ.Checked = true;
            rdbAZ.Location = new Point(5, 27);
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
            label5.AutoSize = true;
            label5.Location = new Point(3, 6);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 0;
            label5.Text = "Adına Göre";
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new Point(5, 3);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(87, 61);
            btnClearFilter.TabIndex = 15;
            btnClearFilter.Text = "Filtreleri Temizle";
            btnClearFilter.UseVisualStyleBackColor = true;
            btnClearFilter.Click += btnFiltreTemizle_Click;
            // 
            // FrmMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1589, 666);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel2;
        private TextBox txtSearch;
        private Panel panel3;
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