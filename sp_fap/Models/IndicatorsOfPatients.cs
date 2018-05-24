using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sp_fap.Models
{
    public class IndicatorsOfPatients
    {
        [Key]
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int IndicatorId { get; set; }

        [ForeignKey("PatientId")]
        public virtual Patients patient { get; set; }
        [ForeignKey("IndicatorId")]
        public virtual Indicators indicator { get; set; }
    }
}