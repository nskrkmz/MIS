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
    public partial class FormRaporlamaEkranı : Form
    {
        public FormRaporlamaEkranı()
        {
            InitializeComponent();
        }

        private void FormRaporlamaEkranı_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMusteriBazliRapor ubrg = new FormMusteriBazliRapor();
            ubrg.StartPosition = FormStartPosition.Manual;
            ubrg.Location = new Point((this.Location.X + 0), (this.Location.Y + 50));
            ubrg.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormSatisRaporu ubrg = new FormSatisRaporu();
            ubrg.StartPosition = FormStartPosition.Manual;
            ubrg.Location = new Point((this.Location.X + 0), (this.Location.Y + 50));
            ubrg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormKar_Zarar_Tarih_ ubrg = new FormKar_Zarar_Tarih_();
            ubrg.StartPosition = FormStartPosition.Manual;
            ubrg.Location = new Point((this.Location.X + 0), (this.Location.Y + 50));
            ubrg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUrunBazliRaporGraf ubrg = new FormUrunBazliRaporGraf();
            ubrg.StartPosition = FormStartPosition.Manual;
            ubrg.Location = new Point((this.Location.X + 0 ), (this.Location.Y + 50));
            ubrg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTotalBorcRaporu ubrg = new FormTotalBorcRaporu();
            ubrg.StartPosition = FormStartPosition.Manual;
            ubrg.Location = new Point((this.Location.X + 0), (this.Location.Y + 50));
            ubrg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormSatisTrendi ubrg = new FormSatisTrendi();
            ubrg.StartPosition = FormStartPosition.Manual;
            ubrg.Location = new Point((this.Location.X + 0), (this.Location.Y + 50));
            ubrg.Show();
        }
    }
}
