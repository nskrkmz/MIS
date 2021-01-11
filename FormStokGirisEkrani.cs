using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS
{
    public partial class FormStokGirisEkrani : Form
    {
        public FormStokGirisEkrani()
        {
            InitializeComponent();
            label5.Visible = false;
            label5.Hide();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {


        }
        private void label5_Click(object sender, EventArgs e)
        {
            

        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "D:";
            // bu kod ile her zaman C bölümünü açacaktır. Yani açıldığında C bölümünü gösterecek.
            file.Filter = "Text Dosyası |*.txt";
            file.FilterIndex = 2;
            
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                 string strfileName = openFileDialog1.FileName;
                StreamReader strreadr = File.OpenText(@strfileName);
                string metin;
                while ((metin = strreadr.ReadLine()) != null)
                {
                    lBStokGoruntule.Items.Add(metin);
                }
                strreadr.Close();

                if (label5.Visible == false)
                {
                    label5.Visible = true;
                    label5.Show();
                }
            }
            
                

            
                



        }

        private void lBStokGoruntule_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
