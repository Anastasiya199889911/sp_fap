using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sp_fap.Models
{
    public class RhesusAccessory
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
    }
}