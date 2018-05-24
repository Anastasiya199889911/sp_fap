using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sp_fap.Models
{
    public class Drugs
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int DosageId { get; set; }
        public DateTime ProductionDate { get; set; }
        public int ShelfLife { get; set; }
        public int Count { get; set; }
        public int Valume { get; set; }
        public int NumberOfAll { get; set; }
        public int WayOfReceptionId { get; set; }
        public string FreguencyOfUse { get; set; }

        [ForeignKey("DosageId")]
        public virtual Dosage dosage { get; set; }
        [ForeignKey("WayOfReceptionId")]
        public virtual WayOfReception wayOfReception { get; set; }
    }
}