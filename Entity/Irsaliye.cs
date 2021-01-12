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
        public int irsaliyeSirasi { get; set; }
        public int irsaliyeNo { get; set; }
        public string irsaliyeTedarikciID { get; set; }
        public int irsaliyeUrunID { get; set; }
        public int birimFiyat { get; set; }
        public int miktar { get; set; }
        public int toplamTutar { get; set; }
        public string irsaliyeTarih { get; set; }

        // İlişkiler Tanımlandı
        ///public TedarikciBorc TedarikciBorc { get; set; }
        ///public Tedarikci Tedarikci { get; set; }
        //public Urun Urun { get; set; }

    }
}
