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
using MIS.Entity;

namespace MIS
{
    public partial class FormRaporlamaEkranı : Form
    {
        public FormRaporlamaEkranı()
        {
            InitializeComponent();
        }

        private void FormRaporlamaEkranı_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-B9HD7VV;Initial Catalog=MIS_DB;Integrated Security=True");

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select urunAdi, urunYuzdeKar From Uruns", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["Urunler"].Points.AddXY(oku[0].ToString(), oku[1]);
            }
            baglanti.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*FormMusteriBazliRapor ubrg = new FormMusteriBazliRapor();
            ubrg.StartPosition = FormStartPosition.Manual;
            ubrg.Location = new Point((this.Location.X + 0), (this.Location.Y + 50));
            ubrg.Show();*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*FormSatisRaporu ubrg = new FormSatisRaporu();
            ubrg.StartPosition = FormStartPosition.Manual;
            ubrg.Location = new Point((this.Location.X + 0), (this.Location.Y + 50));
            ubrg.Show();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*FormKar_Zarar_Tarih_ ubrg = new FormKar_Zarar_Tarih_();
            ubrg.StartPosition = FormStartPosition.Manual;
            ubrg.Location = new Point((this.Location.X + 0), (this.Location.Y + 50));
            ubrg.Show();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*FormUrunBazliRaporGraf ubrg = new FormUrunBazliRaporGraf();
            ubrg.StartPosition = FormStartPosition.Manual;
            ubrg.Location = new Point((this.Location.X + 0 ), (this.Location.Y + 50));
            ubrg.Show();*/


        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*FormTotalBorcRaporu ubrg = new FormTotalBorcRaporu();
            ubrg.StartPosition = FormStartPosition.Manual;
            ubrg.Location = new Point((this.Location.X + 0), (this.Location.Y + 50));
            ubrg.Show();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*FormSatisTrendi ubrg = new FormSatisTrendi();
            ubrg.StartPosition = FormStartPosition.Manual;
            ubrg.Location = new Point((this.Location.X + 0), (this.Location.Y + 50));
            ubrg.Show();*/
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
