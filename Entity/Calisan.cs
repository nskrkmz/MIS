using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Entity
{
    public class Calisan
    {
        [Key]
        public int calisanID { get; set; }
        public int calisanSifre { get; set; }
        public string calisanAd { get; set; }
        public string calisanSoyad { get; set; }
        public string calisanGorev { get; set; }

        // İlişkiler Tanımlandı
        ///public ICollection<MusteriBorc> MusteriBorcs { get; set; }
        //public Depo Depo { get; set; }

    }
}
