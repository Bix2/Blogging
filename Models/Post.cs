using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blogging.Models
{
    [Table("posts")]
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required(ErrorMessage = "Title field can not be empty")]
        [StringLength(100)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
     
        [Required(ErrorMessage = "Body can not be empty")]
        [StringLength(1000)]
        public string Content { get; set; }

        public int AuthorId { get; set; }
        public Author AuthorName { get; set; }
    
        public List<Comment> Comments { get; set; }
        //public Comment Comment { get; set; }

    }

}