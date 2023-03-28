namespace Proje
{
    partial class AraçListele
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
            this.comboAraclar = new System.Windows.Forms.ComboBox();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YAKITcombo = new System.Windows.Forms.ComboBox();
            this.KMtxt = new System.Windows.Forms.TextBox();
            this.YILtxt = new System.Windows.Forms.TextBox();
            this.SERIcombo = new System.Windows.Forms.ComboBox();
            this.MARKAcombo = new System.Windows.Forms.ComboBox();
            this.PLAKAtxt = new System.Windows.Forms.TextBox();
            this.btnSİL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(511, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboAraclar
            // 
            this.comboAraclar.FormattingEnabled = true;
            this.comboAraclar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.comboAraclar.Location = new System.Drawing.Point(543, 31);
            this.comboAraclar.Name = "comboAraclar";
            this.comboAraclar.Size = new System.Drawing.Size(121, 23);
            this.comboAraclar.TabIndex = 1;
            this.comboAraclar.SelectedIndexChanged += new System.EventHandler(this.comboAraclar_SelectedIndexChanged);
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİptal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnİptal.Location = new System.Drawing.Point(116, 329);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(98, 40);
            this.btnİptal.TabIndex = 29;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGüncelle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGüncelle.Location = new System.Drawing.Point(12, 329);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(98, 40);
            this.btnGüncelle.TabIndex = 28;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "YAKIT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "KM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "YIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "SERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "MARKA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "PLAKA";
            // 
            // YAKITcombo
            // 
            this.YAKITcombo.FormattingEnabled = true;
            this.YAKITcombo.Items.AddRange(new object[] {
            "DİZEL",
            "BENZİN"});
            this.YAKITcombo.Location = new System.Drawing.Point(81, 280);
            this.YAKITcombo.Name = "YAKITcombo";
            this.YAKITcombo.Size = new System.Drawing.Size(121, 23);
            this.YAKITcombo.TabIndex = 21;
            // 
            // KMtxt
            // 
            this.KMtxt.Location = new System.Drawing.Point(81, 240);
            this.KMtxt.Name = "KMtxt";
            this.KMtxt.Size = new System.Drawing.Size(121, 23);
            this.KMtxt.TabIndex = 20;
            // 
            // YILtxt
            // 
            this.YILtxt.Location = new System.Drawing.Point(81, 198);
            this.YILtxt.Name = "YILtxt";
            this.YILtxt.Size = new System.Drawing.Size(121, 23);
            this.YILtxt.TabIndex = 19;
            // 
            // SERIcombo
            // 
            this.SERIcombo.FormattingEnabled = true;
            this.SERIcombo.Location = new System.Drawing.Point(81, 156);
            this.SERIcombo.Name = "SERIcombo";
            this.SERIcombo.Size = new System.Drawing.Size(121, 23);
            this.SERIcombo.TabIndex = 18;
            // 
            // MARKAcombo
            // 
            this.MARKAcombo.FormattingEnabled = true;
            this.MARKAcombo.Items.AddRange(new object[] {
            "MERCEDES",
            "BMC",
            "RENAULT",
            "FORD",
            "FIAT",
            "TOYOTA"});
            this.MARKAcombo.Location = new System.Drawing.Point(81, 115);
            this.MARKAcombo.Name = "MARKAcombo";
            this.MARKAcombo.Size = new System.Drawing.Size(121, 23);
            this.MARKAcombo.TabIndex = 17;
            this.MARKAcombo.SelectedIndexChanged += new System.EventHandler(this.MARKAcombo_SelectedIndexChanged);
            // 
            // PLAKAtxt
            // 
            this.PLAKAtxt.Location = new System.Drawing.Point(81, 74);
            this.PLAKAtxt.Name = "PLAKAtxt";
            this.PLAKAtxt.Size = new System.Drawing.Size(121, 23);
            this.PLAKAtxt.TabIndex = 16;
            // 
            // btnSİL
            // 
            this.btnSİL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSİL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSİL.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSİL.Location = new System.Drawing.Point(744, 74);
            this.btnSİL.Name = "btnSİL";
            this.btnSİL.Size = new System.Drawing.Size(80, 40);
            this.btnSİL.TabIndex = 30;
            this.btnSİL.Text = "SİL";
            this.btnSİL.UseVisualStyleBackColor = false;
            this.btnSİL.Click += new System.EventHandler(this.btnSİL_Click);
            // 
            // AraçListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(852, 457);
            this.Controls.Add(this.btnSİL);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YAKITcombo);
            this.Controls.Add(this.KMtxt);
            this.Controls.Add(this.YILtxt);
            this.Controls.Add(this.SERIcombo);
            this.Controls.Add(this.MARKAcombo);
            this.Controls.Add(this.PLAKAtxt);
            this.Controls.Add(this.comboAraclar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AraçListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listeleme Sayfası";
            this.Load += new System.EventHandler(this.AraçListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboAraclar;
        private Button btnİptal;
        private Button btnGüncelle;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox YAKITcombo;
        private TextBox KMtxt;
        private TextBox YILtxt;
        private ComboBox SERIcombo;
        private ComboBox MARKAcombo;
        private TextBox PLAKAtxt;
        private Button btnSİL;
    }
}