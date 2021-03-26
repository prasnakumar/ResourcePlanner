using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Resource_Planner.Models
{
    public class FeatureContext
    {

        [Key]
        public  int  Id { get; set; }
        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public virtual ProjectContext ProjectContext { get; set; }

        public String  Name { get; set; }

        public String  Description { get; set; }
    }
}
