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
        public int barkodNumarasi{ get; set; }
        public int urunID { get; set; }
        public string urunAdi { get; set; }
        public string urunDepoTarih { get; set; }
        public float urunAlisFiyat { get; set; }
        public float urunSatisFiyat { get; set; }
        public float urunGr { get; set; }
        public string urunSTT { get; set; }
        public int urunIrsaliyeNo { get; set; }
        public string urunKategori { get; set; }
        public float urunYuzdeKar { get; set; }

        // İlişkiler Tanımlandı
        ///public Islem Islem { get; set; }
        ///public Depo Depo { get; set; }
        //public Irsaliye Irsaliye { get; set; }




    }
}
