using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blogging.Models
{
  public class PostCreateVM
  {
    public string SelectedAuthorId { get; set; }
    public List<SelectListItem> AuthorList { get; set; }
  
    public Post Post { get; set; }
    public Comment Comment { get; set; }
    public List<Comment> Comments { get; set; }

  }
}