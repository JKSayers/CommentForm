using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommentForm.Models
{
    public class CommentFormModel
    {
        [Key]

        public int ID { get; set; }
        
        public string Name { get; set; }
        public string Comment { get; set; }
        public int Priority { get; set; }


    }
}