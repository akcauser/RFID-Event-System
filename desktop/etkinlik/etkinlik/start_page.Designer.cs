namespace etkinlik
{
    partial class Start_page
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_page));
            this.kayit_buton = new System.Windows.Forms.Button();
            this.yeniEtkinlik_button = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sertifikaListesiAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kayit_buton
            // 
            this.kayit_buton.BackColor = System.Drawing.Color.Lime;
            this.kayit_buton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.kayit_buton.Location = new System.Drawing.Point(52, 240);
            this.kayit_buton.Name = "kayit_buton";
            this.kayit_buton.Size = new System.Drawing.Size(201, 75);
            this.kayit_buton.TabIndex = 0;
            this.kayit_buton.Text = "KAYIT";
            this.kayit_buton.UseVisualStyleBackColor = false;
            this.kayit_buton.Click += new System.EventHandler(this.Kayit_buton_Click);
            // 
            // yeniEtkinlik_button
            // 
            this.yeniEtkinlik_button.BackColor = System.Drawing.Color.Tomato;
            this.yeniEtkinlik_button.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniEtkinlik_button.ForeColor = System.Drawing.Color.Black;
            this.yeniEtkinlik_button.Location = new System.Drawing.Point(281, 240);
            this.yeniEtkinlik_button.Name = "yeniEtkinlik_button";
            this.yeniEtkinlik_button.Size = new System.Drawing.Size(201, 75);
            this.yeniEtkinlik_button.TabIndex = 1;
            this.yeniEtkinlik_button.Text = "YENİ ETKİNLİK";
            this.yeniEtkinlik_button.UseVisualStyleBackColor = false;
            this.yeniEtkinlik_button.Click += new System.EventHandler(this.YeniEtkinlik_button_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Black;
            this.btn_kapat.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(339, 360);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(90, 44);
            this.btn_kapat.TabIndex = 2;
            this.btn_kapat.Text = "KAPAT";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.Btn_kapat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_sertifikaListesiAl
            // 
            this.btn_sertifikaListesiAl.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_sertifikaListesiAl.Font = new System.Drawing.Font("Trebuchet MS", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_sertifikaListesiAl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sertifikaListesiAl.Location = new System.Drawing.Point(512, 240);
            this.btn_sertifikaListesiAl.Name = "btn_sertifikaListesiAl";
            this.btn_sertifikaListesiAl.Size = new System.Drawing.Size(201, 75);
            this.btn_sertifikaListesiAl.TabIndex = 17;
            this.btn_sertifikaListesiAl.Text = "SERTİFİKA LİSTESİ AL";
            this.btn_sertifikaListesiAl.UseVisualStyleBackColor = false;
            this.btn_sertifikaListesiAl.Click += new System.EventHandler(this.Btn_sertifikaListesiAl_Click);
            // 
            // Start_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 416);
            this.Controls.Add(this.btn_sertifikaListesiAl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.yeniEtkinlik_button);
            this.Controls.Add(this.kayit_buton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start_page";
            this.Text = "IEEE İstanbul Üniversitesi Cerrahpaşa Etkinlik Takip Programı";
            this.Load += new System.EventHandler(this.Start_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kayit_buton;
        private System.Windows.Forms.Button yeniEtkinlik_button;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sertifikaListesiAl;
    }
}

