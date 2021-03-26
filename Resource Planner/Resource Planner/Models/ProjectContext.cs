using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Resource_Planner.Models
{
    public class ProjectContext
    {

        public enum Type
        {
            Active,
            OnHold,
            Cancelled,
            Completed,
            Planning,
            Commited
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public String  Name { get; set; }

        public String Description { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual CustomerContext CustomerContext { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public Type Types { get; set; }

        public String  Status { get; set; }



    }
}
