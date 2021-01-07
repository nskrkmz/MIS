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
            // Lokasyon ayarlamaları yapıldı
            FormVeresiyeMusteriSistemi vm= new FormVeresiyeMusteriSistemi();
            vm.StartPosition = FormStartPosition.Manual;
            //vm.Left = 1150;
            //vm.Top = 345;
            vm.Location = new Point((this.Location.X+675),(this.Location.Y+30));
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

        }
    }
}
