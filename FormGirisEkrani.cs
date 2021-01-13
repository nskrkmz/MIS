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
    public partial class FormGirisEkrani : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public FormGirisEkrani()
        {
            InitializeComponent();
            
        }
        




        private void Form1_Load(object sender, EventArgs e)
        {
            linkGithub.Text = "Kaynak kodu görüntüle : GitHub" ;
           

            linkGithub.Links.Add(24, 6, "https://github.com/nskrkmz/MIS");
            linkGithub.ForeColor = System.Drawing.Color.Aqua;

            //Linkleri mavi göster
            //linkLabel1.LinkColor = Color.DarkBlue;
            linkGithub.LinkColor = System.Drawing.ColorTranslator.FromHtml("#E48982");
            //Gezilmiş linkleri kırmızı göster
            linkGithub.VisitedLinkColor = Color.Blue;
            //Aktif linkleri kahverengi göster
            linkGithub.ActiveLinkColor = Color.Brown;
            //Linklerin altını fare üzerine geldiğinde çiz
            linkGithub.LinkBehavior = LinkBehavior.HoverUnderline;
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciID = KullaniciNoGiris.Text;
            string sifre = sifreGiris.Text;
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-B9HD7VV;Initial Catalog=MIS_DB;Integrated Security=True");
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM Calisans where calisanID='" + KullaniciNoGiris.Text + "' AND calisanSifre='" + sifreGiris.Text + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FormAnaEkran ae = new FormAnaEkran();
                ae.StartPosition = FormStartPosition.CenterScreen;
                ae.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı no veya şifrenizi kontrol ediniz!!");
            }
            baglanti.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            //Tıklanan linki ziyaret edilmiş renkle göster
            linkGithub.Links[linkGithub.Links.IndexOf(e.Link)].Visited = true;
            //Linki çalıştır
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void KullaniciNoGiris_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            FormGiriş_KayıtEkrani frmkyt = new FormGiriş_KayıtEkrani();
            frmkyt.StartPosition = FormStartPosition.Manual;
            frmkyt.Location = new Point((this.Location.X), (this.Location.Y));
            
            frmkyt.Show();
        }

        private void sifreGiris_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
