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
    public partial class FormVeresiyeMusteriSistemi : Form
    {
        public FormVeresiyeMusteriSistemi()
        {
            InitializeComponent();
        }

        private void FormVeresiyeMusteriSistemi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormVeresiyeMüşteriKayit vm = new FormVeresiyeMüşteriKayit();
            vm.StartPosition = FormStartPosition.Manual;
            vm.Left = 1150;
            vm.Top = 345;
            vm.Show();
        }
    }
}
