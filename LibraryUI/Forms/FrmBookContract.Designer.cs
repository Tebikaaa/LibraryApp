namespace LibraryUI.Forms
{
    partial class FrmBookContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookContract));
            gBoxValues = new GroupBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            cbDurum = new ComboBox();
            label4 = new Label();
            cbKitap = new ComboBox();
            cbUye = new ComboBox();
            label3 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            gBoxButtons = new GroupBox();
            btnIade = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            dataGridView1 = new DataGridView();
            gBoxValues.SuspendLayout();
            gBoxButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gBoxValues
            // 
            gBoxValues.AutoSize = true;
            gBoxValues.Controls.Add(label8);
            gBoxValues.Controls.Add(comboBox1);
            gBoxValues.Controls.Add(dateTimePicker2);
            gBoxValues.Controls.Add(label7);
            gBoxValues.Controls.Add(dateTimePicker1);
            gBoxValues.Controls.Add(label6);
            gBoxValues.Controls.Add(label5);
            gBoxValues.Controls.Add(cbDurum);
            gBoxValues.Controls.Add(label4);
            gBoxValues.Controls.Add(cbKitap);
            gBoxValues.Controls.Add(cbUye);
            gBoxValues.Controls.Add(label3);
            gBoxValues.Controls.Add(txtId);
            gBoxValues.Controls.Add(label1);
            gBoxValues.Controls.Add(gBoxButtons);
            gBoxValues.Dock = DockStyle.Fill;
            gBoxValues.Location = new Point(0, 0);
            gBoxValues.Name = "gBoxValues";
            gBoxValues.Size = new Size(274, 601);
            gBoxValues.TabIndex = 4;
            gBoxValues.TabStop = false;
            gBoxValues.Text = "Değer Kutusu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 199);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 37;
            label8.Text = "Ödünç AlmaTipi :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(116, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 23);
            comboBox1.TabIndex = 36;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(143, 167);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(125, 23);
            dateTimePicker2.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 173);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 34;
            label7.Text = "Ödünç Alınma Tarihi :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(143, 138);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 23);
            dateTimePicker1.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 144);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 32;
            label6.Text = "Ödünç Verilme Tarihi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 112);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 31;
            label5.Text = "Ödünç Durumu :";
            // 
            // cbDurum
            // 
            cbDurum.FormattingEnabled = true;
            cbDurum.Location = new Point(116, 109);
            cbDurum.Name = "cbDurum";
            cbDurum.Size = new Size(152, 23);
            cbDurum.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 83);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 29;
            label4.Text = "Kitap :";
            // 
            // cbKitap
            // 
            cbKitap.FormattingEnabled = true;
            cbKitap.Location = new Point(60, 80);
            cbKitap.Name = "cbKitap";
            cbKitap.Size = new Size(208, 23);
            cbKitap.TabIndex = 28;
            // 
            // cbUye
            // 
            cbUye.FormattingEnabled = true;
            cbUye.Location = new Point(51, 51);
            cbUye.Name = "cbUye";
            cbUye.Size = new Size(217, 23);
            cbUye.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 54);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 26;
            label3.Text = "Üye :";
            // 
            // txtId
            // 
            txtId.Location = new Point(74, 22);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(194, 23);
            txtId.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 25);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 22;
            label1.Text = "Numarası :";
            // 
            // gBoxButtons
            // 
            gBoxButtons.Controls.Add(btnIade);
            gBoxButtons.Controls.Add(btnSil);
            gBoxButtons.Controls.Add(btnGuncelle);
            gBoxButtons.Controls.Add(btnEkle);
            gBoxButtons.Dock = DockStyle.Bottom;
            gBoxButtons.Location = new Point(3, 344);
            gBoxButtons.Name = "gBoxButtons";
            gBoxButtons.Size = new Size(268, 254);
            gBoxButtons.TabIndex = 21;
            gBoxButtons.TabStop = false;
            gBoxButtons.Text = "İşlemler";
            // 
            // btnIade
            // 
            btnIade.Dock = DockStyle.Top;
            btnIade.Location = new Point(3, 151);
            btnIade.Name = "btnIade";
            btnIade.Padding = new Padding(5);
            btnIade.Size = new Size(262, 44);
            btnIade.TabIndex = 3;
            btnIade.Text = "İade";
            btnIade.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Dock = DockStyle.Top;
            btnSil.Location = new Point(3, 107);
            btnSil.Name = "btnSil";
            btnSil.Padding = new Padding(5);
            btnSil.Size = new Size(262, 44);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Dock = DockStyle.Top;
            btnGuncelle.Location = new Point(3, 63);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Padding = new Padding(5);
            btnGuncelle.Size = new Size(262, 44);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Dock = DockStyle.Top;
            btnEkle.Location = new Point(3, 19);
            btnEkle.Name = "btnEkle";
            btnEkle.Padding = new Padding(5);
            btnEkle.Size = new Size(262, 44);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(274, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(573, 601);
            dataGridView1.TabIndex = 5;
            // 
            // FrmBookContract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 601);
            Controls.Add(gBoxValues);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmBookContract";
            Text = "Ödünç Alma Formu";
            gBoxValues.ResumeLayout(false);
            gBoxValues.PerformLayout();
            gBoxButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gBoxValues;
        private TextBox txtId;
        private Label label1;
        private GroupBox gBoxButtons;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private DataGridView dataGridView1;
        private Button btnIade;
        private Label label3;
        private Label label4;
        private ComboBox cbKitap;
        private ComboBox cbUye;
        private Label label5;
        private ComboBox cbDurum;
        private Label label8;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label6;
    }
}