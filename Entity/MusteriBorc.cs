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
        public int musteriID { get; set; }
        public int fisNo { get; set; }
        public int calisanID { get; set; }
        public bool durum { get; set; }

        // İlişkiler Tanımlandı
        public ICollection<Fis> Fis { get; set; }
        public ICollection<Calisan> Calisans { get; set; }
        public Musteri Musteri { get; set; }

    }
}
