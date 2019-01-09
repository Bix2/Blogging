using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blogging.Models
{
    [Table("comments")]
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        
        [Required(ErrorMessage = "Body can not be empty")]
        [StringLength(1000)]
        public string Content { get; set; }

        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}