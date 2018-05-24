using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sp_fap.Models
{
    public class Patients
    {
        [Key]
        public int Id { get; set; }
        public int MedicalCardNumber { get; set; }
        public int DoctorId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronemic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int BloodGroupId { get; set; }
        public int RhesusAccessoryId { get; set; }
        public string Diagnosis { get; set; }
        public float Weight { get; set; }
        public float Growth { get; set; }

        [ForeignKey("DoctorId")]
        public virtual Doctors doctor { get; set; }
        [ForeignKey("BloodGroupId")]
        public virtual BloodGroup bloodGroup { get; set; }
        [ForeignKey("RhesusAccessoryId")]
        public virtual RhesusAccessory rhesusAccessory { get; set; }
    }
}