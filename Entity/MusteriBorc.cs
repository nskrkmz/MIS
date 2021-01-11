using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Entity
{
     public class MusteriBorc
    {
        [Key]
        public int musteriBorcMusteriID { get; set; }
        public int musteriBorcFisNo { get; set; }
        public int musteriBorcCalisanID { get; set; }
        public int musteriGuncelBorc { get; set; } // Kalan borc
        public bool musteriBorcDurum { get; set; }

        // İlişkiler Tanımlandı
        ///public ICollection<Fis> Fis { get; set; }
        ///public ICollection<Calisan> Calisans { get; set; }
        ///public Musteri Musteri { get; set; }

    }
}
