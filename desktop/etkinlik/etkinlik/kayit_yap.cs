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
using System.IO.Ports;

//Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ertugrul\source\repos\etkinlik\etkinlik\etkinlikdb.mdb

namespace etkinlik
{
    public partial class Kayit_yap : Form
    {
        OleDbConnection con;
        DataSet ds;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        OleDbDataReader dr;

        private int giren_id = 0;
        private int secili_oturum = 0;
        private int seciliEtkinlikId = 0;

        public string rfid_kod_public;
        public string comName { get; set; }

        

        public Kayit_yap()
        {
            
            InitializeComponent();
            uye_listele();
            etkinlik_listele();
            lbl_rfid_kod.Text = "Kart okutulmadı";
            lbl_ad.Text = "Kart okutulmadı";
            lbl_soyad.Text = "Kart okutulmadı";


        }

        public void etkinlik_listele() {
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=etkinlikdb.mdb");
            con.Open();
            cmd = new OleDbCommand("SELECT id,adi FROM etkinlik", con);
            OleDbDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                hangi_etkinlik.Items.Add(dr.GetValue(1));    
            }
            con.Close();
        }

        public void oturum_sayisi_listele()
        {   
            
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=etkinlikdb.mdb");
            con.Open();
            cmd = new OleDbCommand("SELECT oturum_sayisi FROM etkinlik where id="+ seciliEtkinlikId + ";", con);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                for (int i = 0; i < (int)dr.GetValue(0); i++)
                {
                    hangi_oturum.Items.Add(i+1);
                }
            }
            con.Close();
        }
       
        public void uye_listele()
        {
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=etkinlikdb.mdb");
            da = new OleDbDataAdapter("SELECT adi AS ADI,soyadi AS SOYADI,ogrenci_no AS NUMARA FROM uye", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "uye");
            kayit_listesi.DataSource = ds.Tables["uye"];
            con.Close();

        }

        private void Hangi_etkinlik_SelectedIndexChanged(object sender, EventArgs e)
        {
            etkinlikIdBul();
            hangi_oturum.Items.Clear();
            oturum_sayisi_listele();
        }
        
        private void Btn_uyeKayit_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Uye_kayit uye_kyt = new Uye_kayit();
            uye_kyt.serialPortUyeKayit.PortName = comName;
            uye_kyt.serialPortUyeKayit.Open();
            uye_kyt.comName = comName;
            uye_kyt.Show();
            this.Close();
        }

        private void Btn_etkinligeKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hangi_etkinlik.Text) || string.IsNullOrEmpty(hangi_oturum.Text) || lbl_rfid_kod.Text == "Kart okutulmadı")
            {
                MessageBox.Show("Hata: Lütfen kartınızı okutup etkinlik ve oturumu seçiniz!");
            }
            else {
                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=etkinlikdb.mdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into katilim (katilan_uye_id, katildigi_oturum, katildigi_etkinlik_id) values (" + giren_id + "," + secili_oturum + "," + seciliEtkinlikId + ")";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kullanıcı girişi yapıldı");
                lbl_rfid_kod.Text = "Kart okutulmadı";
                lbl_ad.Text = "Kart okutulmadı";
                lbl_soyad.Text = "Kart okutulmadı";
            }
            
            
            
        }

        private void Kayit_yap_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string gelenKod = ((string)serialPort1.ReadLine()).Trim();
            lbl_rfid_kod.Text = gelenKod;

            try
            {
                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=etkinlikdb.mdb");
                con.Open();
                cmd = new OleDbCommand();
                cmd.Connection = con;
                //MessageBox.Show("#"+gelenKod+"#");
                cmd.CommandText = "SELECT * FROM uye WHERE rfid = '" + gelenKod + "';";
                dr = cmd.ExecuteReader();
             
                bool b = false;
                while (dr.Read())
                {
                    b = true;
                    giren_id = (int)dr.GetValue(0);
                    lbl_ad.Text = (string)dr.GetValue(1);
                    lbl_soyad.Text = (string)dr.GetValue(2);
                    //MessageBox.Show(dr.GetValue(0) + " - " + dr.GetValue(1) + " - " + dr.GetValue(2));
                }
                con.Close();
                if (!b)
                {
                    MessageBox.Show("Kullanıcı Kayıtlı Değil");

                    /*
                    Uye_kayit uye_kytPage = new Uye_kayit();
                    uye_kytPage.Show();
                    this.Hide();
                    */
                }
                 
                
                       
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex);
            }

            
        }

        private void Hangi_oturum_SelectedIndexChanged(object sender, EventArgs e)
        {
            secili_oturum = (int)hangi_oturum.SelectedItem;
        }

        private void etkinlikIdBul() {

            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=etkinlikdb.mdb");
            con.Open();
            cmd = new OleDbCommand("SELECT id FROM etkinlik where adi ='" + (hangi_etkinlik.SelectedItem) + "';", con);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                seciliEtkinlikId = (int)dr.GetValue(0);
            }
            con.Close();
        }

        private void Btn_baglantiEkraninaDon_Click(object sender, EventArgs e)
        {
            Baglanti_yap baglanti_Yap = new Baglanti_yap();
            baglanti_Yap.Show();
            this.Close();
        }

        
    }
}
