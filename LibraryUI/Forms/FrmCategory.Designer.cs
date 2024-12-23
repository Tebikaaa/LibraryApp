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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnYenile = new Button();
            btnNew = new Button();
            label1 = new Label();
            panel2 = new Panel();
            txtSearch = new TextBox();
            panel3 = new Panel();
            lblSonuc = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 67);
            panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnYenile);
            flowLayoutPanel1.Controls.Add(btnNew);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(1101, 67);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnYenile
            // 
            btnYenile.BackgroundImage = Properties.Resources.guncelle1;
            btnYenile.BackgroundImageLayout = ImageLayout.Zoom;
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnYenile.FlatStyle = FlatStyle.Popup;
            btnYenile.Location = new Point(1056, 3);
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
            btnNew.Location = new Point(1007, 3);
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
            label1.Location = new Point(650, 0);
            label1.Name = "label1";
            label1.Size = new Size(351, 59);
            label1.TabIndex = 5;
            label1.Text = "Kategori İşlemleri";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtSearch);
            panel2.Location = new Point(339, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 61);
            panel2.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18F);
            txtSearch.Location = new Point(0, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Kategoriler için arayın";
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.Size = new Size(305, 39);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblSonuc);
            panel3.Location = new Point(89, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(244, 61);
            panel3.TabIndex = 8;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 18F);
            lblSonuc.Location = new Point(3, 16);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.RightToLeft = RightToLeft.No;
            lblSonuc.Size = new Size(138, 32);
            lblSonuc.TabIndex = 0;
            lblSonuc.Text = "label Sonuc";
            lblSonuc.Click += label2_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.FromArgb(255, 192, 192);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 67);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1101, 432);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // FrmCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 499);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCategory";
            Text = "FrmCategory";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnYenile;
        private Button btnNew;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private TextBox txtSearch;
        private Panel panel3;
        private Label lblSonuc;
    }
}