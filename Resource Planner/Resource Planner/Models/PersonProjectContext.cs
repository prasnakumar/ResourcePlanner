using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Resource_Planner.Models
{
    public class PersonProjectContext
    {
        
        [Key]
        public int Id { get; set; }

        public int? PersonId { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
        public int? ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public virtual ProjectContext Project { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime MyProperty { get; set; }

        public int PercentageAssigned { get; set; }
    }
}
