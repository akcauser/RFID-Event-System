namespace etkinlik
{
    partial class Uye_kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uye_kayit));
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_uyeAdi = new System.Windows.Forms.TextBox();
            this.txt_uyeSoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ogrenciNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_gelenRfid = new System.Windows.Forms.Label();
            this.btn_uyeKaydet = new System.Windows.Forms.Button();
            this.serialPortUyeKayit = new System.IO.Ports.SerialPort(this.components);
            this.btn_uyeKayitVazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(200, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(136, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "ADI :";
            // 
            // txt_uyeAdi
            // 
            this.txt_uyeAdi.Location = new System.Drawing.Point(200, 161);
            this.txt_uyeAdi.Multiline = true;
            this.txt_uyeAdi.Name = "txt_uyeAdi";
            this.txt_uyeAdi.Size = new System.Drawing.Size(209, 30);
            this.txt_uyeAdi.TabIndex = 10;
            // 
            // txt_uyeSoyadi
            // 
            this.txt_uyeSoyadi.Location = new System.Drawing.Point(200, 216);
            this.txt_uyeSoyadi.Multiline = true;
            this.txt_uyeSoyadi.Name = "txt_uyeSoyadi";
            this.txt_uyeSoyadi.Size = new System.Drawing.Size(209, 30);
            this.txt_uyeSoyadi.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(200, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(91, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "SOYADI :";
            // 
            // txt_ogrenciNo
            // 
            this.txt_ogrenciNo.Location = new System.Drawing.Point(200, 267);
            this.txt_ogrenciNo.Multiline = true;
            this.txt_ogrenciNo.Name = "txt_ogrenciNo";
            this.txt_ogrenciNo.Size = new System.Drawing.Size(209, 30);
            this.txt_ogrenciNo.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(200, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "ÖĞRENCİ NO :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.75F);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(150, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 39);
            this.label9.TabIndex = 17;
            this.label9.Text = "YENİ ÜYE KAYIT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(71, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "RFID KOD :";
            // 
            // lbl_gelenRfid
            // 
            this.lbl_gelenRfid.AutoSize = true;
            this.lbl_gelenRfid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gelenRfid.Location = new System.Drawing.Point(200, 344);
            this.lbl_gelenRfid.Name = "lbl_gelenRfid";
            this.lbl_gelenRfid.Size = new System.Drawing.Size(161, 25);
            this.lbl_gelenRfid.TabIndex = 19;
            this.lbl_gelenRfid.Text = "Kart okutulmadı";
            // 
            // btn_uyeKaydet
            // 
            this.btn_uyeKaydet.BackColor = System.Drawing.Color.Blue;
            this.btn_uyeKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_uyeKaydet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_uyeKaydet.Location = new System.Drawing.Point(262, 429);
            this.btn_uyeKaydet.Name = "btn_uyeKaydet";
            this.btn_uyeKaydet.Size = new System.Drawing.Size(184, 49);
            this.btn_uyeKaydet.TabIndex = 20;
            this.btn_uyeKaydet.Text = "KAYDET";
            this.btn_uyeKaydet.UseVisualStyleBackColor = false;
            this.btn_uyeKaydet.Click += new System.EventHandler(this.Btn_uyeKaydet_Click);
            // 
            // serialPortUyeKayit
            // 
            this.serialPortUyeKayit.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPortUyeKayit_DataReceived);
            // 
            // btn_uyeKayitVazgec
            // 
            this.btn_uyeKayitVazgec.BackColor = System.Drawing.Color.Maroon;
            this.btn_uyeKayitVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_uyeKayitVazgec.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_uyeKayitVazgec.Location = new System.Drawing.Point(33, 429);
            this.btn_uyeKayitVazgec.Name = "btn_uyeKayitVazgec";
            this.btn_uyeKayitVazgec.Size = new System.Drawing.Size(184, 49);
            this.btn_uyeKayitVazgec.TabIndex = 21;
            this.btn_uyeKayitVazgec.Text = "VAZGEÇ";
            this.btn_uyeKayitVazgec.UseVisualStyleBackColor = false;
            this.btn_uyeKayitVazgec.Click += new System.EventHandler(this.Btn_uyeKayitVazgec_Click);
            // 
            // Uye_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 542);
            this.Controls.Add(this.btn_uyeKayitVazgec);
            this.Controls.Add(this.btn_uyeKaydet);
            this.Controls.Add(this.lbl_gelenRfid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_ogrenciNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_uyeSoyadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_uyeAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Uye_kayit";
            this.Text = "Üye Kayıt";
            this.Load += new System.EventHandler(this.Uye_kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_uyeAdi;
        private System.Windows.Forms.TextBox txt_uyeSoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ogrenciNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_gelenRfid;
        private System.Windows.Forms.Button btn_uyeKaydet;
        public System.IO.Ports.SerialPort serialPortUyeKayit;
        private System.Windows.Forms.Button btn_uyeKayitVazgec;
    }
}