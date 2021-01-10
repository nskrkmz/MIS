using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Entity
{
    public class Musteri
    {
        [Key]
        public int musteriID { get; set; }
        public string musteriAlisverisTarihi { get; set; }
        public int fisNo { get; set; }
        public string musteriAd { get; set; }
        public string musteriSoyad { get; set; }
        public int musteriTel { get; set; }

        // İlişkiler Tanımlandı
        ///public ICollection<MusteriBorc> MusteriBorcs { get; set; }
        ///public ICollection<Fis> Fis { get; set; }

    }
}
