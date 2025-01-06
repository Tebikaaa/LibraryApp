namespace LibraryUI.Forms.UserControls
{
    partial class RaporCard
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
            listBoxRapor = new ListBox();
            btnDetay = new Button();
            btnSil = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label1 = new Label();
            txtTarih = new TextBox();
            toolTip1 = new ToolTip(components);
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblId);
            flowLayoutPanel2.Controls.Add(txtId);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(115, 76);
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
            flowLayoutPanel3.Controls.Add(listBoxRapor);
            flowLayoutPanel3.Location = new Point(124, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(298, 76);
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
            lblKitapAdi.Size = new Size(72, 70);
            lblKitapAdi.TabIndex = 13;
            lblKitapAdi.Text = "Rapor";
            lblKitapAdi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBoxRapor
            // 
            listBoxRapor.FormattingEnabled = true;
            listBoxRapor.ItemHeight = 15;
            listBoxRapor.Location = new Point(81, 3);
            listBoxRapor.Name = "listBoxRapor";
            listBoxRapor.Size = new Size(198, 64);
            listBoxRapor.TabIndex = 14;
            // 
            // btnDetay
            // 
            btnDetay.Anchor = AnchorStyles.Right;
            btnDetay.BackColor = Color.FromArgb(201, 233, 210);
            btnDetay.BackgroundImage = Properties.Resources.details;
            btnDetay.BackgroundImageLayout = ImageLayout.Zoom;
            btnDetay.FlatStyle = FlatStyle.Popup;
            btnDetay.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetay.Location = new Point(749, 8);
            btnDetay.Name = "btnDetay";
            btnDetay.Size = new Size(60, 61);
            btnDetay.TabIndex = 18;
            btnDetay.TextAlign = ContentAlignment.MiddleRight;
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
            btnSil.Location = new Point(682, 8);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(60, 61);
            btnSil.TabIndex = 15;
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(201, 233, 210);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(620, 82);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label1);
            flowLayoutPanel4.Controls.Add(txtTarih);
            flowLayoutPanel4.Location = new Point(428, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(177, 76);
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
            label1.Size = new Size(67, 30);
            label1.TabIndex = 13;
            label1.Text = "Tarihi";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTarih
            // 
            txtTarih.Font = new Font("Segoe UI", 10F);
            txtTarih.Location = new Point(3, 33);
            txtTarih.Name = "txtTarih";
            txtTarih.ReadOnly = true;
            txtTarih.Size = new Size(164, 25);
            txtTarih.TabIndex = 17;
            txtTarih.Text = "5";
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.FromArgb(120, 157, 188);
            toolTip1.ForeColor = SystemColors.HighlightText;
            toolTip1.ShowAlways = true;
            // 
            // RaporCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 233, 210);
            Controls.Add(btnDetay);
            Controls.Add(btnSil);
            Controls.Add(flowLayoutPanel1);
            Name = "RaporCard";
            Size = new Size(836, 82);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblId;
        private TextBox txtId;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label lblKitapAdi;
        private ListBox listBoxRapor;
        private Button btnDetay;
        private Button btnSil;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolTip toolTip1;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label1;
        private TextBox txtTarih;
    }
}
