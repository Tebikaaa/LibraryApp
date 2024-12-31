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
            txtSearch = new TextBox();
            lblSonuc = new Label();
            panel4 = new Panel();
            cmbKategori = new ComboBox();
            label2 = new Label();
            panel6 = new Panel();
            cmbStok = new ComboBox();
            label4 = new Label();
            panel7 = new Panel();
            cmbDurum = new ComboBox();
            label5 = new Label();
            panel5 = new Panel();
            rdbZA = new RadioButton();
            rdbAZ = new RadioButton();
            label3 = new Label();
            btnClearFilter = new Button();
            panel2 = new Panel();
            label9 = new Label();
            pictureBox6 = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
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
            panel1.Size = new Size(1173, 67);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 130, 130);
            flowLayoutPanel1.Controls.Add(btnYenile);
            flowLayoutPanel1.Controls.Add(btnNewKitap);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtSearch);
            flowLayoutPanel1.Controls.Add(lblSonuc);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(btnClearFilter);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(1173, 67);
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
            btnYenile.Location = new Point(1137, 14);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(33, 38);
            btnYenile.TabIndex = 3;
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnNewKitap
            // 
            btnNewKitap.Anchor = AnchorStyles.Right;
            btnNewKitap.BackColor = Color.White;
            btnNewKitap.BackgroundImage = Properties.Resources.ekle;
            btnNewKitap.BackgroundImageLayout = ImageLayout.Zoom;
            btnNewKitap.FlatAppearance.BorderSize = 0;
            btnNewKitap.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnNewKitap.FlatStyle = FlatStyle.Popup;
            btnNewKitap.Location = new Point(1099, 15);
            btnNewKitap.Name = "btnNewKitap";
            btnNewKitap.Size = new Size(32, 36);
            btnNewKitap.TabIndex = 4;
            btnNewKitap.UseVisualStyleBackColor = false;
            btnNewKitap.Click += btnNewKitap_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(959, 21);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 5;
            label1.Text = "Kitap İşlemleri";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(815, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Kitaplar İçin Arayın";
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.Size = new Size(138, 25);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSonuc
            // 
            lblSonuc.Anchor = AnchorStyles.Right;
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSonuc.ForeColor = SystemColors.ButtonHighlight;
            lblSonuc.Location = new Point(730, 25);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.RightToLeft = RightToLeft.No;
            lblSonuc.Size = new Size(79, 17);
            lblSonuc.TabIndex = 0;
            lblSonuc.Text = "label Sonuc";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Right;
            panel4.Controls.Add(cmbKategori);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(450, 7);
            panel4.Name = "panel4";
            panel4.Size = new Size(98, 52);
            panel4.TabIndex = 10;
            // 
            // cmbKategori
            // 
            cmbKategori.Font = new Font("Segoe UI", 7F);
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(3, 27);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.RightToLeft = RightToLeft.No;
            cmbKategori.Size = new Size(91, 20);
            cmbKategori.TabIndex = 1;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 0;
            label2.Text = "Kategoriye Göre";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Right;
            panel6.Controls.Add(cmbStok);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(371, 7);
            panel6.Name = "panel6";
            panel6.Size = new Size(73, 52);
            panel6.TabIndex = 12;
            // 
            // cmbStok
            // 
            cmbStok.Font = new Font("Segoe UI", 7F);
            cmbStok.FormattingEnabled = true;
            cmbStok.Location = new Point(5, 27);
            cmbStok.Name = "cmbStok";
            cmbStok.RightToLeft = RightToLeft.No;
            cmbStok.Size = new Size(65, 20);
            cmbStok.TabIndex = 2;
            cmbStok.SelectedIndexChanged += cmbStok_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(3, 6);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 0;
            label4.Text = "Stoğa Göre";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Right;
            panel7.Controls.Add(cmbDurum);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(281, 7);
            panel7.Name = "panel7";
            panel7.Size = new Size(84, 52);
            panel7.TabIndex = 13;
            // 
            // cmbDurum
            // 
            cmbDurum.Font = new Font("Segoe UI", 8F);
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(3, 27);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.RightToLeft = RightToLeft.No;
            cmbDurum.Size = new Size(78, 21);
            cmbDurum.TabIndex = 2;
            cmbDurum.SelectedIndexChanged += cmbDurum_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(3, 6);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 0;
            label5.Text = "Duruma Göre";
            // 
            // panel5
            // 
            panel5.Controls.Add(rdbZA);
            panel5.Controls.Add(rdbAZ);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(201, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(74, 61);
            panel5.TabIndex = 11;
            // 
            // rdbZA
            // 
            rdbZA.AutoSize = true;
            rdbZA.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdbZA.ForeColor = SystemColors.ButtonHighlight;
            rdbZA.Location = new Point(14, 42);
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
            rdbAZ.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rdbAZ.ForeColor = SystemColors.ButtonHighlight;
            rdbAZ.Location = new Point(14, 24);
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
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 6);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 0;
            label3.Text = "Adına Göre";
            // 
            // btnClearFilter
            // 
            btnClearFilter.Anchor = AnchorStyles.Right;
            btnClearFilter.Location = new Point(138, 12);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(57, 43);
            btnClearFilter.TabIndex = 14;
            btnClearFilter.Text = "Filtreleri Temizle";
            btnClearFilter.UseVisualStyleBackColor = true;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(pictureBox6);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(554, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 49);
            panel2.TabIndex = 15;
            panel2.Click += KategoriAc_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(35, 16);
            label9.Name = "label9";
            label9.Size = new Size(134, 17);
            label9.TabIndex = 5;
            label9.Text = "KATEGORİ İŞLEMLERİ";
            label9.Click += KategoriAc_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = Properties.Resources.open_in_new_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Dock = DockStyle.Left;
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(34, 47);
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            pictureBox6.Click += KategoriAc_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.FromArgb(254, 249, 242);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(0, 67);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1173, 366);
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
            // FrmBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1173, 433);
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
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private TextBox txtSearch;
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
        private Panel panel2;
        private Label label9;
        private PictureBox pictureBox6;
    }
}