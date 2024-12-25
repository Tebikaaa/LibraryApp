namespace LibraryUI.Forms.UserControls
{
    partial class MemberCard
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
            txtAdSoyad = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label2 = new Label();
            txtEmail = new TextBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label1 = new Label();
            txtDurum = new TextBox();
            btnUpdate = new Button();
            btnSil = new Button();
            btnDetay = new Button();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblId);
            flowLayoutPanel2.Controls.Add(txtNumara);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(114, 71);
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
            txtNumara.Text = "1";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(lblKitapAdi);
            flowLayoutPanel3.Controls.Add(txtAdSoyad);
            flowLayoutPanel3.Location = new Point(123, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(148, 71);
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
            lblKitapAdi.Size = new Size(45, 30);
            lblKitapAdi.TabIndex = 13;
            lblKitapAdi.Text = "Adı";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Dock = DockStyle.Fill;
            txtAdSoyad.Font = new Font("Segoe UI", 12F);
            txtAdSoyad.Location = new Point(3, 33);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.ReadOnly = true;
            txtAdSoyad.Size = new Size(145, 29);
            txtAdSoyad.TabIndex = 14;
            txtAdSoyad.Text = "Kerem";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DodgerBlue;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(806, 80);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label2);
            flowLayoutPanel5.Controls.Add(txtEmail);
            flowLayoutPanel5.Location = new Point(277, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(293, 71);
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
            label2.Size = new Size(64, 30);
            label2.TabIndex = 13;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(3, 33);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(290, 29);
            txtEmail.TabIndex = 14;
            txtEmail.Text = "kerem@gmail.com";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label1);
            flowLayoutPanel4.Controls.Add(txtDurum);
            flowLayoutPanel4.Location = new Point(576, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(157, 71);
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
            label1.Size = new Size(91, 30);
            label1.TabIndex = 13;
            label1.Text = "Durumu";
            // 
            // txtDurum
            // 
            txtDurum.Dock = DockStyle.Fill;
            txtDurum.Font = new Font("Segoe UI", 12F);
            txtDurum.Location = new Point(3, 33);
            txtDurum.Name = "txtDurum";
            txtDurum.ReadOnly = true;
            txtDurum.Size = new Size(145, 29);
            txtDurum.TabIndex = 14;
            txtDurum.Text = "Aktif";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.BackgroundImage = Properties.Resources.guncelle;
            btnUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            btnUpdate.Dock = DockStyle.Right;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(806, 0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(64, 80);
            btnUpdate.TabIndex = 12;
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DodgerBlue;
            btnSil.BackgroundImage = Properties.Resources.delete;
            btnSil.BackgroundImageLayout = ImageLayout.Zoom;
            btnSil.Dock = DockStyle.Right;
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.Location = new Point(870, 0);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(61, 80);
            btnSil.TabIndex = 11;
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnDetay
            // 
            btnDetay.BackColor = Color.DodgerBlue;
            btnDetay.BackgroundImage = Properties.Resources.details;
            btnDetay.BackgroundImageLayout = ImageLayout.Zoom;
            btnDetay.Dock = DockStyle.Right;
            btnDetay.FlatStyle = FlatStyle.Popup;
            btnDetay.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetay.Location = new Point(931, 0);
            btnDetay.Name = "btnDetay";
            btnDetay.Size = new Size(61, 80);
            btnDetay.TabIndex = 10;
            btnDetay.TextAlign = ContentAlignment.MiddleRight;
            btnDetay.UseVisualStyleBackColor = false;
            btnDetay.Click += btnDetay_Click;
            // 
            // MemberCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnUpdate);
            Controls.Add(btnSil);
            Controls.Add(btnDetay);
            Name = "MemberCard";
            Size = new Size(992, 80);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblId;
        private TextBox txtNumara;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label lblKitapAdi;
        private TextBox txtAdSoyad;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label1;
        private TextBox txtDurum;
        private Button btnUpdate;
        private Button btnSil;
        private Button btnDetay;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label2;
        private TextBox txtEmail;
    }
}
