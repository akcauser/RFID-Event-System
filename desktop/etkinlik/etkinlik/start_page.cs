using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etkinlik
{
    public partial class Start_page : Form
    {
        public Start_page()
        {
            InitializeComponent();
        }

        private void Start_page_Load(object sender, EventArgs e)
        {

        }

        private void Kayit_buton_Click(object sender, EventArgs e)
        {
            Baglanti_yap baglanti_yp = new Baglanti_yap();
            baglanti_yp.Show();
            
        }

        private void YeniEtkinlik_button_Click(object sender, EventArgs e)
        {
            Yeni_etkinlik yeni_etk = new Yeni_etkinlik();
            yeni_etk.Show();
            
        }
        
        private void Btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_sertifikaListesiAl_Click(object sender, EventArgs e)
        {
            Sertifika_Listesi sertifika_Listesi = new Sertifika_Listesi();
            sertifika_Listesi.Show();
        }
    }
}
