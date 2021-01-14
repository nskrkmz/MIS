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
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RQU3Q37;Initial Catalog=MIS_DB;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        MIS_DBDataContext dc = new MIS_DBDataContext();
        public FormRaporlamaEkranı()
        {
            InitializeComponent();
            dataGridView1.DataSource = dc.MusterisVeMusteriBorcs();
        }

        private void FormRaporlamaEkranı_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'mIS_DBDataSet.Musteris' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           

        }

        public void urunBazliKarZarar()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RQU3Q37;Initial Catalog=MIS_DB;Integrated Security=True");

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select urunAdi, urunYuzdeKar From Uruns", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["Urunler"].Points.AddXY(oku[0].ToString(), oku[1]);
            }
            baglanti.Close();
        }

        public void totalBorc()
        {

        }

        private void tabControl1_SelectIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPage1)
            {
                urunBazliKarZarar();
            }
            else if(tabControl1.SelectedTab == tabPage2 )
            {
                    
            }
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pnlKarZarar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
