using EntitiesLayer.Concrete.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Concrete
{

    public class ReaTask
    {
        [Key]
        public int ReaTaskId { get; set; }
        public string Owner { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public statusEnum Status { get; set; }

        public DateTime UpdatedDate { get; set; }
   
       
        public ICollection<Comment?> Comments { get; set; }

    }
}
