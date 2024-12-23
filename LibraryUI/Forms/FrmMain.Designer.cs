namespace LibraryUI.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnKitap = new Button();
            button3 = new Button();
            btnUye = new Button();
            button2 = new Button();
            pnlContainer = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.IndianRed;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(btnKitap);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(btnUye);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(221, 450);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 83);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 17F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(74, 5);
            label2.Name = "label2";
            label2.Size = new Size(125, 31);
            label2.TabIndex = 2;
            label2.Text = "Kütüphane";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(74, 36);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 3;
            label3.Text = "Uygulaması";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(74, 55);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 1;
            label1.Text = "Hoşgeldiniz";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 83);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnKitap
            // 
            btnKitap.BackColor = Color.Transparent;
            btnKitap.Dock = DockStyle.Bottom;
            btnKitap.FlatStyle = FlatStyle.System;
            btnKitap.Font = new Font("Segoe UI", 18F);
            btnKitap.ForeColor = Color.FloralWhite;
            btnKitap.Location = new Point(3, 92);
            btnKitap.Name = "btnKitap";
            btnKitap.Size = new Size(215, 49);
            btnKitap.TabIndex = 4;
            btnKitap.Text = "Kitap İşlemleri";
            btnKitap.UseVisualStyleBackColor = false;
            btnKitap.Click += btnKitap_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Dock = DockStyle.Bottom;
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Segoe UI", 18F);
            button3.ForeColor = Color.FloralWhite;
            button3.Location = new Point(3, 147);
            button3.Name = "button3";
            button3.Size = new Size(215, 49);
            button3.TabIndex = 9;
            button3.Text = "Kategori İşlemleri";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnUye
            // 
            btnUye.BackColor = Color.Transparent;
            btnUye.Dock = DockStyle.Bottom;
            btnUye.FlatStyle = FlatStyle.System;
            btnUye.Font = new Font("Segoe UI", 18F);
            btnUye.ForeColor = Color.FloralWhite;
            btnUye.Location = new Point(3, 202);
            btnUye.Name = "btnUye";
            btnUye.Size = new Size(215, 49);
            btnUye.TabIndex = 11;
            btnUye.Text = "Üye İşlemleri";
            btnUye.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Bottom;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Segoe UI", 16F);
            button2.ForeColor = Color.FloralWhite;
            button2.Location = new Point(3, 257);
            button2.Name = "button2";
            button2.Size = new Size(215, 51);
            button2.TabIndex = 12;
            button2.Text = "Ödünç Alma İşlemleri";
            button2.UseVisualStyleBackColor = false;
            // 
            // pnlContainer
            // 
            pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(221, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(579, 450);
            pnlContainer.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContainer);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "FrmMain";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel pnlContainer;
        private Label label2;
        private Label label3;
        private Button btnKitap;
        private Button button3;
        private Button btnUye;
        private Button button2;
    }
}