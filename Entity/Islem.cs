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
        public int islemSirasi{ get; set; }
        public int islemFisNo { get; set; }
        public int islemUrunID { get; set; }
        public string islemTarihi { get; set; }

        // İlişkiler Tanımlandı
        ///public ICollection<Urun> Uruns { get; set; }
        //public Fis Fis { get; set; }

    }
}
