using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Resource_Planner.Models
{
    public class SkillContext
    {

        [Key]
        public int Id { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        public int? PersonId { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
    }
}
