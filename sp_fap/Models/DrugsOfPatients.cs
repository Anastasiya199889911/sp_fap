using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sp_fap.Models
{
    public class DrugsOfPatients
    {
        [Key]
        public int Id { get; set;}
        public int DrugId { get; set; }
        public int PatientId { get; set; }

        [ForeignKey("DrugId")]
        public virtual Drugs drug { get; set; }
    }
}