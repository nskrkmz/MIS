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

namespace MIS
{
    //merhabalar!
    public partial class FormSatisEkrani : Form
    {
        public FormSatisEkrani()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void FormSatisEkrani_Load(object sender, EventArgs e)
        {
            // Ödeme yöntemi checkbox aracıyla seçiliyor
            // Kod ile ekleme yapılmasının sebebi daha sonra veri tabanında daha rahat kullanılmasını sağlamak için yoksa normal ekleme de yapılabilir.
            string[] odemeYontemi = { "NAKİT", "KART" };
            comboBox1.Items.AddRange(odemeYontemi);
        }

        private void VeresiyeÖdemeButonu_Click(object sender, EventArgs e)
        {
            // Lokasyon ayarlamaları yapıldı
            FormVeresiyeMusteriSistemi vm= new FormVeresiyeMusteriSistemi();
            vm.StartPosition = FormStartPosition.Manual;
            //vm.Left = 1150;
            //vm.Top = 345;
            vm.Location = new Point((this.Location.X+675),(this.Location.Y+85));
            vm.Show(); 

            /*var i = Application.OpenForms.OfType<Form>().Select(x => x.Right).ToList().Max();
            FormVeresiyeMusteriSistemi vmd = new FormVeresiyeMusteriSistemi();
            vmd.StartPosition = FormStartPosition.Manual;
            vmd.Location = new Point(i, this.Location.Y);
            vmd.Location = new Point(i, this.Location.X);
            vmd.Show();*/

            /*FormVeresiyeMusteriSistemi vm = new FormVeresiyeMusteriSistemi();
            vm.Location = new Point(this.Location.Y);
            vm.Location = new Point(this.Location.X);
            vm.Show();*/

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

        private void label2_Click(object sender, EventArgs e)
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
                panel1.Visible = false;



            }
            else
            {
                MessageBox.Show("Yanlış ya da Eksik Şifre");
            }
        }
    }
}
