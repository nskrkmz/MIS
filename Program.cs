using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //düzenlenecek!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //Application.Run(new FormGirisEkrani());
            Application.Run(new FormAnaEkran());
            //Menu formu Anaekrana parent olarak eklendiği için kaldırıldı
            //Application.Run(new Menu());





        }
    }
}
