using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace etkinlik
{
    public partial class Yeni_etkinlik : Form
    {
        OleDbConnection con;
        //OleDbDataAdapter da;
        OleDbCommand cmd;
        //DataSet ds;

        public Yeni_etkinlik()
        {
            InitializeComponent();
        }

        

        private void Btn_etkinlikKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oturum_sayisi.Text) || string.IsNullOrEmpty(sertifika_kosulu.Text) || string.IsNullOrEmpty(etkinlik_adi.Text))
            {
                MessageBox.Show("Lütfen bilgileri hepsini doldurunuz.");
            }
            else
            {
                try
                {
                    con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=etkinlikdb.mdb");
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into etkinlik (adi, oturum_sayisi, sertifika_kosulu) values ('" + etkinlik_adi.Text + "','" + oturum_sayisi.SelectedItem + "','" + sertifika_kosulu.SelectedItem + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Etkinlik eklendi");
                    this.Close();
                }
                catch (Exception ex) {
                    MessageBox.Show("Hata: Etkinlik kaydedilemedi. Tekrar dene. Hata kodu: "+ ex);
                }
            }

            

        }

        private void Btn_etkinlikKayitVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
