namespace LibraryUI.Forms.UserControls
{
    partial class OduncCard
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
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblId = new Label();
            txtNumara = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            lblKitapAdi = new Label();
            txtKitapAdi = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label1 = new Label();
            txtUyeAdi = new TextBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label2 = new Label();
            txtKalanGun = new TextBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label3 = new Label();
            txtDurum = new TextBox();
            btnUpdate = new Button();
            btnDetay = new Button();
            btnSil = new Button();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblId);
            flowLayoutPanel2.Controls.Add(txtNumara);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(115, 71);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 16F);
            lblId.ForeColor = SystemColors.HighlightText;
            lblId.Location = new Point(3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(104, 30);
            lblId.TabIndex = 19;
            lblId.Text = "Numarası";
            // 
            // txtNumara
            // 
            txtNumara.Font = new Font("Segoe UI", 12F);
            txtNumara.Location = new Point(3, 33);
            txtNumara.Name = "txtNumara";
            txtNumara.ReadOnly = true;
            txtNumara.Size = new Size(104, 29);
            txtNumara.TabIndex = 16;
            txtNumara.Text = "5";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(lblKitapAdi);
            flowLayoutPanel3.Controls.Add(txtKitapAdi);
            flowLayoutPanel3.Location = new Point(124, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(215, 71);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // lblKitapAdi
            // 
            lblKitapAdi.AutoSize = true;
            lblKitapAdi.Dock = DockStyle.Fill;
            lblKitapAdi.Font = new Font("Segoe UI", 16F);
            lblKitapAdi.ForeColor = SystemColors.ButtonHighlight;
            lblKitapAdi.Location = new Point(3, 0);
            lblKitapAdi.Name = "lblKitapAdi";
            lblKitapAdi.Size = new Size(100, 30);
            lblKitapAdi.TabIndex = 13;
            lblKitapAdi.Text = "Kitap Adı";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Dock = DockStyle.Fill;
            txtKitapAdi.Font = new Font("Segoe UI", 12F);
            txtKitapAdi.Location = new Point(3, 33);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.ReadOnly = true;
            txtKitapAdi.Size = new Size(204, 29);
            txtKitapAdi.TabIndex = 14;
            txtKitapAdi.Text = "Kitap";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DodgerBlue;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1338, 85);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label1);
            flowLayoutPanel4.Controls.Add(txtUyeAdi);
            flowLayoutPanel4.Location = new Point(345, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(215, 71);
            flowLayoutPanel4.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 13;
            label1.Text = "Üye Adı";
            // 
            // txtUyeAdi
            // 
            txtUyeAdi.Dock = DockStyle.Fill;
            txtUyeAdi.Font = new Font("Segoe UI", 12F);
            txtUyeAdi.Location = new Point(3, 33);
            txtUyeAdi.Name = "txtUyeAdi";
            txtUyeAdi.ReadOnly = true;
            txtUyeAdi.Size = new Size(204, 29);
            txtUyeAdi.TabIndex = 14;
            txtUyeAdi.Text = "Kitap";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label2);
            flowLayoutPanel5.Controls.Add(txtKalanGun);
            flowLayoutPanel5.Location = new Point(566, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(215, 71);
            flowLayoutPanel5.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 13;
            label2.Text = "Kalan Gün";
            // 
            // txtKalanGun
            // 
            txtKalanGun.Dock = DockStyle.Fill;
            txtKalanGun.Font = new Font("Segoe UI", 12F);
            txtKalanGun.Location = new Point(3, 33);
            txtKalanGun.Name = "txtKalanGun";
            txtKalanGun.ReadOnly = true;
            txtKalanGun.Size = new Size(204, 29);
            txtKalanGun.TabIndex = 14;
            txtKalanGun.Text = "Kitap";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(label3);
            flowLayoutPanel6.Controls.Add(txtDurum);
            flowLayoutPanel6.Location = new Point(787, 3);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(215, 71);
            flowLayoutPanel6.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 16F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 30);
            label3.TabIndex = 13;
            label3.Text = "Durumu";
            // 
            // txtDurum
            // 
            txtDurum.Dock = DockStyle.Fill;
            txtDurum.Font = new Font("Segoe UI", 12F);
            txtDurum.Location = new Point(3, 33);
            txtDurum.Name = "txtDurum";
            txtDurum.ReadOnly = true;
            txtDurum.Size = new Size(204, 29);
            txtDurum.TabIndex = 14;
            txtDurum.Text = "Kitap";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.BackgroundImage = Properties.Resources.guncelle;
            btnUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            btnUpdate.Dock = DockStyle.Right;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(1149, 0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(63, 85);
            btnUpdate.TabIndex = 26;
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDetay
            // 
            btnDetay.BackColor = Color.DodgerBlue;
            btnDetay.BackgroundImage = Properties.Resources.details;
            btnDetay.BackgroundImageLayout = ImageLayout.Zoom;
            btnDetay.Dock = DockStyle.Right;
            btnDetay.FlatStyle = FlatStyle.Popup;
            btnDetay.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetay.Location = new Point(1212, 0);
            btnDetay.Name = "btnDetay";
            btnDetay.Size = new Size(65, 85);
            btnDetay.TabIndex = 27;
            btnDetay.TextAlign = ContentAlignment.MiddleRight;
            btnDetay.UseVisualStyleBackColor = false;
            btnDetay.Click += btnDetay_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DodgerBlue;
            btnSil.BackgroundImage = Properties.Resources.delete;
            btnSil.BackgroundImageLayout = ImageLayout.Zoom;
            btnSil.Dock = DockStyle.Right;
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.Location = new Point(1277, 0);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(61, 85);
            btnSil.TabIndex = 25;
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // OduncCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUpdate);
            Controls.Add(btnDetay);
            Controls.Add(btnSil);
            Controls.Add(flowLayoutPanel1);
            Name = "OduncCard";
            Size = new Size(1338, 85);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblId;
        private TextBox txtNumara;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label lblKitapAdi;
        private TextBox txtKitapAdi;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label1;
        private TextBox txtUyeAdi;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label2;
        private TextBox txtKalanGun;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label3;
        private TextBox txtDurum;
        private Button btnUpdate;
        private Button btnDetay;
        private Button btnSil;
    }
}
