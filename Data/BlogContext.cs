using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Blogging.Models;

namespace Blogging.Data
{
  public class BlogContext : DbContext
  {
    public BlogContext(DbContextOptions<BlogContext> config) : base(config)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>().HasData(
            new Author
            {
                AuthorId = 1,
                FirstName = "William",
                LastName = "Shakespeare"
            },
            new Author
             {
                AuthorId = 2,
                FirstName = "Bibi",
                LastName = "Treffers"
            }
        );

    }

    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Author> Authors { get; set; }
  }

}