﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Entity
{
    class BorcluMusteri
    {
        [Key]
        public int musteriID { get; set; }
        public int fisNo { get; set; }
    }
}