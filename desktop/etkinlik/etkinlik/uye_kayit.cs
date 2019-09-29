using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO.Ports;

namespace etkinlik
{
    public partial class Uye_kayit : Form
    {   
        
        OleDbConnection con;
        OleDbCommand cmd;
        
        public string comName { get; set; }

        public Uye_kayit()
        {
            InitializeComponent();

        }

        private void Btn_uyeKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_uyeAdi.Text.Trim()) || string.IsNullOrEmpty(txt_uyeSoyadi.Text.Trim()) || 
                    string.IsNullOrEmpty(txt_ogrenciNo.Text.Trim()) || lbl_gelenRfid.Text == "Kart okutulmadı")
            {
                MessageBox.Show("Hata: Lütfen bilgileri girdiğinizden emin olun!");
            }
            else
            {
                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=etkinlikdb.mdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into uye (adi, soyadi, ogrenci_no, rfid) values ('" + txt_uyeAdi.Text.Trim() + "','" + txt_uyeSoyadi.Text.Trim() + "','" + txt_ogrenciNo.Text.Trim() + "','" + lbl_gelenRfid.Text.Trim() + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                serialPortUyeKayit.Close();

                Kayit_yap kayit_yp = new Kayit_yap();
                kayit_yp.serialPort1.PortName = comName;
                kayit_yp.serialPort1.Open();
                kayit_yp.comName = comName;
                kayit_yp.Show();
                this.Close();
            }

            
        }

        

        private void SerialPortUyeKayit_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            lbl_gelenRfid.Text = serialPortUyeKayit.ReadLine(); 
        }

        private void Uye_kayit_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Btn_uyeKayitVazgec_Click(object sender, EventArgs e)
        {
            serialPortUyeKayit.Close();
            Kayit_yap kayit_Yap = new Kayit_yap();
            kayit_Yap.serialPort1.PortName = comName;
            kayit_Yap.comName = comName;
            kayit_Yap.serialPort1.Open();
            kayit_Yap.Show();
            this.Close();
        }
    }
}
