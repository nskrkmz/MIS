using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Entity
{
    public class Fis
    {
        [Key]
        public int fisNo { get; set; }
        public int musteriID { get; set; }
        public string islemTarihi { get; set; }
        public int odemeTipi { get; set; }
        public int islemTutar { get; set; }

        // İlişkiler Tanımlandı
        ///public MusteriBorc MusteriBorc { get; set; }
        ///public Musteri Musteri { get; set; }
        ///public BorcluMusteri BorcluMusteri { get; set; }
        //public Islem Islem { get; set; }

    }
}
