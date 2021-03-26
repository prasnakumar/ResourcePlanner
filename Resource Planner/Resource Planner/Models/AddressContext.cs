using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Resource_Planner.Models
{
    public class AddressContext
    {
        [Key]

        public int Id { get; set; }

        public int MyProperty { get; set; }
        public String Street  { get; set; }

        public String City { get; set; }

        public String State { get; set; }

        public String  Zip { get; set; }
        public int? PersonId { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
    }
}
