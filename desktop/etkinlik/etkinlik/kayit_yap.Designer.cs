﻿namespace etkinlik
{
    partial class Kayit_yap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayit_yap));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_rfid_kod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.btn_etkinligeKaydet = new System.Windows.Forms.Button();
            this.hangi_etkinlik = new System.Windows.Forms.ComboBox();
            this.hangi_oturum = new System.Windows.Forms.ComboBox();
            this.kayit_listesi = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_uyeKayit = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_baglantiEkraninaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kayit_listesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(105, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "RFID KOD :";
            // 
            // lbl_rfid_kod
            // 
            this.lbl_rfid_kod.AutoSize = true;
            this.lbl_rfid_kod.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_rfid_kod.Location = new System.Drawing.Point(234, 92);
            this.lbl_rfid_kod.Name = "lbl_rfid_kod";
            this.lbl_rfid_kod.Size = new System.Drawing.Size(132, 27);
            this.lbl_rfid_kod.TabIndex = 1;
            this.lbl_rfid_kod.Text = "0003272531";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(227, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "ÖĞRENCİ KARTINIZI OKUTUN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(170, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "ADI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(125, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "SOYADI :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(41, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "HANGİ ETKİNLİK :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(41, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "HANGİ OTURUM :";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_ad.Location = new System.Drawing.Point(234, 147);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(139, 27);
            this.lbl_ad.TabIndex = 7;
            this.lbl_ad.Text = "Ertuğrul Gazi";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_soyad.Location = new System.Drawing.Point(234, 191);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(59, 27);
            this.lbl_soyad.TabIndex = 8;
            this.lbl_soyad.Text = "Akça";
            // 
            // btn_etkinligeKaydet
            // 
            this.btn_etkinligeKaydet.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_etkinligeKaydet.Font = new System.Drawing.Font("Trebuchet MS", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_etkinligeKaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_etkinligeKaydet.Location = new System.Drawing.Point(232, 348);
            this.btn_etkinligeKaydet.Name = "btn_etkinligeKaydet";
            this.btn_etkinligeKaydet.Size = new System.Drawing.Size(251, 34);
            this.btn_etkinligeKaydet.TabIndex = 9;
            this.btn_etkinligeKaydet.Text = "KAYIT AL";
            this.btn_etkinligeKaydet.UseVisualStyleBackColor = false;
            this.btn_etkinligeKaydet.Click += new System.EventHandler(this.Btn_etkinligeKaydet_Click);
            // 
            // hangi_etkinlik
            // 
            this.hangi_etkinlik.FormattingEnabled = true;
            this.hangi_etkinlik.Location = new System.Drawing.Point(239, 235);
            this.hangi_etkinlik.Name = "hangi_etkinlik";
            this.hangi_etkinlik.Size = new System.Drawing.Size(212, 21);
            this.hangi_etkinlik.TabIndex = 10;
            this.hangi_etkinlik.SelectedIndexChanged += new System.EventHandler(this.Hangi_etkinlik_SelectedIndexChanged);
            // 
            // hangi_oturum
            // 
            this.hangi_oturum.FormattingEnabled = true;
            this.hangi_oturum.Location = new System.Drawing.Point(239, 278);
            this.hangi_oturum.Name = "hangi_oturum";
            this.hangi_oturum.Size = new System.Drawing.Size(212, 21);
            this.hangi_oturum.TabIndex = 11;
            this.hangi_oturum.SelectedIndexChanged += new System.EventHandler(this.Hangi_oturum_SelectedIndexChanged);
            // 
            // kayit_listesi
            // 
            this.kayit_listesi.AllowUserToAddRows = false;
            this.kayit_listesi.AllowUserToDeleteRows = false;
            this.kayit_listesi.AllowUserToResizeColumns = false;
            this.kayit_listesi.AllowUserToResizeRows = false;
            this.kayit_listesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kayit_listesi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kayit_listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kayit_listesi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kayit_listesi.Location = new System.Drawing.Point(537, 92);
            this.kayit_listesi.MultiSelect = false;
            this.kayit_listesi.Name = "kayit_listesi";
            this.kayit_listesi.ReadOnly = true;
            this.kayit_listesi.Size = new System.Drawing.Size(343, 334);
            this.kayit_listesi.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(629, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "KAYIT LİSTESİ";
            // 
            // btn_uyeKayit
            // 
            this.btn_uyeKayit.BackColor = System.Drawing.Color.Olive;
            this.btn_uyeKayit.Font = new System.Drawing.Font("Trebuchet MS", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_uyeKayit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_uyeKayit.Location = new System.Drawing.Point(32, 348);
            this.btn_uyeKayit.Name = "btn_uyeKayit";
            this.btn_uyeKayit.Size = new System.Drawing.Size(173, 34);
            this.btn_uyeKayit.TabIndex = 14;
            this.btn_uyeKayit.Text = "ÜYE KAYIT";
            this.btn_uyeKayit.UseVisualStyleBackColor = false;
            this.btn_uyeKayit.Click += new System.EventHandler(this.Btn_uyeKayit_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // btn_baglantiEkraninaDon
            // 
            this.btn_baglantiEkraninaDon.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_baglantiEkraninaDon.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baglantiEkraninaDon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_baglantiEkraninaDon.Location = new System.Drawing.Point(12, 12);
            this.btn_baglantiEkraninaDon.Name = "btn_baglantiEkraninaDon";
            this.btn_baglantiEkraninaDon.Size = new System.Drawing.Size(109, 42);
            this.btn_baglantiEkraninaDon.TabIndex = 15;
            this.btn_baglantiEkraninaDon.Text = "PORT Düzenle";
            this.btn_baglantiEkraninaDon.UseVisualStyleBackColor = false;
            this.btn_baglantiEkraninaDon.Click += new System.EventHandler(this.Btn_baglantiEkraninaDon_Click);
            // 
            // Kayit_yap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.btn_baglantiEkraninaDon);
            this.Controls.Add(this.btn_uyeKayit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.kayit_listesi);
            this.Controls.Add(this.hangi_oturum);
            this.Controls.Add(this.hangi_etkinlik);
            this.Controls.Add(this.btn_etkinligeKaydet);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_rfid_kod);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kayit_yap";
            this.Text = "Kayıt yap";
            this.Load += new System.EventHandler(this.Kayit_yap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kayit_listesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Button btn_etkinligeKaydet;
        private System.Windows.Forms.ComboBox hangi_etkinlik;
        private System.Windows.Forms.ComboBox hangi_oturum;
        private System.Windows.Forms.DataGridView kayit_listesi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_uyeKayit;
        public System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.Label lbl_rfid_kod;
        private System.Windows.Forms.Button btn_baglantiEkraninaDon;
    }
}