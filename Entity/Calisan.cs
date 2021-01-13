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
        public string calisanSifre { get; set; }
        public string calisanAdSoyad { get; set; }
        public string calisanGorev { get; set; }
        public int calisanMaas { get; set; }

        // İlişkiler Tanımlandı
        ///public ICollection<MusteriBorc> MusteriBorcs { get; set; }
        //public Depo Depo { get; set; }

    }
}
