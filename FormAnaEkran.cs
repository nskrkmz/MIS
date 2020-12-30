using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIS.Entity;

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
            //Context cntxt =new Context();//Context sınıfından nesne yaratıldı
            //cntxt.Database.Create();//Veritabanı oluşturuldu

            FormMenu frmMenu = new FormMenu();
            frmMenu.MdiParent = this;
            frmMenu.Show();
        }

        
    

     


        

    }
}
