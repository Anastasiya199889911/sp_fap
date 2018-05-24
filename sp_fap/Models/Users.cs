using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sp_fap.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }

        [ForeignKey("DoctorId")]
        public virtual Doctors doctor { get; set; }
        [ForeignKey("UserTypeId")]
        public virtual UserType userType { get; set; }
    }
}