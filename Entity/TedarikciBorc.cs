﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Entity
{
     public class TedarikciBorc
    {
        [Key]
        public int tedarikciBorcIslemSirasi { get; set; }
        public string tedarikciBorcTedarikciID { get; set; }
        public int tedarikciBorcirsaliyeNo { get; set; }
        public int tedarikciBorcIrsaliyeTutar { get; set; }
        public bool tedarikciBorcdurum { get; set; }

        // İlişkiler Tanımlandı
        ///public ICollection<Irsaliye> Irsaliyes { get; set; }
        ///public Tedarikci Tedarikci { get; set; }
    }
}
