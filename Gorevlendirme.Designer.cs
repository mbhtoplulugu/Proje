namespace Proje
{
    partial class frmGorevlendirme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSicili = new System.Windows.Forms.Label();
            this.textSicili = new System.Windows.Forms.TextBox();
            this.lblRutbesi = new System.Windows.Forms.Label();
            this.lblSinifi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.textRutbesi = new System.Windows.Forms.TextBox();
            this.textSinifi = new System.Windows.Forms.TextBox();
            this.textSoyadi = new System.Windows.Forms.TextBox();
            this.textAdi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSeri = new System.Windows.Forms.ComboBox();
            this.comboPlaka = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(783, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lblSicili);
            this.groupBox1.Controls.Add(this.textSicili);
            this.groupBox1.Controls.Add(this.lblRutbesi);
            this.groupBox1.Controls.Add(this.lblSinifi);
            this.groupBox1.Controls.Add(this.lblSoyadi);
            this.groupBox1.Controls.Add(this.lblAdi);
            this.groupBox1.Controls.Add(this.textRutbesi);
            this.groupBox1.Controls.Add(this.textSinifi);
            this.groupBox1.Controls.Add(this.textSoyadi);
            this.groupBox1.Controls.Add(this.textAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 207);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTemizle.Location = new System.Drawing.Point(83, 172);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(65, 35);
            this.btnTemizle.TabIndex = 18;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(154, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "Personel Ara";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSicili
            // 
            this.lblSicili.AutoSize = true;
            this.lblSicili.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSicili.Location = new System.Drawing.Point(6, 144);
            this.lblSicili.Name = "lblSicili";
            this.lblSicili.Size = new System.Drawing.Size(72, 17);
            this.lblSicili.TabIndex = 29;
            this.lblSicili.Text = "Sicili       :";
            // 
            // textSicili
            // 
            this.textSicili.Location = new System.Drawing.Point(83, 138);
            this.textSicili.Multiline = true;
            this.textSicili.Name = "textSicili";
            this.textSicili.Size = new System.Drawing.Size(188, 24);
            this.textSicili.TabIndex = 28;
            this.textSicili.TextChanged += new System.EventHandler(this.textSicili_TextChanged);
            // 
            // lblRutbesi
            // 
            this.lblRutbesi.AutoSize = true;
            this.lblRutbesi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRutbesi.Location = new System.Drawing.Point(2, 115);
            this.lblRutbesi.Name = "lblRutbesi";
            this.lblRutbesi.Size = new System.Drawing.Size(76, 17);
            this.lblRutbesi.TabIndex = 27;
            this.lblRutbesi.Text = "Rütbesi   :";
            // 
            // lblSinifi
            // 
            this.lblSinifi.AutoSize = true;
            this.lblSinifi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSinifi.Location = new System.Drawing.Point(5, 86);
            this.lblSinifi.Name = "lblSinifi";
            this.lblSinifi.Size = new System.Drawing.Size(73, 17);
            this.lblSinifi.TabIndex = 26;
            this.lblSinifi.Text = "Sınıfı       :";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoyadi.Location = new System.Drawing.Point(3, 57);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(75, 17);
            this.lblSoyadi.TabIndex = 25;
            this.lblSoyadi.Text = "Soyadı     :";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdi.Location = new System.Drawing.Point(2, 28);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(76, 17);
            this.lblAdi.TabIndex = 24;
            this.lblAdi.Text = "Adı          :";
            // 
            // textRutbesi
            // 
            this.textRutbesi.Location = new System.Drawing.Point(83, 110);
            this.textRutbesi.Multiline = true;
            this.textRutbesi.Name = "textRutbesi";
            this.textRutbesi.Size = new System.Drawing.Size(188, 24);
            this.textRutbesi.TabIndex = 23;
            // 
            // textSinifi
            // 
            this.textSinifi.Location = new System.Drawing.Point(83, 82);
            this.textSinifi.Multiline = true;
            this.textSinifi.Name = "textSinifi";
            this.textSinifi.Size = new System.Drawing.Size(188, 24);
            this.textSinifi.TabIndex = 22;
            // 
            // textSoyadi
            // 
            this.textSoyadi.Location = new System.Drawing.Point(83, 54);
            this.textSoyadi.Multiline = true;
            this.textSoyadi.Name = "textSoyadi";
            this.textSoyadi.Size = new System.Drawing.Size(188, 24);
            this.textSoyadi.TabIndex = 21;
            // 
            // textAdi
            // 
            this.textAdi.Location = new System.Drawing.Point(83, 26);
            this.textAdi.Multiline = true;
            this.textAdi.Name = "textAdi";
            this.textAdi.Size = new System.Drawing.Size(188, 24);
            this.textAdi.TabIndex = 20;
            this.textAdi.TextChanged += new System.EventHandler(this.textAdi_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker5);
            this.groupBox2.Controls.Add(this.dateTimePicker4);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboSeri);
            this.groupBox2.Controls.Add(this.comboPlaka);
            this.groupBox2.Controls.Add(this.comboMarka);
            this.groupBox2.Location = new System.Drawing.Point(297, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 200);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(0, 165);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 35);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(423, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Göreve Çık";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(98, 133);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(73, 23);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker5.Location = new System.Drawing.Point(177, 133);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(73, 23);
            this.dateTimePicker5.TabIndex = 16;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(177, 104);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(73, 23);
            this.dateTimePicker4.TabIndex = 16;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(177, 107);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(73, 23);
            this.dateTimePicker3.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(73, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dönüş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Çıkış Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Plaka";
            // 
            // comboSeri
            // 
            this.comboSeri.FormattingEnabled = true;
            this.comboSeri.Location = new System.Drawing.Point(98, 75);
            this.comboSeri.Name = "comboSeri";
            this.comboSeri.Size = new System.Drawing.Size(121, 23);
            this.comboSeri.TabIndex = 12;
            this.comboSeri.SelectedIndexChanged += new System.EventHandler(this.comboSeri_SelectedIndexChanged);
            // 
            // comboPlaka
            // 
            this.comboPlaka.FormattingEnabled = true;
            this.comboPlaka.Location = new System.Drawing.Point(98, 17);
            this.comboPlaka.Name = "comboPlaka";
            this.comboPlaka.Size = new System.Drawing.Size(121, 23);
            this.comboPlaka.TabIndex = 11;
            this.comboPlaka.SelectedIndexChanged += new System.EventHandler(this.comboPlaka_SelectedIndexChanged);
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(98, 46);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(121, 23);
            this.comboMarka.TabIndex = 11;
            this.comboMarka.SelectedIndexChanged += new System.EventHandler(this.comboMarka_SelectedIndexChanged);
            // 
            // frmGorevlendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(804, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmGorevlendirme";
            this.Text = "Görevlendirme";
            this.Load += new System.EventHandler(this.Gorevlendirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label lblSicili;
        private TextBox textSicili;
        private Label lblRutbesi;
        private Label lblSinifi;
        private Label lblSoyadi;
        private Label lblAdi;
        private TextBox textRutbesi;
        private TextBox textSinifi;
        private TextBox textSoyadi;
        private TextBox textAdi;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboSeri;
        private ComboBox comboMarka;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker5;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private Button button1;
        private ComboBox comboPlaka;
        private Button button2;
        private Button btnTemizle;
        private Button btnRefresh;
    }
}