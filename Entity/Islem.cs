using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Entity
{
    public class Islem
    {
        [Key]
        public int fisNo { get; set; }
        public int urunID { get; set; }
        public string islemTarihi { get; set; }

        // İlişkiler Tanımlandı
        public ICollection<Urun> Uruns { get; set; }
        //public Fis Fis { get; set; }

    }
}
