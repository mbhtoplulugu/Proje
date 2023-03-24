namespace Proje
{
    partial class frmPerGiris
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
            this.textAdi = new System.Windows.Forms.TextBox();
            this.textSoyadi = new System.Windows.Forms.TextBox();
            this.textSinifi = new System.Windows.Forms.TextBox();
            this.textRutbesi = new System.Windows.Forms.TextBox();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblSinifi = new System.Windows.Forms.Label();
            this.lblRutbesi = new System.Windows.Forms.Label();
            this.lblSicili = new System.Windows.Forms.Label();
            this.textSicili = new System.Windows.Forms.TextBox();
            this.btnPerEkle = new System.Windows.Forms.Button();
            this.btnPerIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textAdi
            // 
            this.textAdi.Location = new System.Drawing.Point(131, 40);
            this.textAdi.Multiline = true;
            this.textAdi.Name = "textAdi";
            this.textAdi.Size = new System.Drawing.Size(248, 30);
            this.textAdi.TabIndex = 0;
            this.textAdi.TextChanged += new System.EventHandler(this.textAdi_TextChanged);
            // 
            // textSoyadi
            // 
            this.textSoyadi.Location = new System.Drawing.Point(131, 80);
            this.textSoyadi.Multiline = true;
            this.textSoyadi.Name = "textSoyadi";
            this.textSoyadi.Size = new System.Drawing.Size(248, 30);
            this.textSoyadi.TabIndex = 1;
            this.textSoyadi.TextChanged += new System.EventHandler(this.textSoyadi_TextChanged);
            // 
            // textSinifi
            // 
            this.textSinifi.Location = new System.Drawing.Point(131, 123);
            this.textSinifi.Multiline = true;
            this.textSinifi.Name = "textSinifi";
            this.textSinifi.Size = new System.Drawing.Size(248, 30);
            this.textSinifi.TabIndex = 2;
            this.textSinifi.TextChanged += new System.EventHandler(this.textSinifi_TextChanged);
            // 
            // textRutbesi
            // 
            this.textRutbesi.Location = new System.Drawing.Point(131, 170);
            this.textRutbesi.Multiline = true;
            this.textRutbesi.Name = "textRutbesi";
            this.textRutbesi.Size = new System.Drawing.Size(248, 30);
            this.textRutbesi.TabIndex = 3;
            this.textRutbesi.TextChanged += new System.EventHandler(this.textRutbesi_TextChanged);
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdi.Location = new System.Drawing.Point(7, 48);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(118, 22);
            this.lblAdi.TabIndex = 4;
            this.lblAdi.Text = "Adı               :";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoyadi.Location = new System.Drawing.Point(6, 93);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(120, 22);
            this.lblSoyadi.TabIndex = 5;
            this.lblSoyadi.Text = "Soyadı          :";
            // 
            // lblSinifi
            // 
            this.lblSinifi.AutoSize = true;
            this.lblSinifi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSinifi.Location = new System.Drawing.Point(6, 131);
            this.lblSinifi.Name = "lblSinifi";
            this.lblSinifi.Size = new System.Drawing.Size(117, 22);
            this.lblSinifi.TabIndex = 6;
            this.lblSinifi.Text = "Sınıfı            :";
            // 
            // lblRutbesi
            // 
            this.lblRutbesi.AutoSize = true;
            this.lblRutbesi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRutbesi.Location = new System.Drawing.Point(6, 178);
            this.lblRutbesi.Name = "lblRutbesi";
            this.lblRutbesi.Size = new System.Drawing.Size(117, 22);
            this.lblRutbesi.TabIndex = 7;
            this.lblRutbesi.Text = "Rütbesi        :";
            // 
            // lblSicili
            // 
            this.lblSicili.AutoSize = true;
            this.lblSicili.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSicili.Location = new System.Drawing.Point(6, 218);
            this.lblSicili.Name = "lblSicili";
            this.lblSicili.Size = new System.Drawing.Size(115, 22);
            this.lblSicili.TabIndex = 9;
            this.lblSicili.Text = "Sicili            :";
            // 
            // textSicili
            // 
            this.textSicili.Location = new System.Drawing.Point(131, 210);
            this.textSicili.Multiline = true;
            this.textSicili.Name = "textSicili";
            this.textSicili.Size = new System.Drawing.Size(248, 30);
            this.textSicili.TabIndex = 8;
            this.textSicili.TextChanged += new System.EventHandler(this.textSicili_TextChanged);
            // 
            // btnPerEkle
            // 
            this.btnPerEkle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPerEkle.Location = new System.Drawing.Point(313, 256);
            this.btnPerEkle.Name = "btnPerEkle";
            this.btnPerEkle.Size = new System.Drawing.Size(66, 45);
            this.btnPerEkle.TabIndex = 10;
            this.btnPerEkle.Text = "EKLE";
            this.btnPerEkle.UseVisualStyleBackColor = true;
            this.btnPerEkle.Click += new System.EventHandler(this.btnPerEkle_Click);
            // 
            // btnPerIptal
            // 
            this.btnPerIptal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPerIptal.Location = new System.Drawing.Point(241, 256);
            this.btnPerIptal.Name = "btnPerIptal";
            this.btnPerIptal.Size = new System.Drawing.Size(66, 45);
            this.btnPerIptal.TabIndex = 11;
            this.btnPerIptal.Text = "İPTAL";
            this.btnPerIptal.UseVisualStyleBackColor = true;
            this.btnPerIptal.Click += new System.EventHandler(this.btnPerIptal_Click);
            // 
            // frmPerGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(407, 362);
            this.Controls.Add(this.btnPerIptal);
            this.Controls.Add(this.btnPerEkle);
            this.Controls.Add(this.lblSicili);
            this.Controls.Add(this.textSicili);
            this.Controls.Add(this.lblRutbesi);
            this.Controls.Add(this.lblSinifi);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.textRutbesi);
            this.Controls.Add(this.textSinifi);
            this.Controls.Add(this.textSoyadi);
            this.Controls.Add(this.textAdi);
            this.Name = "frmPerGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Ekleme Tablosu";
            this.Load += new System.EventHandler(this.frmPerGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private TextBox textAdi;
        private TextBox textSoyadi;
        private TextBox textSinifi;
        private TextBox textRutbesi;
        private Label lblAdi;
        private Label lblSoyadi;
        private Label lblSinifi;
        private Label lblRutbesi;
        private Label lblSicili;
        private TextBox textSicili;
        private Button btnPerEkle;
        private Button btnPerIptal;

    }
}