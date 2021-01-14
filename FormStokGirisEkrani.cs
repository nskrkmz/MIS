using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MIS.Entity;


namespace MIS
{
    public partial class FormStokGirisEkrani : Form
    {
        public FormStokGirisEkrani()
        {
            InitializeComponent();

            label5.Visible = false;
            label5.Hide();
            panel1.Visible = false;
            
        }
        static string conString = "Data Source=DESKTOP-KGV1HQ5;Initial Catalog=MIS_DB;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {


        }
        private void label5_Click(object sender, EventArgs e)
        {
            

        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "C:";
            // bu kod ile her zaman C bölümünü açacaktır. Yani açıldığında C bölümünü gösterecek.
            file.Filter = "Text Dosyası |*.txt";
            file.FilterIndex = 2;
            
            
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                 string strfileName = openFileDialog1.FileName;
                StreamReader strreadr = File.OpenText(@strfileName);//@strfileName = file path
                
                
                string metin;// metin = null
                while ((metin = strreadr.ReadLine()) != null) //metin=txt 1. satır,2.satır şeklinde değerleniyor(2 kez çalıştı)
                {
                    lBStokGoruntule.Items.Add(metin);
                }
                strreadr.Close();

                if (label5.Visible == false) // TXT dosyası görüntülenince içeriğin formatı yukarıda yazdırılacak
                {
                    label5.Visible = true;
                    label5.Show();
                }
                
            }
            
                

            
                



        }

        private void lBStokGoruntule_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnStogaIsle_Click(object sender, EventArgs e)
        {
           if (panel1.Visible==true)
            {

            }
           else
           {
                panel1.Visible = true;
                
           }


        }

        public void stokIsle()
        {
            panel1.Visible = true;



            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfileName = openFileDialog1.FileName;
                StreamReader strreadr = File.OpenText(@strfileName);//@strfileName = file path


                string metin;// metin = null
                MessageBox.Show("Yükleniyor !");
                Random rnd = new Random();
                int random = rnd.Next(1000);//irsaliye no için

                while ((metin = strreadr.ReadLine()) != null) //metin=txt 1. satır,2.satır şeklinde değerleniyor(2 kez çalıştı)
                {
                    //string phrase = "The quick brown fox jumps over the lazy dog.";
                    string[] words = metin.Split(' ');
                    Urun urn = new Urun();
                    Irsaliye irs = new Irsaliye();
                    TedarikciBorc tedborc = new TedarikciBorc();
                    Depo dpo = new Depo();
                    Context contxtt = new Context();
                    int islemOkuma = 0;
                    int total = 0;
                    foreach (var word in words)
                    {

                        if (islemOkuma == 0) //ıd oku
                        {
                            urn.urunID = Convert.ToInt32(word);
                            irs.irsaliyeUrunID = Convert.ToInt32(word);
                            irs.irsaliyeNo = random;
                            irs.irsaliyeTedarikciID = idTed.Text;
                            dpo.depoUrunID = Convert.ToInt32(word);
                            dpo.depoCalisanID = Convert.ToInt32(ıd.Text);
                            dpo.depoTedarikciID = Convert.ToInt32(idTed.Text);

                        }
                        if (islemOkuma == 1) // ad oku
                        {
                            urn.urunAdi = word;

                        }
                        if (islemOkuma == 2)// depo tarih oku
                        {
                            urn.urunDepoTarih = word;
                            irs.irsaliyeTarih = word;

                        }
                        if (islemOkuma == 3)//alış fiyat oku
                        {
                            urn.urunAlisFiyat = Convert.ToInt32(word);
                            irs.birimFiyat = Convert.ToInt32(word);
                            irs.miktar = 458;
                            dpo.urunAdet = 458;
                            irs.toplamTutar = Convert.ToInt32(word) * 458;
                            total = total + (458 * (Convert.ToInt32(word)));

                        }
                        if (islemOkuma == 4)//satış fiyat oku
                        {
                            urn.urunSatisFiyat = Convert.ToInt32(word);

                        }
                        if (islemOkuma == 5)// gr oku
                        {
                            urn.urunGr = Convert.ToInt32(word);

                        }
                        if (islemOkuma == 6)//stt oku
                        {
                            urn.urunSTT = word;

                        }
                        if (islemOkuma == 7)//irsaliye no oku
                        {
                            urn.urunIrsaliyeNo = Convert.ToInt32(word);

                        }
                        if (islemOkuma == 8)//kategori oku
                        {
                            urn.urunKategori = word;

                        }
                        if (islemOkuma == 9)//%kar oku
                        {
                            urn.urunYuzdeKar = Convert.ToInt32(word);

                            contxtt.Uruns.Add(urn); //son ekleme yapıldığı için değişiklikler db e eklendi
                            contxtt.Irsaliyes.Add(irs);
                            contxtt.Depos.Add(dpo);
                            contxtt.SaveChanges();

                        }
                        islemOkuma = islemOkuma + 1;


                    }


                    tedborc.tedarikciBorcIrsaliyeTutar = total;
                    tedborc.tedarikciBorcdurum = false;
                    tedborc.tedarikciBorcTedarikciID = idTed.Text;
                    tedborc.tedarikciBorcirsaliyeNo = random;


                    if (islemOkuma == 10)
                    {
                        islemOkuma = 0;
                    }

                }
                strreadr.Close();

                MessageBox.Show("Ürünler veri tabanına başarıyla eklendi !");
                panel1.Visible = false;


            }
        }

        private void FormStokGirisEkrani_Load(object sender, EventArgs e)
        {

            guncelleme();
        }
        public void guncelleme()
        {
            kayitGetir();
            cbTedarikciBorcSorgula.Items.Clear();
            SqlConnection baglanti = new SqlConnection();
            //SqlConnection baglanti2 = new SqlConnection();
            baglanti.ConnectionString = (@"Data Source=DESKTOP-KGV1HQ5;Initial Catalog=MIS_DB;Integrated Security=True");
            //baglanti2.ConnectionString = (@"Data Source=DESKTOP-KGV1HQ5;Initial Catalog=MIS_DB;Integrated Security=True");
            cbTedarikciBorcSorgula.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut = baglanti.CreateCommand();
            komut.CommandType = CommandType.Text;
            komut.CommandText = "SELECT irsaliyeTedarikciID FROM Irsaliyes";
            komut.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            int total = 0;

            /*
            SqlCommand komut2 = new SqlCommand();
            komut2 = baglanti2.CreateCommand();
            komut2.CommandType = CommandType.Text;
            komut2.CommandText = "SELECT toplamTutar FROM Irsaliyes";
            //komut2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            da2.Fill(dt2);
            foreach(DataRow dre in dt2.Rows)
            {
                total = total + (Convert.ToInt32(dre["toplamTutar"].ToString()));
                txtTedarikciTotalBorc.Text = Convert.ToString(total);
            }
            */

            foreach (DataRow dr in dt.Rows)
            {
                cbTedarikciBorcSorgula.Items.Add(dr["irsaliyeTedarikciID"].ToString());


            }
            string[] items = cbTedarikciBorcSorgula.Items.OfType<string>().Distinct().ToArray();
            cbTedarikciBorcSorgula.Items.Clear();
            for (int i = 0; i < items.Length; i++)
            {
                cbTedarikciBorcSorgula.Items.Add(items[i]);
            }

            baglanti.Close();
        }
        private void kayitGetir()
        {
            
            baglanti.Open();
            string kayit = "Select * from Irsaliyes";

            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cbTedarikciBorcSorgula_SelectedIndexChanged(object sender, EventArgs e)
        {

            baglanti.Open();
            var ad = cbTedarikciBorcSorgula.SelectedItem;
            string kayit = "SELECT * from Irsaliyes where irsaliyeTedarikciID=@irsaliyeTedarikciID";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@irsaliyeTedarikciID", cbTedarikciBorcSorgula.SelectedItem);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
            //
            SqlConnection baglanti3 = new SqlConnection();
            baglanti3.ConnectionString = (@"Data Source=DESKTOP-KGV1HQ5;Initial Catalog=MIS_DB;Integrated Security=True");
            baglanti3.Open();
            string kayit2 = "SELECT toplamTutar from Irsaliyes where irsaliyeTedarikciID=@irsaliyeTedarikciID";
            SqlCommand komut3 = new SqlCommand(kayit2,baglanti3);
            komut3.Parameters.AddWithValue("@irsaliyeTedarikciID", cbTedarikciBorcSorgula.SelectedItem);
            //komut3 = baglanti3.CreateCommand();
            //komut3.CommandType = CommandType.Text;
            //komut3.CommandText = "SELECT toplamTutar from Irsaliyes where irsaliyeTedarikciID=@irsaliyeTedarikciID";
            //komut2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(komut3);
            da2.Fill(dt2);
            int total = 0;
            txtTedarikciTotalBorc.Clear();
            foreach (DataRow dre in dt2.Rows)
            {
                total = total + (Convert.ToInt32(dre["toplamTutar"].ToString()));
                
                txtTedarikciTotalBorc.Text = Convert.ToString(total);
            }
            baglanti3.Close();
        }

        private void txtTedarikciTotalBorc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void ıd_TextChanged(object sender, EventArgs e)
        {

        }

        private void idTed_TextChanged(object sender, EventArgs e)
        {

        }

        private void stokonay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stokonay.Text=="123456")
            {
                
                stokIsle();

            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
                idTed.Clear();
                ıd.Clear();
                stokonay.Clear();
                


            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            guncelleme();
        }
    }
}
