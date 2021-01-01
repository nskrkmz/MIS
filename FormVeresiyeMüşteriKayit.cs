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
    public partial class FormVeresiyeMüşteriKayit : Form
    {
        public FormVeresiyeMüşteriKayit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KullanıcıNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormVeresiyeMusteriSistemi vm = new FormVeresiyeMusteriSistemi();
            vm.StartPosition = FormStartPosition.Manual;
            vm.Left = 1150;
            vm.Top = 345;
            vm.Show();
        }
    }
}
