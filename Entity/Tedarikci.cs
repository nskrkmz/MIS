using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Entity
{
    public class Tedarikci
    {
        [Key]
        public int tedarikciID { get; set; }
        public string tedarikciIsim { get; set; }

        // İlişkiler Tanımlandı
        public ICollection<Irsaliye> Irsaliyes { get; set; }
        public ICollection<TedarikciBorc> tedarikciBorcs { get; set; }
        public ICollection<Depo> Depos { get; set; }
    }
}
