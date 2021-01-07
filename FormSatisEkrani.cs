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
    //merhabalar!
    public partial class FormSatisEkrani : Form
    {
        public FormSatisEkrani()
        {
            InitializeComponent();
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
                FormVeresiyeMusteriSistemi vm= new FormVeresiyeMusteriSistemi();
                vm.StartPosition = FormStartPosition.Manual;
                vm.Left = 1150;
                vm.Top = 345;
                vm.Show();  
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

        }
    }
}
