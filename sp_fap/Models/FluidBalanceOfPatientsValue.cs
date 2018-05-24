using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sp_fap.Models
{
    public class FluidBalanceOfPatientsValue
    {
        [Key]
        public int Id { get; set; }
        public int FluidBalanceOfPatientsId { get; set; }
        public float Value { get; set; }

        [ForeignKey("FluidBalanceOfPatientsId")]
        public virtual FluidBalanceOfPatients fluidBalanceOfPatients { get; set; }
    }
}