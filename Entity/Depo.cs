using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Entity
{
    public class Depo
    {
        [Key]
        public int urunID { get; set; }
        public int urunAdet { get; set; }
        public int tedarikciID { get; set; }
        public int calisanID { get; set; }

        // İlişkiler Tanımlandı
        public ICollection<Urun> Uruns { get; set; }
        public ICollection<Tedarikci> Tedarikcis { get; set; }
        public Calisan Calisan { get; set; }

    }
}
