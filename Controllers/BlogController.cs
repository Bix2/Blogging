using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blogging.Data;
using Blogging.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Blogging.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext _blogContext;

        public BlogController(BlogContext blogContext) {
            _blogContext = blogContext;
        }

        [Route("/")]
        [HttpGet()]
        public IActionResult Index()
        {
            var posts =  _blogContext.Posts.ToList();
            return View(posts);
        }  

        [Route("/create")]
        [HttpGet]
        public IActionResult Create()
        {
            var authors = _blogContext.Authors
                .Select(x => new SelectListItem {
                    Value = x.AuthorId.ToString(),
                    Text = $"{x.FirstName} {x.LastName}"
                });
            ViewBag.Authors = authors;
            return View();
        }
 
        [Route("/create")]
        [HttpPost]  
        public IActionResult Create(Post item)  
        {  
            if (item != null) {
                var post = new Blogging.Models.Post() {
                    Title = item.Title,
                    Content = item.Content,
                    AuthorId = item.AuthorId,
                    Date = DateTime.Now,
                };    
                // Add blog post to database
                _blogContext.Posts.Add(post);
                _blogContext.SaveChanges();
            }
            return RedirectToAction("Index");        
        }

        [Route("/edit/{id}")]
        [HttpGet]
        public IActionResult Edit([FromRoute]int id)
        {
            var post = _blogContext.Posts.Find(id); 
            return View(post);
        }

        [Route("/edit/{id}")]
        [HttpPost]  
        public ActionResult Edit([FromRoute]int id, Post item)  
        {  
            var post = _blogContext.Posts.Find(id); 
            if (ModelState.IsValid) {
              
                post.Title = item.Title;
                post.Content = item.Content;
                post.Date = DateTime.Now;
                
                // Add blog post to database
                _blogContext.Posts.Update(post);
                _blogContext.SaveChanges();
                return RedirectToAction("Index");        
            }
            return View("Edit", item);
        }  

        [Route("/show/{id}")]
        [HttpGet]
        public IActionResult Details([FromRoute]int id)
        {
            var authors = _blogContext.Authors
                .Select(x => new SelectListItem {
                    Value = x.AuthorId.ToString(),
                    Text = $"{x.FirstName} {x.LastName}"
                });
            ViewBag.Authors = authors;
            var authorList = new List<SelectListItem>();
            var post = _blogContext.Posts.Find(id);
            var comments = _blogContext.Comments.Where(c => c.PostId == post.PostId).ToList();
            var vm = new Models.PostCreateVM(){
                Post = post,
                Comments = comments,
                AuthorList = authorList,
            };
            return View(vm);
        }

        [Route("/show/{id}/comment")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Comment([FromRoute] int id, Comment item) {
            var comment = new Blogging.Models.Comment(){
                Content = item.Content,
                AuthorId = item.AuthorId,
                PostId = id
            };    
            // Add blog post to database
            _blogContext.Comments.Add(comment);
            _blogContext.SaveChanges();
        
            return View("Details", item);
        }


        [Route("/delete/{id}")]
        [HttpPost]  
        public ActionResult Delete([FromRoute]int id)  
        {  
            var post = _blogContext.Posts.Find(id); 
            _blogContext.Posts.Remove(post); 
            _blogContext.SaveChanges();   
            return RedirectToAction("Index");  
        }  

    
    }
}