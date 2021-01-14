using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIS.Entity;

namespace MIS
{
    
    public partial class FormAnaEkran : Form
    {
        
        public FormAnaEkran()
        {
            InitializeComponent();
            //this.IsMdiContainer = true; //form içinde form açılabilir yaptık 
        }

        private void FormAnaEkran_Load(object sender, EventArgs e)
        {
            //Context cntxt =new Context();//Context sınıfından nesne yaratıldı
            //cntxt.Database.Create();//Veritabanı oluşturuldu

         //   FormMenu frmMenu = new FormMenu();
          //  frmMenu.MdiParent = this;
            //frmMenu.Show();
        }

        private void FormGetir(Form frm)
        {
            frm.MdiParent = this;
            panel2.Controls.Add(frm);
            frm.Show();
        }
        private void btnSatis_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormSatisEkrani se = new FormSatisEkrani();
            FormGetir(se);
        }

        private void btnPersonelKayit_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormPersonelKayitEkrani pke = new FormPersonelKayitEkrani();
            FormGetir(pke);
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormRaporlamaEkranı re = new FormRaporlamaEkranı();
            FormGetir(re);
        }

        private void btnStokGiris_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormStokGirisEkrani sge = new FormStokGirisEkrani();
            FormGetir(sge);
        }

        private void btnBorcOdeme_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormBorcOdemeEkranı boe = new FormBorcOdemeEkranı();
            FormGetir(boe);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
