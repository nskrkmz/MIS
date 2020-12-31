using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Entity
{
    class Fis
    {
        [Key]
        public int fisNo { get; set; }
        public int musteriID { get; set; }
        public string islemTarihi { get; set; }
        public int odemeTipi { get; set; }
        public int islemTutar { get; set; }

    }
}
