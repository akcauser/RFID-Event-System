using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etkinlik
{
    public partial class Sertifika_Listesi : Form
    {

        OleDbConnection con;
        DataSet ds;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public Sertifika_Listesi()
        {
            InitializeComponent();
        }

        

        private void Hangi_etkinlik_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=etkinlikdb.mdb");
            da = new OleDbDataAdapter("select * from katilim", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "katilim");
            list_sertifika.DataSource = ds.Tables["katilim"];
            con.Close();
        }
    }
}
