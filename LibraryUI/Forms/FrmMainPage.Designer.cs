namespace LibraryUI.Forms
{
    partial class FrmMainPage
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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnYenile = new Button();
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            listBoxRaporlar = new ListBox();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel11 = new FlowLayoutPanel();
            label19 = new Label();
            lblKitapKurdu = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label12 = new Label();
            lblEnCokOkunanKitap = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label4 = new Label();
            lblCanliSaat = new Label();
            flowLayoutPanel9 = new FlowLayoutPanel();
            label17 = new Label();
            lblEnCokUyarilanUye = new Label();
            flowLayoutPanel10 = new FlowLayoutPanel();
            label13 = new Label();
            lblGecikme = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label9 = new Label();
            lblTeslimEdilmeyenKitapSayisi = new Label();
            flowLayoutPanel8 = new FlowLayoutPanel();
            label7 = new Label();
            lblMevcutKitapSayisi = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            label5 = new Label();
            lblUyeSayisi = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label3 = new Label();
            lblKitapSayisi = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label11 = new Label();
            lblEnCokOkunanKategori = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel11.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            flowLayoutPanel10.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1495, 67);
            panel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 130, 130);
            flowLayoutPanel1.Controls.Add(btnYenile);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(1495, 67);
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
            btnYenile.Location = new Point(1456, 16);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(36, 34);
            btnYenile.TabIndex = 3;
            btnYenile.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1359, 21);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 5;
            label1.Text = "Anasayfa";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Location = new Point(1331, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(22, 61);
            panel2.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(listBoxRaporlar, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 67);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1495, 619);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // listBoxRaporlar
            // 
            listBoxRaporlar.Dock = DockStyle.Fill;
            listBoxRaporlar.Font = new Font("Segoe UI", 15F);
            listBoxRaporlar.FormattingEnabled = true;
            listBoxRaporlar.ItemHeight = 28;
            listBoxRaporlar.Location = new Point(3, 166);
            listBoxRaporlar.Name = "listBoxRaporlar";
            listBoxRaporlar.Size = new Size(1489, 450);
            listBoxRaporlar.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F);
            label2.Location = new Point(675, 132);
            label2.Name = "label2";
            label2.Size = new Size(145, 31);
            label2.TabIndex = 1;
            label2.Text = "Son Raporlar";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.ColumnCount = 13;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(flowLayoutPanel11, 10, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 6, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel3, 11, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel9, 9, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel10, 1, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel5, 5, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel8, 4, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel7, 2, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel6, 3, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel4, 7, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1489, 126);
            tableLayoutPanel2.TabIndex = 2;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.BackColor = Color.Violet;
            flowLayoutPanel11.Controls.Add(label19);
            flowLayoutPanel11.Controls.Add(lblKitapKurdu);
            flowLayoutPanel11.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel11.Location = new Point(1104, 3);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Size = new Size(132, 120);
            flowLayoutPanel11.TabIndex = 14;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label19.ForeColor = SystemColors.ButtonHighlight;
            label19.ImageAlign = ContentAlignment.TopCenter;
            label19.Location = new Point(3, 0);
            label19.Name = "label19";
            label19.Size = new Size(117, 25);
            label19.TabIndex = 8;
            label19.Text = "Kitap Kurdu";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKitapKurdu
            // 
            lblKitapKurdu.Anchor = AnchorStyles.Top;
            lblKitapKurdu.AutoSize = true;
            lblKitapKurdu.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            lblKitapKurdu.ForeColor = SystemColors.ButtonHighlight;
            lblKitapKurdu.Location = new Point(28, 25);
            lblKitapKurdu.Name = "lblKitapKurdu";
            lblKitapKurdu.Size = new Size(67, 25);
            lblKitapKurdu.TabIndex = 9;
            lblKitapKurdu.Text = "Kerem";
            lblKitapKurdu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(128, 128, 255);
            flowLayoutPanel2.Controls.Add(label12);
            flowLayoutPanel2.Controls.Add(lblEnCokOkunanKitap);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(704, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(120, 120);
            flowLayoutPanel2.TabIndex = 11;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.ImageAlign = ContentAlignment.TopCenter;
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(113, 42);
            label12.TabIndex = 8;
            label12.Text = "En Çok Okunan Kitap ";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEnCokOkunanKitap
            // 
            lblEnCokOkunanKitap.Anchor = AnchorStyles.Top;
            lblEnCokOkunanKitap.AutoSize = true;
            lblEnCokOkunanKitap.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            lblEnCokOkunanKitap.ForeColor = SystemColors.ButtonHighlight;
            lblEnCokOkunanKitap.Location = new Point(22, 42);
            lblEnCokOkunanKitap.Name = "lblEnCokOkunanKitap";
            lblEnCokOkunanKitap.Size = new Size(74, 25);
            lblEnCokOkunanKitap.TabIndex = 9;
            lblEnCokOkunanKitap.Text = "Utopya";
            lblEnCokOkunanKitap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.SteelBlue;
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(lblCanliSaat);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(1242, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(129, 120);
            flowLayoutPanel3.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 17F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 31);
            label4.TabIndex = 8;
            label4.Text = "Saat";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCanliSaat
            // 
            lblCanliSaat.AutoSize = true;
            lblCanliSaat.Dock = DockStyle.Fill;
            lblCanliSaat.Font = new Font("Segoe UI", 16.25F, FontStyle.Bold);
            lblCanliSaat.ForeColor = SystemColors.ButtonHighlight;
            lblCanliSaat.Location = new Point(3, 31);
            lblCanliSaat.Name = "lblCanliSaat";
            lblCanliSaat.Size = new Size(80, 30);
            lblCanliSaat.TabIndex = 9;
            lblCanliSaat.Text = "Kerem";
            lblCanliSaat.TextAlign = ContentAlignment.BottomRight;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.BackColor = Color.Red;
            flowLayoutPanel9.Controls.Add(label17);
            flowLayoutPanel9.Controls.Add(lblEnCokUyarilanUye);
            flowLayoutPanel9.Dock = DockStyle.Fill;
            flowLayoutPanel9.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel9.Location = new Point(967, 3);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(131, 120);
            flowLayoutPanel9.TabIndex = 13;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            label17.ForeColor = SystemColors.ButtonHighlight;
            label17.ImageAlign = ContentAlignment.TopCenter;
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(124, 50);
            label17.TabIndex = 8;
            label17.Text = "En Çok Uyarılan Üye";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEnCokUyarilanUye
            // 
            lblEnCokUyarilanUye.Anchor = AnchorStyles.Top;
            lblEnCokUyarilanUye.AutoSize = true;
            lblEnCokUyarilanUye.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            lblEnCokUyarilanUye.ForeColor = SystemColors.ButtonHighlight;
            lblEnCokUyarilanUye.Location = new Point(29, 50);
            lblEnCokUyarilanUye.Name = "lblEnCokUyarilanUye";
            lblEnCokUyarilanUye.Size = new Size(72, 25);
            lblEnCokUyarilanUye.TabIndex = 9;
            lblEnCokUyarilanUye.Text = "Roman";
            lblEnCokUyarilanUye.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.BackColor = Color.Red;
            flowLayoutPanel10.Controls.Add(label13);
            flowLayoutPanel10.Controls.Add(lblGecikme);
            flowLayoutPanel10.Dock = DockStyle.Fill;
            flowLayoutPanel10.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel10.Location = new Point(3, 3);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(141, 120);
            flowLayoutPanel10.TabIndex = 10;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.ImageAlign = ContentAlignment.TopCenter;
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(123, 60);
            label13.TabIndex = 8;
            label13.Text = "Geciken Kitap sayısı";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGecikme
            // 
            lblGecikme.Anchor = AnchorStyles.Top;
            lblGecikme.AutoSize = true;
            lblGecikme.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            lblGecikme.ForeColor = SystemColors.ButtonHighlight;
            lblGecikme.Location = new Point(38, 60);
            lblGecikme.Name = "lblGecikme";
            lblGecikme.Size = new Size(52, 25);
            lblGecikme.TabIndex = 9;
            lblGecikme.Text = "2000";
            lblGecikme.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BackColor = Color.FromArgb(255, 128, 0);
            flowLayoutPanel5.Controls.Add(label9);
            flowLayoutPanel5.Controls.Add(lblTeslimEdilmeyenKitapSayisi);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(562, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(136, 120);
            flowLayoutPanel5.TabIndex = 5;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.ImageAlign = ContentAlignment.TopCenter;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(130, 40);
            label9.TabIndex = 6;
            label9.Text = "Teslim Edilmeyen Kitap sayısı";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTeslimEdilmeyenKitapSayisi
            // 
            lblTeslimEdilmeyenKitapSayisi.Anchor = AnchorStyles.Top;
            lblTeslimEdilmeyenKitapSayisi.AutoSize = true;
            lblTeslimEdilmeyenKitapSayisi.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            lblTeslimEdilmeyenKitapSayisi.ForeColor = SystemColors.ButtonHighlight;
            lblTeslimEdilmeyenKitapSayisi.Location = new Point(42, 40);
            lblTeslimEdilmeyenKitapSayisi.Name = "lblTeslimEdilmeyenKitapSayisi";
            lblTeslimEdilmeyenKitapSayisi.Size = new Size(52, 25);
            lblTeslimEdilmeyenKitapSayisi.TabIndex = 7;
            lblTeslimEdilmeyenKitapSayisi.Text = "2000";
            lblTeslimEdilmeyenKitapSayisi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.BackColor = Color.FromArgb(128, 128, 255);
            flowLayoutPanel8.Controls.Add(label7);
            flowLayoutPanel8.Controls.Add(lblMevcutKitapSayisi);
            flowLayoutPanel8.Dock = DockStyle.Fill;
            flowLayoutPanel8.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel8.Location = new Point(433, 3);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(123, 120);
            flowLayoutPanel8.TabIndex = 6;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(112, 50);
            label7.TabIndex = 4;
            label7.Text = "Mevcut Kitap Sayısı";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMevcutKitapSayisi
            // 
            lblMevcutKitapSayisi.Anchor = AnchorStyles.Top;
            lblMevcutKitapSayisi.AutoSize = true;
            lblMevcutKitapSayisi.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            lblMevcutKitapSayisi.ForeColor = SystemColors.ButtonHighlight;
            lblMevcutKitapSayisi.Location = new Point(33, 50);
            lblMevcutKitapSayisi.Name = "lblMevcutKitapSayisi";
            lblMevcutKitapSayisi.Size = new Size(52, 25);
            lblMevcutKitapSayisi.TabIndex = 5;
            lblMevcutKitapSayisi.Text = "2000";
            lblMevcutKitapSayisi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.BackColor = Color.FromArgb(0, 192, 0);
            flowLayoutPanel7.Controls.Add(label5);
            flowLayoutPanel7.Controls.Add(lblUyeSayisi);
            flowLayoutPanel7.Dock = DockStyle.Fill;
            flowLayoutPanel7.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel7.Location = new Point(150, 3);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(143, 120);
            flowLayoutPanel7.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 60);
            label5.TabIndex = 2;
            label5.Text = "Toplam Üye Sayısı";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUyeSayisi
            // 
            lblUyeSayisi.Anchor = AnchorStyles.Top;
            lblUyeSayisi.AutoSize = true;
            lblUyeSayisi.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            lblUyeSayisi.ForeColor = SystemColors.ButtonHighlight;
            lblUyeSayisi.Location = new Point(41, 60);
            lblUyeSayisi.Name = "lblUyeSayisi";
            lblUyeSayisi.Size = new Size(52, 25);
            lblUyeSayisi.TabIndex = 3;
            lblUyeSayisi.Text = "2000";
            lblUyeSayisi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.BackColor = Color.FromArgb(255, 128, 128);
            flowLayoutPanel6.Controls.Add(label3);
            flowLayoutPanel6.Controls.Add(lblKitapSayisi);
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Location = new Point(299, 3);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(128, 120);
            flowLayoutPanel6.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 50);
            label3.TabIndex = 0;
            label3.Text = "Toplam Kitap Sayısı";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKitapSayisi
            // 
            lblKitapSayisi.Anchor = AnchorStyles.None;
            lblKitapSayisi.AutoSize = true;
            lblKitapSayisi.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            lblKitapSayisi.ForeColor = SystemColors.ButtonHighlight;
            lblKitapSayisi.Location = new Point(33, 50);
            lblKitapSayisi.Name = "lblKitapSayisi";
            lblKitapSayisi.Size = new Size(52, 25);
            lblKitapSayisi.TabIndex = 1;
            lblKitapSayisi.Text = "2000";
            lblKitapSayisi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.DarkCyan;
            flowLayoutPanel4.Controls.Add(label11);
            flowLayoutPanel4.Controls.Add(lblEnCokOkunanKategori);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(830, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(131, 120);
            flowLayoutPanel4.TabIndex = 4;
            flowLayoutPanel4.Paint += flowLayoutPanel4_Paint;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.ImageAlign = ContentAlignment.TopCenter;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(124, 42);
            label11.TabIndex = 8;
            label11.Text = "En Çok Okunan Kategori ";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEnCokOkunanKategori
            // 
            lblEnCokOkunanKategori.Anchor = AnchorStyles.None;
            lblEnCokOkunanKategori.AutoSize = true;
            lblEnCokOkunanKategori.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            lblEnCokOkunanKategori.ForeColor = SystemColors.ButtonHighlight;
            lblEnCokOkunanKategori.Location = new Point(29, 42);
            lblEnCokOkunanKategori.Name = "lblEnCokOkunanKategori";
            lblEnCokOkunanKategori.Size = new Size(72, 25);
            lblEnCokOkunanKategori.TabIndex = 9;
            lblEnCokOkunanKategori.Text = "Roman";
            lblEnCokOkunanKategori.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 249, 242);
            ClientSize = new Size(1495, 686);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMainPage";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel11.ResumeLayout(false);
            flowLayoutPanel11.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            flowLayoutPanel10.ResumeLayout(false);
            flowLayoutPanel10.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnYenile;
        private Label label1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listBoxRaporlar;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel10;
        private Label label13;
        private Label lblGecikme;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label11;
        private Label lblEnCokOkunanKategori;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label9;
        private Label lblTeslimEdilmeyenKitapSayisi;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label label7;
        private Label lblMevcutKitapSayisi;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label5;
        private Label lblUyeSayisi;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label3;
        private Label lblKitapSayisi;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label12;
        private Label lblEnCokOkunanKitap;
        private FlowLayoutPanel flowLayoutPanel11;
        private Label label19;
        private Label lblKitapKurdu;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label label17;
        private Label lblEnCokUyarilanUye;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label4;
        private Label lblCanliSaat;
    }
}