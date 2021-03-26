using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Resource_Planner.Models
{
    public class Person
    {

        public enum GenderType
        {
            Male,
            Female
        }

        public enum Type
        {
            Full_time,
            Employee,
            Contractor,
            Intern
        }

        public enum status
        {
            Active,
            Resigned,
            On_long_leave,

        }
        [Key]
        public int   Id { get; set; }
        public String Email { get; set; }

        public String FistName { get; set; }

        public String LastName { get; set; }

        public int  PhoneNUmber { get; set; }
        public GenderType  Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime LeftDate { get; set; }

        public Type Types { get; set; }

        public status  Status { get; set; }
        [Required]
        public String  Password { get; set; }
        public String  ResetPasswordToken { get; set; }
        
        public String ResetPasswordExpires { get; set; }

    }
}
