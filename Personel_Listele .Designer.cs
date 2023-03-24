namespace Proje
{
    partial class frmPerList
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblSicili = new System.Windows.Forms.Label();
            this.textSicil = new System.Windows.Forms.TextBox();
            this.lblRutbesi = new System.Windows.Forms.Label();
            this.lblSinifi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.textRutbe = new System.Windows.Forms.TextBox();
            this.textSinif = new System.Windows.Forms.TextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(391, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(538, 328);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIptal.Location = new System.Drawing.Point(868, 381);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(61, 45);
            this.btnIptal.TabIndex = 23;
            this.btnIptal.Text = "ÇIKIŞ";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(209, 263);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(109, 45);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblSicili
            // 
            this.lblSicili.AutoSize = true;
            this.lblSicili.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSicili.Location = new System.Drawing.Point(16, 225);
            this.lblSicili.Name = "lblSicili";
            this.lblSicili.Size = new System.Drawing.Size(115, 22);
            this.lblSicili.TabIndex = 21;
            this.lblSicili.Text = "Sicili            :";
            // 
            // textSicil
            // 
            this.textSicil.Location = new System.Drawing.Point(137, 217);
            this.textSicil.Multiline = true;
            this.textSicil.Name = "textSicil";
            this.textSicil.Size = new System.Drawing.Size(248, 30);
            this.textSicil.TabIndex = 20;
            // 
            // lblRutbesi
            // 
            this.lblRutbesi.AutoSize = true;
            this.lblRutbesi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRutbesi.Location = new System.Drawing.Point(14, 185);
            this.lblRutbesi.Name = "lblRutbesi";
            this.lblRutbesi.Size = new System.Drawing.Size(117, 22);
            this.lblRutbesi.TabIndex = 19;
            this.lblRutbesi.Text = "Rütbesi        :";
            // 
            // lblSinifi
            // 
            this.lblSinifi.AutoSize = true;
            this.lblSinifi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSinifi.Location = new System.Drawing.Point(14, 138);
            this.lblSinifi.Name = "lblSinifi";
            this.lblSinifi.Size = new System.Drawing.Size(117, 22);
            this.lblSinifi.TabIndex = 18;
            this.lblSinifi.Text = "Sınıfı            :";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoyadi.Location = new System.Drawing.Point(11, 100);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(120, 22);
            this.lblSoyadi.TabIndex = 17;
            this.lblSoyadi.Text = "Soyadı          :";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdi.Location = new System.Drawing.Point(13, 55);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(118, 22);
            this.lblAdi.TabIndex = 16;
            this.lblAdi.Text = "Adı               :";
            // 
            // textRutbe
            // 
            this.textRutbe.Location = new System.Drawing.Point(137, 177);
            this.textRutbe.Multiline = true;
            this.textRutbe.Name = "textRutbe";
            this.textRutbe.Size = new System.Drawing.Size(248, 30);
            this.textRutbe.TabIndex = 15;
            // 
            // textSinif
            // 
            this.textSinif.Location = new System.Drawing.Point(137, 130);
            this.textSinif.Multiline = true;
            this.textSinif.Name = "textSinif";
            this.textSinif.Size = new System.Drawing.Size(248, 30);
            this.textSinif.TabIndex = 14;
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(137, 87);
            this.textSoyad.Multiline = true;
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(248, 30);
            this.textSoyad.TabIndex = 13;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(137, 47);
            this.textAd.Multiline = true;
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(248, 30);
            this.textAd.TabIndex = 12;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(324, 263);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(66, 45);
            this.btnSil.TabIndex = 24;
            this.btnSil.Text = "SİL";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAra.Location = new System.Drawing.Point(137, 263);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(66, 45);
            this.btnAra.TabIndex = 23;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click_1);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListele.Location = new System.Drawing.Point(391, 381);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(83, 45);
            this.btnListele.TabIndex = 24;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(415, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "*** Lütfen sileceğiniz ve verisini değiştireceğiniz personelin***";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(542, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = " ***üzerini çift tıklayınız...***";
            // 
            // frmPerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblSicili);
            this.Controls.Add(this.textSicil);
            this.Controls.Add(this.lblRutbesi);
            this.Controls.Add(this.lblSinifi);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.textRutbe);
            this.Controls.Add(this.textSinif);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPerList";
            this.Text = "Personel_Listele";
            this.Load += new System.EventHandler(this.frmPerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnIptal;
        private Button btnGuncelle;
        private Label lblSicili;
        private TextBox textSicil;
        private Label lblRutbesi;
        private Label lblSinifi;
        private Label lblSoyadi;
        private Label lblAdi;
        private TextBox textRutbe;
        private TextBox textSinif;
        private TextBox textSoyad;
        private TextBox textAd;
        private Button btnSil;
        private Button btnAra;
        private Button btnListele;
        private Label label1;
        private Label label2;
    }
}