namespace etkinlik
{
    partial class Sertifika_Listesi
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
            this.label9 = new System.Windows.Forms.Label();
            this.list_sertifika = new System.Windows.Forms.DataGridView();
            this.hangi_etkinlik = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.list_sertifika)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(386, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "SERTİFİKA LİSTESİ";
            // 
            // list_sertifika
            // 
            this.list_sertifika.AllowUserToAddRows = false;
            this.list_sertifika.AllowUserToDeleteRows = false;
            this.list_sertifika.AllowUserToResizeColumns = false;
            this.list_sertifika.AllowUserToResizeRows = false;
            this.list_sertifika.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.list_sertifika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.list_sertifika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_sertifika.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.list_sertifika.Location = new System.Drawing.Point(341, 79);
            this.list_sertifika.MultiSelect = false;
            this.list_sertifika.Name = "list_sertifika";
            this.list_sertifika.ReadOnly = true;
            this.list_sertifika.Size = new System.Drawing.Size(318, 375);
            this.list_sertifika.TabIndex = 14;
            // 
            // hangi_etkinlik
            // 
            this.hangi_etkinlik.FormattingEnabled = true;
            this.hangi_etkinlik.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.hangi_etkinlik.Location = new System.Drawing.Point(51, 79);
            this.hangi_etkinlik.Name = "hangi_etkinlik";
            this.hangi_etkinlik.Size = new System.Drawing.Size(212, 21);
            this.hangi_etkinlik.TabIndex = 17;
            this.hangi_etkinlik.SelectedIndexChanged += new System.EventHandler(this.Hangi_etkinlik_SelectedIndexChanged);
            // 
            // Sertifika_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 478);
            this.Controls.Add(this.hangi_etkinlik);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.list_sertifika);
            this.Name = "Sertifika_Listesi";
            this.Text = "Sertifika Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.list_sertifika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView list_sertifika;
        private System.Windows.Forms.ComboBox hangi_etkinlik;
    }
}