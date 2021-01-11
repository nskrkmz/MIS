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
        public int musteriFisNo { get; set; }
        public string musteriAdSoyad { get; set; }
        public int musteriTel { get; set; }

        // İlişkiler Tanımlandı
        ///public ICollection<MusteriBorc> MusteriBorcs { get; set; }
        ///public ICollection<Fis> Fis { get; set; }

    }
}
