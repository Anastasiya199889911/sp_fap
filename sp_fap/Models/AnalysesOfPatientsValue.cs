using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sp_fap.Models
{
    public class AnalysesOfPatientsValue
    {
        [Key]
        public int Id { get; set; }
        public int AnalysesOfPatientsId { get; set; }
        public float Value { get; set; }

        [ForeignKey("AnalysesOfPatientsId")]
        public virtual AnalysesOfPatients analysesOfPatients { get; set; }
    }
}