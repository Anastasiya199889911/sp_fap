using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sp_fap.Models
{
    public class DrugsOfWayOfAdministration
    {
        [Key]
        public int Id { get; set; }
        public int WayOfAdministrationId { get; set; }
        public int DrugsId { get; set; }

        [ForeignKey("WayOfAdministrationId")]
        public virtual WayOfAdministration wayOfAdministration { get; set; }
        [ForeignKey("DrugsId")]
        public virtual Drugs drugs { get; set; }
    }
}