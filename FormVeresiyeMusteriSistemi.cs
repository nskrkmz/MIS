﻿using System;
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

            FormVeresiyeMüşteriKayit vmk = new FormVeresiyeMüşteriKayit();
            vmk.StartPosition = FormStartPosition.Manual;
            vmk.Location = new Point((this.Location.X + 0), (this.Location.Y + 0));
            vmk.Show();
        }
    }
}
