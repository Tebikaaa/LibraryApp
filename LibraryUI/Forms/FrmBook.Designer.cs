namespace LibraryUI.Forms
{
    partial class FrmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBook));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnYenile = new Button();
            btnNewKitap = new Button();
            label1 = new Label();
            panel2 = new Panel();
            txtSearch = new TextBox();
            panel3 = new Panel();
            lblSonuc = new Label();
            panel4 = new Panel();
            cmbKategori = new ComboBox();
            label2 = new Label();
            panel5 = new Panel();
            rdbZA = new RadioButton();
            rdbAZ = new RadioButton();
            label3 = new Label();
            panel6 = new Panel();
            cmbStok = new ComboBox();
            label4 = new Label();
            panel7 = new Panel();
            cmbDurum = new ComboBox();
            label5 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnClearFilter = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1578, 67);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnYenile);
            flowLayoutPanel1.Controls.Add(btnNewKitap);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(btnClearFilter);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(1578, 67);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnYenile
            // 
            btnYenile.BackgroundImage = Properties.Resources.guncelle1;
            btnYenile.BackgroundImageLayout = ImageLayout.Zoom;
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnYenile.FlatStyle = FlatStyle.Popup;
            btnYenile.Location = new Point(1533, 3);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(42, 58);
            btnYenile.TabIndex = 3;
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnNewKitap
            // 
            btnNewKitap.BackgroundImage = Properties.Resources.ekle;
            btnNewKitap.BackgroundImageLayout = ImageLayout.Zoom;
            btnNewKitap.FlatAppearance.BorderSize = 0;
            btnNewKitap.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnNewKitap.FlatStyle = FlatStyle.Popup;
            btnNewKitap.Location = new Point(1484, 3);
            btnNewKitap.Name = "btnNewKitap";
            btnNewKitap.Size = new Size(43, 58);
            btnNewKitap.TabIndex = 4;
            btnNewKitap.UseVisualStyleBackColor = true;
            btnNewKitap.Click += btnNewKitap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(1189, 0);
            label1.Name = "label1";
            label1.Size = new Size(289, 59);
            label1.TabIndex = 5;
            label1.Text = "Kitap İşlemleri";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtSearch);
            panel2.Location = new Point(870, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 61);
            panel2.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18F);
            txtSearch.Location = new Point(0, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Kitaplar İçin Arayın";
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.Size = new Size(310, 39);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblSonuc);
            panel3.Location = new Point(727, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(137, 61);
            panel3.TabIndex = 9;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 12F);
            lblSonuc.Location = new Point(3, 16);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.RightToLeft = RightToLeft.No;
            lblSonuc.Size = new Size(90, 21);
            lblSonuc.TabIndex = 0;
            lblSonuc.Text = "label Sonuc";
            // 
            // panel4
            // 
            panel4.Controls.Add(cmbKategori);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(521, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 61);
            panel4.TabIndex = 10;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(3, 27);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.RightToLeft = RightToLeft.No;
            cmbKategori.Size = new Size(194, 23);
            cmbKategori.TabIndex = 1;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 0;
            label2.Text = "Kategoriye Göre";
            // 
            // panel5
            // 
            panel5.Controls.Add(rdbZA);
            panel5.Controls.Add(rdbAZ);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(395, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(120, 61);
            panel5.TabIndex = 11;
            // 
            // rdbZA
            // 
            rdbZA.AutoSize = true;
            rdbZA.Location = new Point(66, 27);
            rdbZA.Name = "rdbZA";
            rdbZA.RightToLeft = RightToLeft.No;
            rdbZA.Size = new Size(45, 19);
            rdbZA.TabIndex = 2;
            rdbZA.TabStop = true;
            rdbZA.Text = "Z-A";
            rdbZA.UseVisualStyleBackColor = true;
            rdbZA.CheckedChanged += rdbZA_CheckedChanged;
            // 
            // rdbAZ
            // 
            rdbAZ.AutoSize = true;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 6);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 0;
            label3.Text = "Adına Göre";
            // 
            // panel6
            // 
            panel6.Controls.Add(cmbStok);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(269, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(120, 61);
            panel6.TabIndex = 12;
            // 
            // cmbStok
            // 
            cmbStok.FormattingEnabled = true;
            cmbStok.Location = new Point(3, 29);
            cmbStok.Name = "cmbStok";
            cmbStok.RightToLeft = RightToLeft.No;
            cmbStok.Size = new Size(114, 23);
            cmbStok.TabIndex = 2;
            cmbStok.SelectedIndexChanged += cmbStok_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 6);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 0;
            label4.Text = "Stoğa Göre";
            // 
            // panel7
            // 
            panel7.Controls.Add(cmbDurum);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(143, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(120, 61);
            panel7.TabIndex = 13;
            // 
            // cmbDurum
            // 
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(3, 29);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.RightToLeft = RightToLeft.No;
            cmbDurum.Size = new Size(114, 23);
            cmbDurum.TabIndex = 2;
            cmbDurum.SelectedIndexChanged += cmbDurum_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 6);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 0;
            label5.Text = "Duruma Göre";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.FromArgb(255, 192, 192);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(0, 67);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1578, 570);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.White;
            flowLayoutPanel3.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel3.Dock = DockStyle.Bottom;
            flowLayoutPanel3.Location = new Point(3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(0, 79);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Dock = DockStyle.Left;
            flowLayoutPanel4.Location = new Point(3, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(200, 0);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(button1);
            flowLayoutPanel5.Controls.Add(button2);
            flowLayoutPanel5.Controls.Add(button3);
            flowLayoutPanel5.Location = new Point(3, 9);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(257, 72);
            flowLayoutPanel5.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(79, 69);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(88, 3);
            button2.Name = "button2";
            button2.Size = new Size(79, 69);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(173, 3);
            button3.Name = "button3";
            button3.Size = new Size(79, 69);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new Point(50, 3);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(87, 61);
            btnClearFilter.TabIndex = 14;
            btnClearFilter.Text = "Filtreleri Temizle";
            btnClearFilter.UseVisualStyleBackColor = true;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // FrmBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1578, 637);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitap İşlemleri";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnYenile;
        private Button btnNewKitap;
        private Label label1;
        private Panel panel2;
        private TextBox txtSearch;
        private Panel panel3;
        private Label lblSonuc;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel4;
        private ComboBox cmbKategori;
        private Label label2;
        private Panel panel5;
        private RadioButton rdbZA;
        private RadioButton rdbAZ;
        private Label label3;
        private Panel panel6;
        private ComboBox cmbStok;
        private Label label4;
        private Panel panel7;
        private ComboBox cmbDurum;
        private Label label5;
        private Button btnClearFilter;
    }
}