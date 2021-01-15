using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Entity
{
    public class BorcluMusteri
    {
        [Key]
        public int borcluMusterifisNo { get; set; }
        public int borcluMusteriMusteriID { get; set; }
        public int odenenMiktar { get; set; }

        // İlişkiler Tanımlandı
        /// public ICollection<Fis> Fis { get; set; }
    }


}
