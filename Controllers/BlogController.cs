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
            var model = new PostListVM();
            model.Posts = _blogContext.Posts.ToList();
            return View(model);
        }  

        [Route("/create")]
        [HttpGet]
        public IActionResult Create()
        {
          /*   var authors = _blogContext.Authors
                .Select(x => new SelectListItem {
                    Value = $"{x.AuthorId}",
                    Text = $"{x.FirstName} {x.LastName}"
                });*/
           // ViewBag.Authors = authors;
            var vm = new PostCreateVM();
            GetAuthorNames(vm);
            return View(vm);
        }
 
        [Route("/create")]
        [HttpPost]  
        public IActionResult Create(PostCreateVM vm)  
        {  
            var post = vm.Post;
            var author = GetAuthor(vm);
            if (ModelState.IsValid) {
                post.Date = DateTime.Now;
                post.AuthorName = author;
                post.Content = vm.Post.Content;
                post.Title = vm.Post.Title;
                //var post = new Blogging.Models.Post() {
                  //  Title = item.Title,
                  //  Content = item.Content,
                 //   AuthorId = item.AuthorId,
                   // Date = DateTime.Now,
               // };  
                // Add blog post to database
                _blogContext.Posts.Add(post);
                _blogContext.SaveChanges();
                return RedirectToAction("Index");
            }
            GetAuthorNames(vm);
            return View(vm);      
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
            var post = _blogContext.Posts.Find(id);
            var author = _blogContext.Authors.Find(post.AuthorId);
            var comments = _blogContext.Comments.Where(x => x.PostId == post.PostId).ToList();
            var vm = new PostCreateVM(){
                Post = post, 
                Comments = comments,
            };
            GetAuthorNames(vm);
            return View(vm);
        }

        [Route("/show/{id}/comment")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Comment([FromRoute] int id, PostCreateVM vm) {
            var comment = vm.Comment;
            var author = GetAuthor(vm);
            if (ModelState.IsValid) {
                comment.Content = vm.Comment.Content;
                comment.PostId = id;
                comment.Author = author;
                _blogContext.Comments.Add(comment);
                _blogContext.SaveChanges();
                return RedirectToAction("Details"); 
            }
            GetAuthorNames(vm);
            return View();
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

        private void GetAuthorNames(PostCreateVM vm)
        {
        vm.AuthorList = _blogContext.Authors
            .Select(x => new SelectListItem {
                Value = x.AuthorId.ToString(),
                Text = $"{x.FirstName} {x.LastName}"
            })
            .ToList();
        }

        private Author GetAuthor(PostCreateVM vm)
        {
            int.TryParse(vm.SelectedAuthorId, out var AuthorId);
            var author = _blogContext.Authors.Find(AuthorId);
            return author;
        }
    
    }
}