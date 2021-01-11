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
            
        }

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
            /*OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "C:";
            // bu kod ile her zaman C bölümünü açacaktır. Yani açıldığında C bölümünü gösterecek.
            file.Filter = "Text Dosyası |*.txt";
            file.FilterIndex = 2;*/



            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfileName = openFileDialog1.FileName;
                StreamReader strreadr = File.OpenText(@strfileName);//@strfileName = file path


                string metin;// metin = null
                MessageBox.Show("Yükleniyor !");
                while ((metin = strreadr.ReadLine()) != null) //metin=txt 1. satır,2.satır şeklinde değerleniyor(2 kez çalıştı)
                {
                    //string phrase = "The quick brown fox jumps over the lazy dog.";
                    string[] words = metin.Split(' ');
                    Urun urn = new Urun();
                    Context contxtt = new Context();
                    int islemOkuma = 0;
                    foreach (var word in words)
                    {
                        
                        if (islemOkuma == 0) //ıd oku
                        {
                            urn.urunID = Convert.ToInt32(word);
                            
                        }
                        if (islemOkuma == 1) // ad oku
                        {
                            urn.urunAdi = word;
                            
                        }
                        if (islemOkuma == 2)// depo tarih oku
                        {
                            urn.urunDepoTarih = word;
                            
                        }
                        if (islemOkuma == 3)//alış fiyat oku
                        {
                            urn.urunAlisFiyat = Convert.ToInt32(word);
                            
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
                            contxtt.SaveChanges();
                            
                        }
                        islemOkuma = islemOkuma + 1;
                        

                    }
                    if (islemOkuma == 10)
                    {
                        islemOkuma = 0;
                    }
                    
                }
                strreadr.Close();
                
                MessageBox.Show("Ürünler veri tabanına başarıyla eklendi !");


            }


        }
    }
}
