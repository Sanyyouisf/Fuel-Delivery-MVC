﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FuelDeliveryMVC.Models
{
    [Table("OperatingRegion")]
    public class OperatingRegion
    {
        [Key]
        public int regionId { get; set; }

        public string regionName { get; set; }
    }
}