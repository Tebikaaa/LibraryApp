namespace LibraryUI.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            panel6 = new Panel();
            label9 = new Label();
            pictureBox6 = new PictureBox();
            pnlContainer = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(120, 157, 188);
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(221, 680);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 58);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(80, 35);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 2;
            label2.Text = "UYGULAMASI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(80, 5);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 1;
            label1.Text = "KÜTÜPHANE";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 58);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += FrmMain_Load;
            pictureBox1.DoubleClick += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(3, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 60);
            panel1.TabIndex = 1;
            panel1.Click += AnasayfaAc_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(76, 16);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 2;
            label3.Text = "ANASAYFA";
            label3.Click += AnasayfaAc_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.dashboard_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 58);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += AnasayfaAc_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox3);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(3, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(215, 60);
            panel3.TabIndex = 2;
            panel3.Click += UyeFormAc_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI Semibold", 13.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(66, 18);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 3;
            label4.Text = "ÜYE İŞLEMLERİ";
            label4.Click += UyeFormAc_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.person_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 58);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += UyeFormAc_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pictureBox4);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(3, 199);
            panel4.Name = "panel4";
            panel4.Size = new Size(215, 60);
            panel4.TabIndex = 2;
            panel4.Click += KitapSayfaAc_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(66, 20);
            label5.Name = "label5";
            label5.Size = new Size(139, 23);
            label5.TabIndex = 4;
            label5.Text = "KİTAP İŞLEMLERİ";
            label5.Click += KitapSayfaAc_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.book_2_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 58);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Click += KitapSayfaAc_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(pictureBox5);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(3, 265);
            panel5.Name = "panel5";
            panel5.Size = new Size(215, 60);
            panel5.TabIndex = 3;
            panel5.Click += TeslimFormAc_Click;
            // 
            // label8
            // 
            label8.AllowDrop = true;
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(66, 30);
            label8.Name = "label8";
            label8.Size = new Size(124, 20);
            label8.TabIndex = 7;
            label8.Text = "ETME İŞLEMLERİ ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += TeslimFormAc_Click;
            // 
            // label7
            // 
            label7.AllowDrop = true;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(123, 10);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 6;
            label7.Text = "ALMA VE ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += TeslimFormAc_Click;
            // 
            // label6
            // 
            label6.AllowDrop = true;
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(66, 10);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 5;
            label6.Text = "TESLİM";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += TeslimFormAc_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = Properties.Resources.package_2_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Dock = DockStyle.Left;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(51, 58);
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            pictureBox5.Click += TeslimFormAc_Click;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label9);
            panel6.Controls.Add(pictureBox6);
            panel6.Cursor = Cursors.Hand;
            panel6.Location = new Point(3, 331);
            panel6.Name = "panel6";
            panel6.Size = new Size(215, 60);
            panel6.TabIndex = 3;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(69, 19);
            label9.Name = "label9";
            label9.Size = new Size(130, 20);
            label9.TabIndex = 5;
            label9.Text = "RAPOR İŞLEMLERİ";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = Properties.Resources.contract_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Dock = DockStyle.Left;
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(51, 58);
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // pnlContainer
            // 
            pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(221, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1054, 680);
            pnlContainer.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 680);
            Controls.Add(pnlContainer);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "Kütüphane Uygulaması";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel pnlContainer;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label9;
    }
}