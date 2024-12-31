namespace LibraryUI.Forms.UserControls
{
    partial class KategoriCard
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
            txtId = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            lblKitapAdi = new Label();
            txtKategoriAdi = new TextBox();
            btnUpdate = new Button();
            btnSil = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDetay = new Button();
            toolTip1 = new ToolTip(components);
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblId);
            flowLayoutPanel2.Controls.Add(txtId);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(115, 66);
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
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(3, 33);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(104, 25);
            txtId.TabIndex = 16;
            txtId.Text = "5";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(lblKitapAdi);
            flowLayoutPanel3.Controls.Add(txtKategoriAdi);
            flowLayoutPanel3.Location = new Point(124, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(215, 66);
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
            lblKitapAdi.Size = new Size(47, 30);
            lblKitapAdi.TabIndex = 13;
            lblKitapAdi.Text = "Adı";
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Font = new Font("Segoe UI", 10F);
            txtKategoriAdi.Location = new Point(3, 33);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.ReadOnly = true;
            txtKategoriAdi.Size = new Size(204, 25);
            txtKategoriAdi.TabIndex = 14;
            txtKategoriAdi.Text = "Kitap";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(201, 233, 210);
            btnUpdate.BackgroundImage = Properties.Resources.edit_24dp_F19E39_FILL0_wght400_GRAD0_opsz24;
            btnUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(442, 3);
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
            btnSil.Location = new Point(512, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(60, 61);
            btnSil.TabIndex = 11;
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(201, 233, 210);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(359, 72);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // btnDetay
            // 
            btnDetay.Anchor = AnchorStyles.Right;
            btnDetay.BackColor = Color.FromArgb(201, 233, 210);
            btnDetay.BackgroundImage = Properties.Resources.details;
            btnDetay.BackgroundImageLayout = ImageLayout.Zoom;
            btnDetay.FlatStyle = FlatStyle.Popup;
            btnDetay.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetay.Location = new Point(579, 3);
            btnDetay.Name = "btnDetay";
            btnDetay.Size = new Size(60, 61);
            btnDetay.TabIndex = 14;
            btnDetay.TextAlign = ContentAlignment.MiddleRight;
            btnDetay.UseVisualStyleBackColor = false;
            btnDetay.Click += btnDetay_Click_1;
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.FromArgb(120, 157, 188);
            toolTip1.ForeColor = SystemColors.HighlightText;
            toolTip1.ShowAlways = true;
            // 
            // KategoriCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 233, 210);
            Controls.Add(btnDetay);
            Controls.Add(btnUpdate);
            Controls.Add(btnSil);
            Controls.Add(flowLayoutPanel1);
            Name = "KategoriCard";
            Size = new Size(693, 72);
            Load += KategoriCard_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblId;
        private TextBox txtId;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label lblKitapAdi;
        private TextBox txtKategoriAdi;
        private Button btnUpdate;
        private Button btnSil;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDetay;
        private ToolTip toolTip1;
    }
}
