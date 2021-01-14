using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MIS.Entity;

namespace MIS
{
    //merhabalar!
    public partial class FormSatisEkrani : Form
    {
        public FormSatisEkrani()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
        }

        static string conString = "Data Source=DESKTOP-KGV1HQ5;Initial Catalog=MIS_DB;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void FormSatisEkrani_Load(object sender, EventArgs e)
        {
            yukle();
        }
        public void yukle()
        {
            VeresiyeListesiCb.Items.Clear();
            comboBox2.Items.Clear();
            // Ödeme yöntemi checkbox aracıyla seçiliyor
            // Kod ile ekleme yapılmasının sebebi daha sonra veri tabanında daha rahat kullanılmasını sağlamak için yoksa normal ekleme de yapılabilir.
            string[] odemeYontemi = { "NAKİT", "KART" };
            comboBox1.Items.AddRange(odemeYontemi);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Musteris", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            int q = 0;
            while (read.Read())
            {
                VeresiyeListesiCb.Items.Add(read["musteriID"]);
                comboBox2.Items.Add(read["musteriAdSoyad"]);

            }

            baglanti.Close();
        }
        private void VeresiyeÖdemeButonu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            

        }

        private void NakitÖdemeYöntemiBut_Click(object sender, EventArgs e)
        {
            //Ödeme yöntemi gerçekleşince satış sisteme işlenecek.
        }

        private void KartÖdemeYöntemiBut_Click(object sender, EventArgs e)
        {
            //Ödeme yöntemi gerçekleşince satış sisteme işlenecek.
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            //barkodu okutulan ürün bu listeye eklenilecek
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSıl_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void OdemeYontemi_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                    listBox1.Items.Add(metin);
                }
                strreadr.Close();



            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "123456"))
            {
                MessageBox.Show("Ürün Silme Başarılı");
                listBox1.Items.Remove(listBox1.SelectedItem);
                textBox1.Clear();
                panel1.Visible = false;



            }
            else
            {
                MessageBox.Show("Yanlış ya da Eksik Şifre");
                textBox1.Clear();
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            //FormVeresiyeMusteriSistemi vm = new FormVeresiyeMusteriSistemi();
            //vm.StartPosition = FormStartPosition.Manual;
            //vm.Location = new Point((this.Location.X + 0), (this.Location.Y + 0));
            //vm.Show();

            Musteri mus = new Musteri();
            Context cntx = new Context();

            mus.musteriAdSoyad = txtMusAdSoy.Text;
            mus.musteriTel = Convert.ToInt32(txtMusteriTelNo.Text);
            mus.musteriAlisverisTarihi = txtIslemTarih.Text;



            cntx.Musteris.Add(mus);
            cntx.SaveChanges();
            MessageBox.Show("Müşteri Başarıyla Kaydedildi !");
            panel3.Visible = false;
            panel2.Visible = true;
            
            yukle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PeşinÖdemeButonu_Click(object sender, EventArgs e)
        {
            string[] veriler1 = new string[listBox1.Items.Count];
            string[] kelimeler;
            string[] idler = new string[listBox1.Items.Count];
            string[] fiyatlar_str = new string[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                veriler1[i] = listBox1.Items[i].ToString();
                kelimeler = veriler1[i].Split(' ');
                string v = kelimeler[0];
                string v2 = kelimeler[2];
                idler[i] = v.ToString();
                fiyatlar_str[i] = v2.ToString();

            }

            int[] fiyat_int = new int[listBox1.Items.Count];
            int x = 0;
            int toplam2 = 0;
            int tut = 0;
            foreach (string a in fiyatlar_str)
            {
                tut = Convert.ToInt32(a);
                toplam2 += tut;
            }
            int toplam = fiyat_int.Sum();
            textBox2.Text = Convert.ToString(toplam2);

            string[] datalar;
            int count = 0;
            for (int j = 0; j < veriler1.Length; j++)
            {
                datalar = veriler1[j].Split();
                Context cntxt = new Context();
                Islem islm = new Islem();
                
                if (count == 0)
                {
                    Fis fis = new Fis();
                    fis.islemTarihi = datalar[1];
                    fis.islemTutar = Convert.ToInt32(textBox2.Text);
                    if (comboBox1.SelectedItem == "NAKİT")
                    {
                        fis.odemeTipi = 1; // nakit ödeme
                    }
                    else
                    {
                        fis.odemeTipi = 0; // kartla ödeme
                    }
                    fis.fisMusteriID = 0; // peşin ödeme default değeri
                    cntxt.Fiss.Add(fis);
                    count = 1;
                }
                
                Random rastgele = new Random();
                //int fisNumara = rastgele.Next(1000);
                int fisNumara = 0;
                for(int i = 0; i < 10; i++)
                {
                    fisNumara = (rastgele.Next()); 
                }
                

                islm.islemFisNo = fisNumara;
                islm.islemUrunID = Convert.ToInt32(datalar[3]);
                islm.islemTarihi = datalar[1];
                
                
                cntxt.Islems.Add(islm);
                cntxt.SaveChanges();
                MessageBox.Show("Ödeme Gerçekleştirildi");


                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlisverisTamamla_Click(object sender, EventArgs e)
        {
            string[] veriler1 = new string[listBox1.Items.Count];
            string[] kelimeler;
            string[] idler = new string[listBox1.Items.Count];
            string[] fiyatlar_str = new string[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                veriler1[i] = listBox1.Items[i].ToString();
                kelimeler = veriler1[i].Split(' ');
                string v = kelimeler[0];
                string v2 = kelimeler[2];
                idler[i] = v.ToString();
                fiyatlar_str[i] = v2.ToString();

            }

            int[] fiyat_int = new int[listBox1.Items.Count];
            int x = 0;
            int toplam2 = 0;
            int tut = 0;
            foreach (string a in fiyatlar_str)
            {
                tut = Convert.ToInt32(a);
                toplam2 += tut;
            }
            int toplam = fiyat_int.Sum();
            textBox2.Text = Convert.ToString(toplam2);

            string[] datalar;
            int count = 0;
            for (int j = 0; j < veriler1.Length; j++)
            {
                datalar = veriler1[j].Split();
                Context cntxt = new Context();
                Islem islm = new Islem();
                MusteriBorc mstBrc = new MusteriBorc();

                if (count == 0)
                {
                    Fis fis = new Fis();
                    fis.islemTarihi = datalar[1];
                    fis.islemTutar = Convert.ToInt32(textBox2.Text);
                    if (comboBox1.SelectedItem == "NAKİT")
                    {
                        fis.odemeTipi = 1; // nakit ödeme
                    }
                    else if(comboBox1.SelectedItem == "KART")
                    {
                        fis.odemeTipi = 0; // kartla ödeme
                    }
                    else {
                        fis.odemeTipi = 2; // veresiye işlem default değer
                    }
                    fis.fisMusteriID = Convert.ToInt32(VeresiyeListesiCb.SelectedItem); // peşin ödeme default değeri
                    
                    mstBrc.musteriBorcDurum = false;
                    mstBrc.musteriBorcFisNo = count + 1;
                    mstBrc.musteriBorcMusteriID = Convert.ToInt32(VeresiyeListesiCb.SelectedItem);
                    mstBrc.musteriGuncelBorc = Convert.ToInt32(textBox2.Text);
                    mstBrc.odenenMiktar = 0;

                    cntxt.Fiss.Add(fis);
                    cntxt.MusteriBorcs.Add(mstBrc);
                    count = 1;


                }

                Random rastgele = new Random();
                //int fisNumara = rastgele.Next(1000);
                int fisNumara = 0;
                for (int i = 0; i < 10; i++)
                {
                    fisNumara = (rastgele.Next());
                }


                islm.islemFisNo = fisNumara;
                islm.islemUrunID = Convert.ToInt32(datalar[3]);
                islm.islemTarihi = datalar[1];


                cntxt.Islems.Add(islm);
                cntxt.SaveChanges();
                



            }
            MessageBox.Show("Veresiye Satış Gerçekleştirildi");

        }

        private void VeresiyeListesiCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            VeresiyeListesiCb.SelectedIndex= comboBox2.SelectedIndex ;
        }

        private void txtMusAdSoy_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            VeresiyeListesiCb.SelectedIndex =comboBox2.SelectedIndex ;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
