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
    public partial class FormAnaEkran : Form
    {
        public FormAnaEkran()
        {
            InitializeComponent();
            this.IsMdiContainer = true; //form içinde form açılabilir yaptık 
        }

        private void FormAnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();//açılacak form
            frmMenu.MdiParent = this;//bu formu parent olarak veriyoruz
            frmMenu.Show();
            
        }

    }
}
