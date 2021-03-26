using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Resource_Planner.Models
{
    public class CustomerContext
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public String Name { get; set; }

    }
}
