namespace LibraryUI.Forms
{
    partial class FrmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategory));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnYenile = new Button();
            btnNew = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            lblSonuc = new Label();
            panel2 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 67);
            panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 130, 130);
            flowLayoutPanel1.Controls.Add(btnYenile);
            flowLayoutPanel1.Controls.Add(btnNew);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtSearch);
            flowLayoutPanel1.Controls.Add(lblSonuc);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(815, 67);
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
            btnYenile.Location = new Point(776, 18);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(36, 34);
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
            btnNew.Location = new Point(734, 18);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(36, 34);
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
            label1.Location = new Point(595, 25);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 5;
            label1.Text = "Kategori İşlemleri";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(428, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Kategoriler için arayın";
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.Size = new Size(161, 25);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSonuc
            // 
            lblSonuc.Anchor = AnchorStyles.Right;
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblSonuc.ForeColor = SystemColors.ButtonHighlight;
            lblSonuc.Location = new Point(343, 26);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.RightToLeft = RightToLeft.No;
            lblSonuc.Size = new Size(79, 17);
            lblSonuc.TabIndex = 0;
            lblSonuc.Text = "label Sonuc";
            lblSonuc.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(137, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 64);
            panel2.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.FromArgb(254, 249, 242);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 67);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(815, 432);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // FrmCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 499);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCategory";
            Text = "Kategori Formu";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnYenile;
        private Button btnNew;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox txtSearch;
        private Label lblSonuc;
        private Panel panel2;
    }
}