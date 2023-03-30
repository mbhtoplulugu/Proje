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
            this.label8 = new System.Windows.Forms.Label();
            this.lblSicili = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
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
            this.checkKonvoy = new System.Windows.Forms.CheckBox();
            this.btnAracListele = new System.Windows.Forms.Button();
            this.btnKonvoyListele = new System.Windows.Forms.Button();
            this.btnKonAracSil = new System.Windows.Forms.Button();
            this.btnKonAracEkle = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnGorev = new System.Windows.Forms.Button();
            this.donusGun = new System.Windows.Forms.DateTimePicker();
            this.donusZaman = new System.Windows.Forms.DateTimePicker();
            this.cikisZaman = new System.Windows.Forms.DateTimePicker();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(783, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnPerAra);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblSicili);
            this.groupBox1.Controls.Add(this.textTel);
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
            this.groupBox1.Size = new System.Drawing.Size(279, 245);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Komutanı Bilgileri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTemizle.Location = new System.Drawing.Point(22, 206);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(109, 35);
            this.btnTemizle.TabIndex = 18;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click_1);
            // 
            // btnPerAra
            // 
            this.btnPerAra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPerAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerAra.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPerAra.Location = new System.Drawing.Point(154, 206);
            this.btnPerAra.Name = "btnPerAra";
            this.btnPerAra.Size = new System.Drawing.Size(109, 35);
            this.btnPerAra.TabIndex = 18;
            this.btnPerAra.Text = "Personel Ara";
            this.btnPerAra.UseVisualStyleBackColor = false;
            this.btnPerAra.Click += new System.EventHandler(this.btnPerAra_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tel. Nu.";
            // 
            // lblSicili
            // 
            this.lblSicili.AutoSize = true;
            this.lblSicili.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSicili.Location = new System.Drawing.Point(13, 144);
            this.lblSicili.Name = "lblSicili";
            this.lblSicili.Size = new System.Drawing.Size(66, 17);
            this.lblSicili.TabIndex = 29;
            this.lblSicili.Text = "Sicili       :";
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(85, 168);
            this.textTel.Multiline = true;
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(188, 24);
            this.textTel.TabIndex = 28;
            // 
            // textSicili
            // 
            this.textSicili.Location = new System.Drawing.Point(85, 138);
            this.textSicili.Multiline = true;
            this.textSicili.Name = "textSicili";
            this.textSicili.Size = new System.Drawing.Size(188, 24);
            this.textSicili.TabIndex = 28;
            // 
            // lblRutbesi
            // 
            this.lblRutbesi.AutoSize = true;
            this.lblRutbesi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRutbesi.Location = new System.Drawing.Point(12, 115);
            this.lblRutbesi.Name = "lblRutbesi";
            this.lblRutbesi.Size = new System.Drawing.Size(67, 17);
            this.lblRutbesi.TabIndex = 27;
            this.lblRutbesi.Text = "Rütbesi   :";
            // 
            // lblSinifi
            // 
            this.lblSinifi.AutoSize = true;
            this.lblSinifi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSinifi.Location = new System.Drawing.Point(11, 86);
            this.lblSinifi.Name = "lblSinifi";
            this.lblSinifi.Size = new System.Drawing.Size(68, 17);
            this.lblSinifi.TabIndex = 26;
            this.lblSinifi.Text = "Sınıfı       :";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoyadi.Location = new System.Drawing.Point(9, 57);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(70, 17);
            this.lblSoyadi.TabIndex = 25;
            this.lblSoyadi.Text = "Soyadı     :";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdi.Location = new System.Drawing.Point(7, 28);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(72, 17);
            this.lblAdi.TabIndex = 24;
            this.lblAdi.Text = "Adı          :";
            // 
            // textRutbesi
            // 
            this.textRutbesi.Location = new System.Drawing.Point(85, 110);
            this.textRutbesi.Multiline = true;
            this.textRutbesi.Name = "textRutbesi";
            this.textRutbesi.Size = new System.Drawing.Size(188, 24);
            this.textRutbesi.TabIndex = 23;
            // 
            // textSinifi
            // 
            this.textSinifi.Location = new System.Drawing.Point(85, 82);
            this.textSinifi.Multiline = true;
            this.textSinifi.Name = "textSinifi";
            this.textSinifi.Size = new System.Drawing.Size(188, 24);
            this.textSinifi.TabIndex = 22;
            // 
            // textSoyadi
            // 
            this.textSoyadi.Location = new System.Drawing.Point(85, 54);
            this.textSoyadi.Multiline = true;
            this.textSoyadi.Name = "textSoyadi";
            this.textSoyadi.Size = new System.Drawing.Size(188, 24);
            this.textSoyadi.TabIndex = 21;
            // 
            // textAdi
            // 
            this.textAdi.Location = new System.Drawing.Point(85, 26);
            this.textAdi.Multiline = true;
            this.textAdi.Name = "textAdi";
            this.textAdi.Size = new System.Drawing.Size(188, 24);
            this.textAdi.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.checkKonvoy);
            this.groupBox2.Controls.Add(this.btnAracListele);
            this.groupBox2.Controls.Add(this.btnKonvoyListele);
            this.groupBox2.Controls.Add(this.btnKonAracSil);
            this.groupBox2.Controls.Add(this.btnKonAracEkle);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnGorev);
            this.groupBox2.Controls.Add(this.donusGun);
            this.groupBox2.Controls.Add(this.donusZaman);
            this.groupBox2.Controls.Add(this.cikisZaman);
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
            this.groupBox2.Location = new System.Drawing.Point(297, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 245);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç-Konvoy Bilgileri";
            // 
            // checkKonvoy
            // 
            this.checkKonvoy.AutoSize = true;
            this.checkKonvoy.BackColor = System.Drawing.Color.LawnGreen;
            this.checkKonvoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkKonvoy.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.checkKonvoy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkKonvoy.Location = new System.Drawing.Point(284, 14);
            this.checkKonvoy.Name = "checkKonvoy";
            this.checkKonvoy.Size = new System.Drawing.Size(211, 21);
            this.checkKonvoy.TabIndex = 21;
            this.checkKonvoy.Text = "Konvoy Oluşturulacak mı ?  ";
            this.checkKonvoy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkKonvoy.UseVisualStyleBackColor = false;
            this.checkKonvoy.CheckedChanged += new System.EventHandler(this.konvoyCheck_CheckedChanged);
            // 
            // btnAracListele
            // 
            this.btnAracListele.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAracListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracListele.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAracListele.Location = new System.Drawing.Point(258, 205);
            this.btnAracListele.Name = "btnAracListele";
            this.btnAracListele.Size = new System.Drawing.Size(109, 35);
            this.btnAracListele.TabIndex = 18;
            this.btnAracListele.Text = "Araç Listele";
            this.btnAracListele.UseVisualStyleBackColor = false;
            this.btnAracListele.Click += new System.EventHandler(this.btnAracListele_Click);
            // 
            // btnKonvoyListele
            // 
            this.btnKonvoyListele.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnKonvoyListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKonvoyListele.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKonvoyListele.Location = new System.Drawing.Point(384, 205);
            this.btnKonvoyListele.Name = "btnKonvoyListele";
            this.btnKonvoyListele.Size = new System.Drawing.Size(109, 35);
            this.btnKonvoyListele.TabIndex = 18;
            this.btnKonvoyListele.Text = "Konvoy Listele";
            this.btnKonvoyListele.UseVisualStyleBackColor = false;
            this.btnKonvoyListele.Click += new System.EventHandler(this.btnKonvoyListele_Click);
            // 
            // btnKonAracSil
            // 
            this.btnKonAracSil.BackColor = System.Drawing.Color.LawnGreen;
            this.btnKonAracSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKonAracSil.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKonAracSil.Location = new System.Drawing.Point(300, 104);
            this.btnKonAracSil.Name = "btnKonAracSil";
            this.btnKonAracSil.Size = new System.Drawing.Size(94, 35);
            this.btnKonAracSil.TabIndex = 18;
            this.btnKonAracSil.Text = "Araç Sil";
            this.btnKonAracSil.UseVisualStyleBackColor = false;
            this.btnKonAracSil.Visible = false;
            this.btnKonAracSil.Click += new System.EventHandler(this.btnKonAracSil_Click);
            // 
            // btnKonAracEkle
            // 
            this.btnKonAracEkle.BackColor = System.Drawing.Color.LawnGreen;
            this.btnKonAracEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKonAracEkle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKonAracEkle.Location = new System.Drawing.Point(400, 104);
            this.btnKonAracEkle.Name = "btnKonAracEkle";
            this.btnKonAracEkle.Size = new System.Drawing.Size(94, 35);
            this.btnKonAracEkle.TabIndex = 18;
            this.btnKonAracEkle.Text = "Araç Ekle";
            this.btnKonAracEkle.UseVisualStyleBackColor = false;
            this.btnKonAracEkle.Visible = false;
            this.btnKonAracEkle.Click += new System.EventHandler(this.btnKonAracEkle_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(6, 205);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 35);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnGorev
            // 
            this.btnGorev.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnGorev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorev.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGorev.ForeColor = System.Drawing.Color.Red;
            this.btnGorev.Location = new System.Drawing.Point(132, 205);
            this.btnGorev.Name = "btnGorev";
            this.btnGorev.Size = new System.Drawing.Size(109, 35);
            this.btnGorev.TabIndex = 18;
            this.btnGorev.Text = "Görevlendir";
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
            this.donusZaman.CustomFormat = " HH:mm ";
            this.donusZaman.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.donusZaman.Location = new System.Drawing.Point(177, 133);
            this.donusZaman.Name = "donusZaman";
            this.donusZaman.ShowUpDown = true;
            this.donusZaman.Size = new System.Drawing.Size(64, 23);
            this.donusZaman.TabIndex = 16;
            // 
            // cikisZaman
            // 
            this.cikisZaman.CustomFormat = " HH:mm ";
            this.cikisZaman.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cikisZaman.Location = new System.Drawing.Point(177, 104);
            this.cikisZaman.Name = "cikisZaman";
            this.cikisZaman.ShowUpDown = true;
            this.cikisZaman.Size = new System.Drawing.Size(64, 23);
            this.cikisZaman.TabIndex = 16;
            this.cikisZaman.ValueChanged += new System.EventHandler(this.cikisZaman_ValueChanged);
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
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dönüş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Çıkış Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Marka";
            // 
            // textKonvoy
            // 
            this.textKonvoy.BackColor = System.Drawing.Color.LawnGreen;
            this.textKonvoy.Location = new System.Drawing.Point(377, 41);
            this.textKonvoy.Multiline = true;
            this.textKonvoy.Name = "textKonvoy";
            this.textKonvoy.Size = new System.Drawing.Size(118, 24);
            this.textKonvoy.TabIndex = 20;
            this.textKonvoy.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LawnGreen;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(284, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Konvoy ID";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LawnGreen;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(284, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Araç Plakası";
            this.label7.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
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
            this.comboKonvoyPlaka.BackColor = System.Drawing.Color.LawnGreen;
            this.comboKonvoyPlaka.FormattingEnabled = true;
            this.comboKonvoyPlaka.Location = new System.Drawing.Point(377, 71);
            this.comboKonvoyPlaka.Name = "comboKonvoyPlaka";
            this.comboKonvoyPlaka.Size = new System.Drawing.Size(118, 23);
            this.comboKonvoyPlaka.TabIndex = 11;
            this.comboKonvoyPlaka.Visible = false;
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
            this.ClientSize = new System.Drawing.Size(804, 499);
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
        private DateTimePicker cikisGun;
        private Label label5;
        private Label label4;
        private Button btnGorev;
        private ComboBox comboPlaka;
        private Button btnPerAra;
        private Button btnTemizle;
        private Button btnRefresh;
        private CheckBox checkKonvoy;
        private TextBox textKonvoy;
        private Label label6;
        private Button btnKonAracEkle;
        private Label label7;
        private ComboBox comboKonvoyPlaka;
        private Button btnKonvoyListele;
        private Button btnAracListele;
        private Button btnKonAracSil;
        private Label label8;
        private TextBox textTel;
    }
}