using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sp_fap.Models
{
    public class IndicatorsOfPatientsValue
    {
        [Key]
        public int Id { get; set; }
        public int IndicatorsOfPatientsId { get; set; }
        public float Value { get; set; }

        [ForeignKey("IndicatorsOfPatientsId")]
        public virtual IndicatorsOfPatients indicatorsOfPatients { get; set; }
    }
}