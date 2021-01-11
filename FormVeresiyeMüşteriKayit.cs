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
    public partial class FormVeresiyeMüşteriKayit : Form
    {
        public FormVeresiyeMüşteriKayit()
        {
            InitializeComponent();
        }

        private void FormVeresiyeMüşteriKayit_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KullanıcıNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMusAdSoy_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIslemTrh_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblMusAdSoy_Click(object sender, EventArgs e)
        {

        }

        private void txtIslemTarih_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMusteriTelNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            FormVeresiyeMusteriSistemi vm = new FormVeresiyeMusteriSistemi();
            vm.StartPosition = FormStartPosition.Manual;
            vm.Location = new Point((this.Location.X + 0), (this.Location.Y + 0));
            vm.Show();

            Musteri mus = new Musteri();
            Context cntx = new Context();

            mus.musteriAdSoyad= txtMusAdSoy.Text;
            mus.musteriTel = Convert.ToInt32(txtMusteriTelNo.Text);
            mus.musteriAlisverisTarihi = txtIslemTarih.Text;
            
            

            cntx.Musteris.Add(mus);
            cntx.SaveChanges();
            MessageBox.Show("Müşteri Başarıyla Kaydedildi !");

        }
    }
}
