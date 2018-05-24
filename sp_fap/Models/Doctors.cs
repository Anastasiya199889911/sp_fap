using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sp_fap.Models
{
    public class Doctors
    {
        [Key]
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronemic { get; set; }
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("PositionId")]
        public virtual Positions psition { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Depatment department { get; set; }
    }
}