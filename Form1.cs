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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "Kaynak kodu görüntüle : GitHub" ;
           

            linkLabel1.Links.Add(24, 6, "https://github.com/nskrkmz/MIS");
            linkLabel1.ForeColor = System.Drawing.Color.Aqua;

            //Linkleri mavi göster
            //linkLabel1.LinkColor = Color.DarkBlue;
            linkLabel1.LinkColor = System.Drawing.ColorTranslator.FromHtml("#E48982");
            //Gezilmiş linkleri kırmızı göster
            linkLabel1.VisitedLinkColor = Color.Blue;
            //Aktif linkleri kahverengi göster
            linkLabel1.ActiveLinkColor = Color.Brown;
            //Linklerin altını fare üzerine geldiğinde çiz
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            //Tıklanan linki ziyaret edilmiş renkle göster
            linkLabel1.Links[linkLabel1.Links.IndexOf(e.Link)].Visited = true;
            //Linki çalıştır
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
