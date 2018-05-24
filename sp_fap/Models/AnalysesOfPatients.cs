using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sp_fap.Models
{
    public class AnalysesOfPatients
    {
        [Key]
        public int Id { get; set; }
        public int AnalysisId { get; set; }
        public int PatientId { get; set; }

        [ForeignKey("AnalysisId")]
        public virtual Analyses analysisId { get; set; }
        [ForeignKey("PatientId")]
        public virtual Patients patientId { get; set; }
    }
}