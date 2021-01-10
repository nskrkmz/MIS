using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Entity
{
    public class Urun
    {
        [Key]
        public int urunID { get; set; }//Urun tablosun key'i urunID olarak tanımlandı

        public string urunDepoTarih { get; set; }
        public int urunAlisFiyat { get; set; }
        public int urunGr { get; set; }
        public string urunSTT { get; set; }
        public int urunIrsaliyeNo { get; set; }

        // İlişkiler Tanımlandı
        ///public Islem Islem { get; set; }
        ///public Depo Depo { get; set; }
        //public Irsaliye Irsaliye { get; set; }




    }
}
