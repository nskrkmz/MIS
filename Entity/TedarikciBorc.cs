using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Entity
{
    class TedarikciBorc
    {
        [Key]
        public int tedarikciID { get; set; }
        public int irsaliyeNo { get; set; }
        public bool durum { get; set; }
    }
}
