using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace etkinlik
{
    public partial class Baglanti_yap : Form
    {
        public Baglanti_yap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < System.IO.Ports.SerialPort.GetPortNames().Length; i++)
{
                comList.Items.Add(System.IO.Ports.SerialPort.GetPortNames()[i]);
            }
        }

        private void Kayit_baslat_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(comList.Text))
            {
                MessageBox.Show("Hata: Lütfen bağlantı portunu seçiniz!");
            }
            else
            {
                //MessageBox.Show("Item Selected is:" + comList.Text);
                Kayit_yap kayit_yp = new Kayit_yap();
                kayit_yp.serialPort1.PortName = comList.Text;
                kayit_yp.serialPort1.Open();
                kayit_yp.comName = comList.Text;
                kayit_yp.Show();
                this.Close();
            }

            
        }

        private void Btn_basaDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
