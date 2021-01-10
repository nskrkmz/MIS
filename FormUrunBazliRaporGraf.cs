using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MIS
{
    public partial class FormUrunBazliRaporGraf : Form
    {
        public FormUrunBazliRaporGraf()
        {
            InitializeComponent();
        }

        private void FormUrunBazliRaporGraf_Load(object sender, EventArgs e)
        {
            /*SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RQU3Q37;Initial Catalog=MIS_DB;Integrated Security=True");

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select urunAd, urunYuzdeKar From Uruns", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["Urunler"].Points.AddXY(oku[0].ToString(), oku[1]);
            }
            baglanti.Close();*/
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
