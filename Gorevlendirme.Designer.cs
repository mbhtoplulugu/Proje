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
            this.btnPerAra = new System.Windows.Forms.Button();
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
            this.konvoyCheck = new System.Windows.Forms.CheckBox();
            this.btnKonAracEkle = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnGorev = new System.Windows.Forms.Button();
            this.donusGun = new System.Windows.Forms.DateTimePicker();
            this.donusZaman = new System.Windows.Forms.DateTimePicker();
            this.cikisZaman = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.cikisGun = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textKonvoy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSeri = new System.Windows.Forms.ComboBox();
            this.comboKonvoyPlaka = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.Controls.Add(this.btnPerAra);
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
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTemizle.Location = new System.Drawing.Point(83, 172);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(65, 35);
            this.btnTemizle.TabIndex = 18;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click_1);
            // 
            // btnPerAra
            // 
            this.btnPerAra.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPerAra.Location = new System.Drawing.Point(154, 172);
            this.btnPerAra.Name = "btnPerAra";
            this.btnPerAra.Size = new System.Drawing.Size(117, 35);
            this.btnPerAra.TabIndex = 18;
            this.btnPerAra.Text = "Personel Ara";
            this.btnPerAra.UseVisualStyleBackColor = false;
            this.btnPerAra.Click += new System.EventHandler(this.btnPerAra_Click);
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.konvoyCheck);
            this.groupBox2.Controls.Add(this.btnKonAracEkle);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnGorev);
            this.groupBox2.Controls.Add(this.donusGun);
            this.groupBox2.Controls.Add(this.donusZaman);
            this.groupBox2.Controls.Add(this.cikisZaman);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.cikisGun);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textKonvoy);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboSeri);
            this.groupBox2.Controls.Add(this.comboKonvoyPlaka);
            this.groupBox2.Controls.Add(this.comboPlaka);
            this.groupBox2.Controls.Add(this.comboMarka);
            this.groupBox2.Location = new System.Drawing.Point(297, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 200);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // konvoyCheck
            // 
            this.konvoyCheck.AutoSize = true;
            this.konvoyCheck.BackColor = System.Drawing.Color.PaleGreen;
            this.konvoyCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.konvoyCheck.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.konvoyCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.konvoyCheck.Location = new System.Drawing.Point(290, 19);
            this.konvoyCheck.Name = "konvoyCheck";
            this.konvoyCheck.Size = new System.Drawing.Size(199, 21);
            this.konvoyCheck.TabIndex = 21;
            this.konvoyCheck.Text = "Konvoy Oluşturulacak mı?";
            this.konvoyCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.konvoyCheck.UseVisualStyleBackColor = false;
            this.konvoyCheck.CheckedChanged += new System.EventHandler(this.konvoyCheck_CheckedChanged);
            // 
            // btnKonAracEkle
            // 
            this.btnKonAracEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnKonAracEkle.Location = new System.Drawing.Point(377, 107);
            this.btnKonAracEkle.Name = "btnKonAracEkle";
            this.btnKonAracEkle.Size = new System.Drawing.Size(121, 35);
            this.btnKonAracEkle.TabIndex = 18;
            this.btnKonAracEkle.Text = "Konvoya Araç Ekle";
            this.btnKonAracEkle.UseVisualStyleBackColor = false;
            this.btnKonAracEkle.Visible = false;
            this.btnKonAracEkle.Click += new System.EventHandler(this.btnKonAracEkle_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRefresh.Location = new System.Drawing.Point(0, 165);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 35);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnGorev
            // 
            this.btnGorev.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGorev.Location = new System.Drawing.Point(423, 165);
            this.btnGorev.Name = "btnGorev";
            this.btnGorev.Size = new System.Drawing.Size(75, 35);
            this.btnGorev.TabIndex = 18;
            this.btnGorev.Text = "Göreve Çık";
            this.btnGorev.UseVisualStyleBackColor = false;
            this.btnGorev.Click += new System.EventHandler(this.btnGorev_Click);
            // 
            // donusGun
            // 
            this.donusGun.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.donusGun.Location = new System.Drawing.Point(98, 133);
            this.donusGun.Name = "donusGun";
            this.donusGun.Size = new System.Drawing.Size(73, 23);
            this.donusGun.TabIndex = 17;
            // 
            // donusZaman
            // 
            this.donusZaman.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.donusZaman.Location = new System.Drawing.Point(177, 133);
            this.donusZaman.Name = "donusZaman";
            this.donusZaman.Size = new System.Drawing.Size(73, 23);
            this.donusZaman.TabIndex = 16;
            // 
            // cikisZaman
            // 
            this.cikisZaman.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.cikisZaman.Location = new System.Drawing.Point(177, 104);
            this.cikisZaman.Name = "cikisZaman";
            this.cikisZaman.Size = new System.Drawing.Size(73, 23);
            this.cikisZaman.TabIndex = 16;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(177, 107);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(73, 23);
            this.dateTimePicker3.TabIndex = 16;
            // 
            // cikisGun
            // 
            this.cikisGun.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cikisGun.Location = new System.Drawing.Point(98, 104);
            this.cikisGun.Name = "cikisGun";
            this.cikisGun.Size = new System.Drawing.Size(73, 23);
            this.cikisGun.TabIndex = 16;
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
            // textKonvoy
            // 
            this.textKonvoy.Location = new System.Drawing.Point(374, 45);
            this.textKonvoy.Multiline = true;
            this.textKonvoy.Name = "textKonvoy";
            this.textKonvoy.Size = new System.Drawing.Size(121, 24);
            this.textKonvoy.TabIndex = 20;
            this.textKonvoy.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleGreen;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(284, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Konvoy ID";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PaleGreen;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(285, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Araç Plakası";
            this.label7.Visible = false;
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
            // comboKonvoyPlaka
            // 
            this.comboKonvoyPlaka.FormattingEnabled = true;
            this.comboKonvoyPlaka.Location = new System.Drawing.Point(377, 79);
            this.comboKonvoyPlaka.Name = "comboKonvoyPlaka";
            this.comboKonvoyPlaka.Size = new System.Drawing.Size(121, 23);
            this.comboKonvoyPlaka.TabIndex = 11;
            this.comboKonvoyPlaka.Visible = false;
            this.comboKonvoyPlaka.SelectedIndexChanged += new System.EventHandler(this.comboPlaka_SelectedIndexChanged);
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
        private DateTimePicker donusGun;
        private DateTimePicker donusZaman;
        private DateTimePicker cikisZaman;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker cikisGun;
        private Label label5;
        private Label label4;
        private Button btnGorev;
        private ComboBox comboPlaka;
        private Button btnPerAra;
        private Button btnTemizle;
        private Button btnRefresh;
        private CheckBox konvoyCheck;
        private TextBox textKonvoy;
        private Label label6;
        private Button btnKonAracEkle;
        private Label label7;
        private ComboBox comboKonvoyPlaka;
    }
}