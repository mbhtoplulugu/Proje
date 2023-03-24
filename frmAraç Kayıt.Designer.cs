namespace Proje
{
    partial class frmAraç_Kayıt
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
            this.PLAKAtxt = new System.Windows.Forms.TextBox();
            this.MARKAcombo = new System.Windows.Forms.ComboBox();
            this.SERIcombo = new System.Windows.Forms.ComboBox();
            this.YILtxt = new System.Windows.Forms.TextBox();
            this.KMtxt = new System.Windows.Forms.TextBox();
            this.YAKITcombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PLAKAtxt
            // 
            this.PLAKAtxt.Location = new System.Drawing.Point(129, 29);
            this.PLAKAtxt.Name = "PLAKAtxt";
            this.PLAKAtxt.Size = new System.Drawing.Size(121, 23);
            this.PLAKAtxt.TabIndex = 0;
            this.PLAKAtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.MARKAcombo.Location = new System.Drawing.Point(129, 70);
            this.MARKAcombo.Name = "MARKAcombo";
            this.MARKAcombo.Size = new System.Drawing.Size(121, 23);
            this.MARKAcombo.TabIndex = 1;
            this.MARKAcombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SERIcombo
            // 
            this.SERIcombo.FormattingEnabled = true;
            this.SERIcombo.Location = new System.Drawing.Point(129, 111);
            this.SERIcombo.Name = "SERIcombo";
            this.SERIcombo.Size = new System.Drawing.Size(121, 23);
            this.SERIcombo.TabIndex = 2;
            // 
            // YILtxt
            // 
            this.YILtxt.Location = new System.Drawing.Point(129, 153);
            this.YILtxt.Name = "YILtxt";
            this.YILtxt.Size = new System.Drawing.Size(121, 23);
            this.YILtxt.TabIndex = 3;
            // 
            // KMtxt
            // 
            this.KMtxt.Location = new System.Drawing.Point(129, 195);
            this.KMtxt.Name = "KMtxt";
            this.KMtxt.Size = new System.Drawing.Size(121, 23);
            this.KMtxt.TabIndex = 4;
            this.KMtxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // YAKITcombo
            // 
            this.YAKITcombo.FormattingEnabled = true;
            this.YAKITcombo.Items.AddRange(new object[] {
            "DİZEL",
            "BENZİN"});
            this.YAKITcombo.Location = new System.Drawing.Point(129, 235);
            this.YAKITcombo.Name = "YAKITcombo";
            this.YAKITcombo.Size = new System.Drawing.Size(121, 23);
            this.YAKITcombo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "PLAKA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "MARKA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "SERİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "YIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "KM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "YAKIT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "KAYIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "İPTAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAraç_Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Name = "frmAraç_Kayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PLAKAtxt;
        private ComboBox MARKAcombo;
        private ComboBox SERIcombo;
        private TextBox YILtxt;
        private TextBox KMtxt;
        private ComboBox YAKITcombo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button button1;
        private Button button2;
    }
}