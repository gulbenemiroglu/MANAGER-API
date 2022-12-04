using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Concrete
{
    public class Comment
    {
       
        [Key]
        public int CommentId { get; set; } 
        public string CommentText { get; set; }
        [ForeignKey("ReaTaskId")]
        public int ReaTaskId { get; set; }  
        //public ReaTask? ReaTask { get; set; }

    }
}
