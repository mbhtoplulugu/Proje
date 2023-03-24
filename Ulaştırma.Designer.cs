namespace Proje
{

    partial class FrmUlastirma

    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPerKayit = new System.Windows.Forms.Button();
            this.btnPerList = new System.Windows.Forms.Button();
            this.btnAracKayıt = new System.Windows.Forms.Button();
            this.btnAracList = new System.Windows.Forms.Button();
            this.btnGörev = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerKayit
            // 
            this.btnPerKayit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPerKayit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPerKayit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPerKayit.Location = new System.Drawing.Point(29, 23);
            this.btnPerKayit.Name = "btnPerKayit";
            this.btnPerKayit.Size = new System.Drawing.Size(140, 73);
            this.btnPerKayit.TabIndex = 0;
            this.btnPerKayit.Text = "Personel Kayıt";
            this.btnPerKayit.UseVisualStyleBackColor = false;
            this.btnPerKayit.Click += new System.EventHandler(this.btnPerKayit_Click);
            // 
            // btnPerList
            // 
            this.btnPerList.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPerList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPerList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPerList.Location = new System.Drawing.Point(210, 23);
            this.btnPerList.Name = "btnPerList";
            this.btnPerList.Size = new System.Drawing.Size(140, 73);
            this.btnPerList.TabIndex = 1;
            this.btnPerList.Text = "Personel Listesi";
            this.btnPerList.UseVisualStyleBackColor = false;
            this.btnPerList.Click += new System.EventHandler(this.btnPerList_Click);
            // 
            // btnAracKayıt
            // 
            this.btnAracKayıt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAracKayıt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAracKayıt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAracKayıt.Location = new System.Drawing.Point(29, 130);
            this.btnAracKayıt.Name = "btnAracKayıt";
            this.btnAracKayıt.Size = new System.Drawing.Size(140, 73);
            this.btnAracKayıt.TabIndex = 2;
            this.btnAracKayıt.Text = "Araç Kayıt";
            this.btnAracKayıt.UseVisualStyleBackColor = false;
            this.btnAracKayıt.Click += new System.EventHandler(this.btnAracKayıt_Click);
            // 
            // btnAracList
            // 
            this.btnAracList.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAracList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAracList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAracList.Location = new System.Drawing.Point(210, 130);
            this.btnAracList.Name = "btnAracList";
            this.btnAracList.Size = new System.Drawing.Size(140, 73);
            this.btnAracList.TabIndex = 3;
            this.btnAracList.Text = "Araç Listesi";
            this.btnAracList.UseVisualStyleBackColor = false;
            // 
            // btnGörev
            // 
            this.btnGörev.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGörev.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGörev.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGörev.Location = new System.Drawing.Point(210, 260);
            this.btnGörev.Name = "btnGörev";
            this.btnGörev.Size = new System.Drawing.Size(140, 73);
            this.btnGörev.TabIndex = 5;
            this.btnGörev.Text = "Görevlendir";
            this.btnGörev.UseVisualStyleBackColor = false;
            this.btnGörev.Click += new System.EventHandler(this.btnGörev_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCikis.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCikis.Location = new System.Drawing.Point(431, 23);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 35);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "X(Çıkış)";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmUlastirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(532, 392);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGörev);
            this.Controls.Add(this.btnAracList);
            this.Controls.Add(this.btnAracKayıt);
            this.Controls.Add(this.btnPerList);
            this.Controls.Add(this.btnPerKayit);
            this.Name = "FrmUlastirma";
            this.Text = "Ulaştırma Kayıt Sistemi";
            this.Load += new System.EventHandler(this.FrmUlastirma_Load);
            this.ResumeLayout(false);

        }

        

        private Button btnPerKayit;
        private Button btnPerList;
        private Button btnAracKayıt;
        private Button btnAracList;
        private Button btnGörev;
        private Button btnCikis;

        }

        #endregion

    }
