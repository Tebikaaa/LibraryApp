namespace LibraryUI.Forms.SubForms.Rapor
{
    partial class FrmRaporDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporDetail));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            lblNumara = new Label();
            label2 = new Label();
            panel1 = new Panel();
            listBoxRapor = new ListBox();
            label1 = new Label();
            panel3 = new Panel();
            lblTarih = new Label();
            label4 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(355, 344);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblNumara);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(345, 54);
            panel2.TabIndex = 7;
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Font = new Font("Segoe UI", 16F);
            lblNumara.Location = new Point(178, 16);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(25, 30);
            lblNumara.TabIndex = 5;
            lblNumara.Text = "5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(14, 20);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 4;
            label2.Text = "Rapor Numarası :";
            // 
            // panel1
            // 
            panel1.Controls.Add(listBoxRapor);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 213);
            panel1.TabIndex = 6;
            // 
            // listBoxRapor
            // 
            listBoxRapor.FormattingEnabled = true;
            listBoxRapor.ItemHeight = 15;
            listBoxRapor.Location = new Point(9, 42);
            listBoxRapor.Name = "listBoxRapor";
            listBoxRapor.Size = new Size(331, 154);
            listBoxRapor.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 7;
            label1.Text = "Rapor AÇıklaması :";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTarih);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(3, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(345, 54);
            panel3.TabIndex = 8;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Segoe UI", 16F);
            lblTarih.Location = new Point(177, 16);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(25, 30);
            lblTarih.TabIndex = 5;
            lblTarih.Text = "5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(49, 16);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 4;
            label4.Text = "Rapor Tarihi :";
            // 
            // FrmRaporDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 344);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRaporDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rapor Detay Formu";
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label lblNumara;
        private Label label2;
        private Panel panel1;
        private ListBox listBoxRapor;
        private Label label1;
        private Panel panel3;
        private Label lblTarih;
        private Label label4;
    }
}