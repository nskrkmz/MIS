using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Entity
{
    public class Irsaliye
    {
        [Key]
        public int irsaliyeNo { get; set; }
        public int tedarikciID { get; set; }
        public int urunID { get; set; }
        public int birimFiyat { get; set; }
        public int miktar { get; set; }
        public int toplamTutar { get; set; }
        public string tarih { get; set; }

        // İlişkiler Tanımlandı
        ///public TedarikciBorc TedarikciBorc { get; set; }
        ///public Tedarikci Tedarikci { get; set; }
        //public Urun Urun { get; set; }

    }
}
