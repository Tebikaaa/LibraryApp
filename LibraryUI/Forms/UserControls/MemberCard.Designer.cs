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
            components = new System.ComponentModel.Container();
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
            toolTip1 = new ToolTip(components);
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
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(114, 71);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = SystemColors.HighlightText;
            lblId.Location = new Point(3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(107, 30);
            lblId.TabIndex = 19;
            lblId.Text = "Numarası";
            // 
            // txtNumara
            // 
            txtNumara.Font = new Font("Segoe UI", 10F);
            txtNumara.Location = new Point(3, 33);
            txtNumara.Name = "txtNumara";
            txtNumara.ReadOnly = true;
            txtNumara.Size = new Size(104, 25);
            txtNumara.TabIndex = 16;
            txtNumara.Text = "1";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(lblKitapAdi);
            flowLayoutPanel3.Controls.Add(txtAdSoyad);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(123, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(158, 71);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // lblKitapAdi
            // 
            lblKitapAdi.AutoSize = true;
            lblKitapAdi.Dock = DockStyle.Fill;
            lblKitapAdi.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKitapAdi.ForeColor = SystemColors.ButtonHighlight;
            lblKitapAdi.Location = new Point(3, 0);
            lblKitapAdi.Name = "lblKitapAdi";
            lblKitapAdi.Size = new Size(145, 30);
            lblKitapAdi.TabIndex = 13;
            lblKitapAdi.Text = "Adı";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Segoe UI", 10F);
            txtAdSoyad.Location = new Point(3, 33);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.ReadOnly = true;
            txtAdSoyad.Size = new Size(145, 25);
            txtAdSoyad.TabIndex = 14;
            txtAdSoyad.Text = "Kerem";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(201, 233, 210);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(758, 68);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label2);
            flowLayoutPanel5.Controls.Add(txtEmail);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(287, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(204, 71);
            flowLayoutPanel5.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 30);
            label2.TabIndex = 13;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(3, 33);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(191, 25);
            txtEmail.TabIndex = 14;
            txtEmail.Text = "kerem@gmail.com";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label1);
            flowLayoutPanel4.Controls.Add(txtDurum);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(497, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(102, 71);
            flowLayoutPanel4.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 13;
            label1.Text = "Durumu";
            // 
            // txtDurum
            // 
            txtDurum.Font = new Font("Segoe UI", 10F);
            txtDurum.Location = new Point(3, 33);
            txtDurum.Name = "txtDurum";
            txtDurum.ReadOnly = true;
            txtDurum.Size = new Size(91, 25);
            txtDurum.TabIndex = 14;
            txtDurum.Text = "Aktif";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(201, 233, 210);
            btnUpdate.BackgroundImage = Properties.Resources.edit_24dp_F19E39_FILL0_wght400_GRAD0_opsz24;
            btnUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(830, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(60, 61);
            btnUpdate.TabIndex = 12;
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Right;
            btnSil.BackColor = Color.FromArgb(201, 233, 210);
            btnSil.BackgroundImage = Properties.Resources.delete_24dp_EA3323_FILL0_wght400_GRAD0_opsz24;
            btnSil.BackgroundImageLayout = ImageLayout.Zoom;
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.Location = new Point(896, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(59, 61);
            btnSil.TabIndex = 11;
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnDetay
            // 
            btnDetay.Anchor = AnchorStyles.Right;
            btnDetay.BackColor = Color.FromArgb(201, 233, 210);
            btnDetay.BackgroundImage = Properties.Resources.details;
            btnDetay.BackgroundImageLayout = ImageLayout.Zoom;
            btnDetay.FlatStyle = FlatStyle.Popup;
            btnDetay.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetay.Location = new Point(961, 2);
            btnDetay.Name = "btnDetay";
            btnDetay.Size = new Size(57, 61);
            btnDetay.TabIndex = 10;
            btnDetay.TextAlign = ContentAlignment.MiddleRight;
            btnDetay.UseVisualStyleBackColor = false;
            btnDetay.Click += btnDetay_Click;
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.FromArgb(120, 157, 188);
            toolTip1.ForeColor = SystemColors.HighlightText;
            toolTip1.ShowAlways = true;
            // 
            // MemberCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 233, 210);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnUpdate);
            Controls.Add(btnSil);
            Controls.Add(btnDetay);
            Name = "MemberCard";
            Size = new Size(1046, 68);
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
        private ToolTip toolTip1;
    }
}
