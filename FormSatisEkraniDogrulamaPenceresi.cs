using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS
{
    public partial class FormSatisEkraniDogrulamaPenceresi : Form
    {
        public FormSatisEkraniDogrulamaPenceresi()
        {
            InitializeComponent();
        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            FormSatisEkrani fse = new FormSatisEkrani(); //Oluşturduğum "FormSatisEkrani" isimli formun "fse" adında bir nesnesini oluşturuyorum.
            fse.Show(); //Butona basıldığında form satiş ekranı açılmasını sağlıyor.
            this.Hide();//Yeni form(FormSatisEkranı) açıldıktan sonra butonla açtığımız form olan "formsatisekranıdogrulamapenceresini" arkada gizliyor.
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormSatisEkraniDogrulamaPenceresi_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
