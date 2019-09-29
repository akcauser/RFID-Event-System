namespace etkinlik
{
    partial class Baglanti_yap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baglanti_yap));
            this.kayit_baslat = new System.Windows.Forms.Button();
            this.comList = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_basaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kayit_baslat
            // 
            this.kayit_baslat.BackColor = System.Drawing.Color.Green;
            this.kayit_baslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.kayit_baslat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kayit_baslat.Location = new System.Drawing.Point(97, 135);
            this.kayit_baslat.Name = "kayit_baslat";
            this.kayit_baslat.Size = new System.Drawing.Size(127, 37);
            this.kayit_baslat.TabIndex = 1;
            this.kayit_baslat.Text = "Kayıt başlat";
            this.kayit_baslat.UseVisualStyleBackColor = false;
            this.kayit_baslat.Click += new System.EventHandler(this.Kayit_baslat_Click);
            // 
            // comList
            // 
            this.comList.FormattingEnabled = true;
            this.comList.Location = new System.Drawing.Point(63, 92);
            this.comList.Name = "comList";
            this.comList.Size = new System.Drawing.Size(187, 21);
            this.comList.TabIndex = 3;
            // 
            // btn_basaDon
            // 
            this.btn_basaDon.BackColor = System.Drawing.Color.Maroon;
            this.btn_basaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_basaDon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_basaDon.Location = new System.Drawing.Point(12, 12);
            this.btn_basaDon.Name = "btn_basaDon";
            this.btn_basaDon.Size = new System.Drawing.Size(99, 37);
            this.btn_basaDon.TabIndex = 4;
            this.btn_basaDon.Text = "Başa dön";
            this.btn_basaDon.UseVisualStyleBackColor = false;
            this.btn_basaDon.Click += new System.EventHandler(this.Btn_basaDon_Click);
            // 
            // Baglanti_yap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 228);
            this.Controls.Add(this.btn_basaDon);
            this.Controls.Add(this.comList);
            this.Controls.Add(this.kayit_baslat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Baglanti_yap";
            this.Text = "Bağlantı yap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button kayit_baslat;
        private System.Windows.Forms.ComboBox comList;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_basaDon;
    }
}