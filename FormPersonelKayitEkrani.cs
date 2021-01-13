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
    public partial class FormPersonelKayitEkrani : Form
    {
        public FormPersonelKayitEkrani()
        {
            InitializeComponent();
        }

        private void FormPersonelKayitEkrani_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calisan clsn = new Calisan();
            Context cntx = new Context();

            clsn.calisanAdSoyad = textBox1.Text;
            clsn.calisanGorev = textBox3.Text;
            clsn.calisanMaas = Convert.ToInt32(textBox4.Text);
            clsn.calisanSifre = textBox5.Text;

            cntx.Calisans.Add(clsn);
            cntx.SaveChanges();
            MessageBox.Show("Çalışan Başarıyla Kaydedildi !");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
