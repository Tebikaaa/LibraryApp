namespace LibraryUI.Forms.SubForms.Category
{
    partial class FrmCategoryDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoryDetails));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            lblNumara = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lblKategoriAdi = new Label();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(351, 123);
            flowLayoutPanel1.TabIndex = 0;
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
            label2.Location = new Point(3, 20);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 4;
            label2.Text = "Kategori Numarası :";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblKategoriAdi);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 52);
            panel1.TabIndex = 6;
            // 
            // lblKategoriAdi
            // 
            lblKategoriAdi.AutoSize = true;
            lblKategoriAdi.Font = new Font("Segoe UI", 16F);
            lblKategoriAdi.Location = new Point(129, 10);
            lblKategoriAdi.Name = "lblKategoriAdi";
            lblKategoriAdi.Size = new Size(80, 30);
            lblKategoriAdi.TabIndex = 8;
            lblKategoriAdi.Text = "Roman";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 7;
            label1.Text = "Kategori Adı :";
            // 
            // FrmCategoryDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 123);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCategoryDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategori Detay Formu";
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label lblNumara;
        private Label label2;
        private Panel panel1;
        private Label lblKategoriAdi;
        private Label label1;
    }
}