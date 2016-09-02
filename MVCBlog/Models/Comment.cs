using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBlog.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        public DateTime Date { get; set; }

        public Post Post { get; set; }
    }
}