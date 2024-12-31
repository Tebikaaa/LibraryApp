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
            components = new System.ComponentModel.Container();
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
            toolTip1 = new ToolTip(components);
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
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(115, 62);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
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
            txtNumara.Text = "5";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(lblKitapAdi);
            flowLayoutPanel3.Controls.Add(txtKitapAdi);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(124, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(144, 62);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // lblKitapAdi
            // 
            lblKitapAdi.AutoSize = true;
            lblKitapAdi.Dock = DockStyle.Fill;
            lblKitapAdi.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblKitapAdi.ForeColor = SystemColors.ButtonHighlight;
            lblKitapAdi.Location = new Point(3, 0);
            lblKitapAdi.Name = "lblKitapAdi";
            lblKitapAdi.Size = new Size(132, 30);
            lblKitapAdi.TabIndex = 13;
            lblKitapAdi.Text = "Kitap Adı";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Font = new Font("Segoe UI", 10F);
            txtKitapAdi.Location = new Point(3, 33);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.ReadOnly = true;
            txtKitapAdi.Size = new Size(132, 25);
            txtKitapAdi.TabIndex = 14;
            txtKitapAdi.Text = "Kitap";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(201, 233, 210);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(764, 70);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label1);
            flowLayoutPanel4.Controls.Add(txtUyeAdi);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(274, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(129, 64);
            flowLayoutPanel4.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 13;
            label1.Text = "Üye Adı";
            // 
            // txtUyeAdi
            // 
            txtUyeAdi.Font = new Font("Segoe UI", 10F);
            txtUyeAdi.Location = new Point(3, 33);
            txtUyeAdi.Name = "txtUyeAdi";
            txtUyeAdi.ReadOnly = true;
            txtUyeAdi.Size = new Size(119, 25);
            txtUyeAdi.TabIndex = 14;
            txtUyeAdi.Text = "Kitap";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label2);
            flowLayoutPanel5.Controls.Add(txtKalanGun);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(409, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(132, 67);
            flowLayoutPanel5.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 13;
            label2.Text = "Kalan Gün";
            // 
            // txtKalanGun
            // 
            txtKalanGun.Font = new Font("Segoe UI", 10F);
            txtKalanGun.Location = new Point(3, 31);
            txtKalanGun.Margin = new Padding(3, 3, 10, 10);
            txtKalanGun.Name = "txtKalanGun";
            txtKalanGun.ReadOnly = true;
            txtKalanGun.Size = new Size(106, 25);
            txtKalanGun.TabIndex = 14;
            txtKalanGun.Text = "Kitap";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(label3);
            flowLayoutPanel6.Controls.Add(txtDurum);
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Location = new Point(547, 3);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(100, 64);
            flowLayoutPanel6.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 30);
            label3.TabIndex = 13;
            label3.Text = "Durumu";
            // 
            // txtDurum
            // 
            txtDurum.Dock = DockStyle.Fill;
            txtDurum.Font = new Font("Segoe UI", 10F);
            txtDurum.Location = new Point(3, 33);
            txtDurum.Name = "txtDurum";
            txtDurum.ReadOnly = true;
            txtDurum.Size = new Size(94, 25);
            txtDurum.TabIndex = 14;
            txtDurum.Text = "Kitap";
            // 
            // btnUpdate
            // 
            btnUpdate.AccessibleDescription = "Düzenle";
            btnUpdate.Anchor = AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(201, 233, 210);
            btnUpdate.BackgroundImage = Properties.Resources.edit_24dp_F19E39_FILL0_wght400_GRAD0_opsz24;
            btnUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(809, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(59, 58);
            btnUpdate.TabIndex = 26;
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnUpdate, "Kitabı Düzenle");
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDetay
            // 
            btnDetay.Anchor = AnchorStyles.Right;
            btnDetay.BackColor = Color.FromArgb(201, 233, 210);
            btnDetay.BackgroundImage = Properties.Resources.details;
            btnDetay.BackgroundImageLayout = ImageLayout.Zoom;
            btnDetay.FlatStyle = FlatStyle.Popup;
            btnDetay.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetay.Location = new Point(941, 4);
            btnDetay.Name = "btnDetay";
            btnDetay.Size = new Size(59, 59);
            btnDetay.TabIndex = 27;
            btnDetay.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnDetay, "Detayları Gör");
            btnDetay.UseVisualStyleBackColor = false;
            btnDetay.Click += btnDetay_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Right;
            btnSil.BackColor = Color.FromArgb(201, 233, 210);
            btnSil.BackgroundImage = Properties.Resources.delete_24dp_EA3323_FILL0_wght400_GRAD0_opsz24;
            btnSil.BackgroundImageLayout = ImageLayout.Zoom;
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.Location = new Point(874, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(61, 59);
            btnSil.TabIndex = 25;
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnSil, "Kitabı Sil");
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.FromArgb(120, 157, 188);
            toolTip1.ForeColor = SystemColors.HighlightText;
            toolTip1.ShowAlways = true;
            // 
            // OduncCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 233, 210);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnSil);
            Controls.Add(btnDetay);
            Controls.Add(btnUpdate);
            Name = "OduncCard";
            Size = new Size(1027, 70);
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
        private ToolTip toolTip1;
    }
}
