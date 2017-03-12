﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VehicleDealer.Models
{
    public class Modeels
    {
        [Key]
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public string ModelColor { get; set; }
        public int ModelYear { get; set; }
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }
    }
}