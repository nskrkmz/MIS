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
    public partial class FormGiriş_KayıtEkrani : Form
    {
        public FormGiriş_KayıtEkrani()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Calisan clsn = new Calisan();
            Context cntx = new Context();

            clsn.calisanAdSoyad = txtAdSoyad.Text;
            clsn.calisanGorev = txtGorev.Text;
            clsn.calisanMaas = Convert.ToInt32(txtMaas.Text);
            clsn.calisanSifre = txtSifre.Text;

            cntx.Calisans.Add(clsn);
            cntx.SaveChanges();
            MessageBox.Show("Çalışan Başarıyla Kaydedildi !");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtGorev_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtMaas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
