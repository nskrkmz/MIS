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
            Context cntxt =new Context();//Context sınıfından nesne yaratıldı
            cntxt.Database.Create();//Veritabanı oluşturuldu

         //   FormMenu frmMenu = new FormMenu();
          //  frmMenu.MdiParent = this;
            //frmMenu.Show();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            FormSatisEkrani se = new FormSatisEkrani();
            se.StartPosition = FormStartPosition.Manual;
            se.Location = new Point((this.Location.X + 250), (this.Location.Y + 2));
            se.Show();
        }

        private void btnPersonelKayit_Click(object sender, EventArgs e)
        {
            FormPersonelKayitEkrani pke = new FormPersonelKayitEkrani();
            pke.StartPosition = FormStartPosition.Manual;
            pke.Location = new Point((this.Location.X + 250), (this.Location.Y + 2));
            pke.Show();
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            FormRaporlamaEkranı re = new FormRaporlamaEkranı();
            re.StartPosition = FormStartPosition.Manual;
            re.Location = new Point((this.Location.X + 257), (this.Location.Y + 100));
            re.Show();
        }

        private void btnStokGiris_Click(object sender, EventArgs e)
        {
            FormStokGirisEkrani sge = new FormStokGirisEkrani();
            sge.StartPosition = FormStartPosition.Manual;
            sge.Location = new Point((this.Location.X + 257), (this.Location.Y + 100));
            sge.Show();
        }

        private void btnBorcOdeme_Click(object sender, EventArgs e)
        {
            FormBorcOdemeEkranı boe = new FormBorcOdemeEkranı();
            boe.StartPosition = FormStartPosition.Manual;
            boe.Location = new Point((this.Location.X + 257), (this.Location.Y + 100));
            boe.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
