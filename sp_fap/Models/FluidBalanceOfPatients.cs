using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sp_fap.Models
{
    public class FluidBalanceOfPatients
    {
        [Key]
        public int Id { get; set; }
        public int FluidBalanceId { get; set; }
        public int PatientId { get; set; }

        [ForeignKey("FluidBalanceId")]
        public virtual FluidBalance fluidBalance { get; set; }
        [ForeignKey("PatientId")]
        public virtual Patients patient { get; set; }
    }
}