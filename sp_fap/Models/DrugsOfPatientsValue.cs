using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sp_fap.Models
{
    public class DrugsOfPatientsValue
    {
        [Key]
        public int Id { get; set; }
        public int DrugsOfPatientsId { get; set; }
        public float Value { get; set; }

        [ForeignKey("DrugsOfPatientsId")]
        public virtual DrugsOfPatients drugsOfPatients { get; set; }
    }
}