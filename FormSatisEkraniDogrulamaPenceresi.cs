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

    public partial class FormSatisEkraniDogrulamaPenceresi : Form
    {
        public FormSatisEkraniDogrulamaPenceresi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Giriş_Click(object sender, EventArgs e)
        {
            FormSatisEkrani fse = new FormSatisEkrani();
            fse.Show(); //Giriş butonuna basıldığında Satış ekranının açılmasını sağlar.
            this.Hide(); //Satış ekranı açıldıktan sonra doğrulama penceresini gizler kullanıcı kullandığı zaman herhangi bir sıkıntı yaratmaz.
        }

        private void FormSatisEkraniDogrulamaPenceresi_Load(object sender, EventArgs e)
        {

        }
    }
}
