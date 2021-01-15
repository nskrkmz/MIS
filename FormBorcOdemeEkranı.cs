using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIS.Entity;
using System.Data.SqlClient;

namespace MIS
{
    public partial class FormBorcOdemeEkranı : Form
    {
        public FormBorcOdemeEkranı()
        {
            InitializeComponent();
            int fis = 0;
        }

        private void FormBorcOdemeEkranı_Load(object sender, EventArgs e)
        {
            guncelleme();
        }
        static string conString = "Data Source=DESKTOP-KGV1HQ5;Initial Catalog=MIS_DB;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);
        private void kayitGetir()
        {

            baglanti.Open();
            string kayit = "Select * from MusteriBorcs";

            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public void guncelleme()
        {
            kayitGetir();
            cbBorcluMustList.Items.Clear();
            SqlConnection baglanti = new SqlConnection();
            //SqlConnection baglanti2 = new SqlConnection();
            baglanti.ConnectionString = (@"Data Source=DESKTOP-KGV1HQ5;Initial Catalog=MIS_DB;Integrated Security=True");
            //baglanti2.ConnectionString = (@"Data Source=DESKTOP-KGV1HQ5;Initial Catalog=MIS_DB;Integrated Security=True");
            cbBorcluMustList.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut = baglanti.CreateCommand();
            komut.CommandType = CommandType.Text;
            komut.CommandText = "SELECT musteriBorcMusteriID FROM MusteriBorcs";
            komut.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            int total = 0;

            

            foreach (DataRow dr in dt.Rows)
            {
                cbBorcluMustList.Items.Add(dr["musteriBorcMusteriID"].ToString());


            }
            string[] items = cbBorcluMustList.Items.OfType<string>().Distinct().ToArray();
            cbBorcluMustList.Items.Clear();
            for (int i = 0; i < items.Length; i++)
            {
                cbBorcluMustList.Items.Add(items[i]);
            }

            baglanti.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbBorcOdemeMustList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBorcSorgula_Click(object sender, EventArgs e)
        {

        }

        private void cbBorcluMustList_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            var ad = cbBorcluMustList.SelectedItem;
            string kayit = "SELECT * from MusteriBorcs where musteriBorcMusteriID=@musteriBorcMusteriID";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@musteriBorcMusteriID", cbBorcluMustList.SelectedItem);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            //
            SqlConnection baglanti3 = new SqlConnection();
            baglanti3.ConnectionString = (@"Data Source=DESKTOP-KGV1HQ5;Initial Catalog=MIS_DB;Integrated Security=True");
            baglanti3.Open();
            string kayit2 = "SELECT musteriGuncelBorc from MusteriBorcs where musteriBorcMusteriID=@musteriBorcMusteriID";
            SqlCommand komut3 = new SqlCommand(kayit2, baglanti3);
            komut3.Parameters.AddWithValue("@musteriBorcMusteriID", cbBorcluMustList.SelectedItem);
            //komut3 = baglanti3.CreateCommand();
            //komut3.CommandType = CommandType.Text;
            //komut3.CommandText = "SELECT toplamTutar from Irsaliyes where irsaliyeTedarikciID=@irsaliyeTedarikciID";
            //komut2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(komut3);
            da2.Fill(dt2);
            int total = 0;
            txtBTotalBorc.Clear();
            
            foreach (DataRow dre in dt2.Rows)
            {
                total = total + (Convert.ToInt32(dre["musteriGuncelBorc"].ToString()));
                

                txtBTotalBorc.Text = Convert.ToString(total);
            }
            baglanti3.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Context cntx = new Context();
            BorcluMusteri borcMus = new BorcluMusteri();

            borcMus.borcluMusteriMusteriID = Convert.ToInt32(cbBorcluMustList.SelectedItem);
            borcMus.odenenMiktar = Convert.ToInt32(textBox1.Text);
            cntx.BorcluMusteris.Add(borcMus);
            cntx.SaveChanges();
            MessageBox.Show("ödeme gerçekleştirldi");

        }
    }
}
