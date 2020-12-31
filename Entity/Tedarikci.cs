using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Entity
{
    class Tedarikci
    {
        [Key]
        public int tedarikciID { get; set; }
        public string tedarikciIsim { get; set; }
    }
}
