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
    public partial class FormStokGirisEkrani : Form
    {
        public FormStokGirisEkrani()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "C:";
            // bu kod ile her zaman C bölümünü açacaktır. Yani açıldığında C bölümünü gösterecek.
            file.Filter = "Text Dosyası |*.txt";
            file.FilterIndex = 2;
            file.ShowDialog();
        }

       
    }
}
