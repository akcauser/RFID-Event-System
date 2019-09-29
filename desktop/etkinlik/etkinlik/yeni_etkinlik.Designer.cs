namespace etkinlik
{
    partial class Yeni_etkinlik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yeni_etkinlik));
            this.etkinlik_adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oturum_sayisi = new System.Windows.Forms.ComboBox();
            this.sertifika_kosulu = new System.Windows.Forms.ComboBox();
            this.btn_etkinlikKaydet = new System.Windows.Forms.Button();
            this.btn_etkinlikKayitVazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etkinlik_adi
            // 
            this.etkinlik_adi.Location = new System.Drawing.Point(123, 84);
            this.etkinlik_adi.Name = "etkinlik_adi";
            this.etkinlik_adi.Size = new System.Drawing.Size(180, 20);
            this.etkinlik_adi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 18.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(74, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni etkinlik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Etkinlik adı gir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oturum sayısı seç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sertifika koşulu seç";
            // 
            // oturum_sayisi
            // 
            this.oturum_sayisi.FormattingEnabled = true;
            this.oturum_sayisi.Items.AddRange(new object[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10});
            this.oturum_sayisi.Location = new System.Drawing.Point(123, 117);
            this.oturum_sayisi.Name = "oturum_sayisi";
            this.oturum_sayisi.Size = new System.Drawing.Size(60, 21);
            this.oturum_sayisi.TabIndex = 7;
            // 
            // sertifika_kosulu
            // 
            this.sertifika_kosulu.FormattingEnabled = true;
            this.sertifika_kosulu.Items.AddRange(new object[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10});
            this.sertifika_kosulu.Location = new System.Drawing.Point(123, 153);
            this.sertifika_kosulu.Name = "sertifika_kosulu";
            this.sertifika_kosulu.Size = new System.Drawing.Size(60, 21);
            this.sertifika_kosulu.TabIndex = 8;
            // 
            // btn_etkinlikKaydet
            // 
            this.btn_etkinlikKaydet.BackColor = System.Drawing.Color.Blue;
            this.btn_etkinlikKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_etkinlikKaydet.ForeColor = System.Drawing.Color.Lavender;
            this.btn_etkinlikKaydet.Location = new System.Drawing.Point(160, 209);
            this.btn_etkinlikKaydet.Name = "btn_etkinlikKaydet";
            this.btn_etkinlikKaydet.Size = new System.Drawing.Size(119, 36);
            this.btn_etkinlikKaydet.TabIndex = 9;
            this.btn_etkinlikKaydet.Text = "Etkinliği kaydet";
            this.btn_etkinlikKaydet.UseVisualStyleBackColor = false;
            this.btn_etkinlikKaydet.Click += new System.EventHandler(this.Btn_etkinlikKaydet_Click);
            // 
            // btn_etkinlikKayitVazgec
            // 
            this.btn_etkinlikKayitVazgec.BackColor = System.Drawing.Color.Maroon;
            this.btn_etkinlikKayitVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_etkinlikKayitVazgec.ForeColor = System.Drawing.Color.Lavender;
            this.btn_etkinlikKayitVazgec.Location = new System.Drawing.Point(21, 209);
            this.btn_etkinlikKayitVazgec.Name = "btn_etkinlikKayitVazgec";
            this.btn_etkinlikKayitVazgec.Size = new System.Drawing.Size(119, 36);
            this.btn_etkinlikKayitVazgec.TabIndex = 10;
            this.btn_etkinlikKayitVazgec.Text = "Vazgeç";
            this.btn_etkinlikKayitVazgec.UseVisualStyleBackColor = false;
            this.btn_etkinlikKayitVazgec.Click += new System.EventHandler(this.Btn_etkinlikKayitVazgec_Click);
            // 
            // Yeni_etkinlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 304);
            this.Controls.Add(this.btn_etkinlikKayitVazgec);
            this.Controls.Add(this.btn_etkinlikKaydet);
            this.Controls.Add(this.sertifika_kosulu);
            this.Controls.Add(this.oturum_sayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.etkinlik_adi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Yeni_etkinlik";
            this.Text = "Yeni Etkinlik Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox etkinlik_adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox oturum_sayisi;
        private System.Windows.Forms.ComboBox sertifika_kosulu;
        private System.Windows.Forms.Button btn_etkinlikKaydet;
        private System.Windows.Forms.Button btn_etkinlikKayitVazgec;
    }
}