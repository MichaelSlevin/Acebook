using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{

    [Route("[controller]")]
    //[ApiController]
    public class PostController : Controller
    {
        readonly TodoContext _context;

        public PostController(TodoContext context)
        {
            _context = context;
        }
        // GET api/Post
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> Index()
        { 
            return await _context.Posts.ToListAsync();
        }
        [HttpGet("{id}")]
        public IEnumerable<Post> GetPostByUser(int id)
        {
            Console.WriteLine("In GetPostByUser");
            List<Post> UserPosts = new List<Post>();
            UserPosts = _context.Posts.ToList();
            IEnumerable<Post> UPosts = UserPosts.Where(post=>post.UserId==id);
            return UPosts;
        }
        //[HttpPost]
        //public bool Add(long userid, string content)
        //{
        //    Console.WriteLine(content);
        //    Console.WriteLine("The form is triggering the post");
        //    _context.Posts.Add(new Post { UserId = userid, Content = content});
        //    _context.SaveChanges();
        //    return true;
        //    //return Redirect("/");
        //    // Console.WriteLine("still inside the post controller");
        //}

        [HttpPost]
        public async Task<ActionResult<Post>> Add() //Add(Post post)
        {
            long long1 = 1;
            Post post1 = new Post { Content = "hello", UserId = long1};

            Console.WriteLine(post1);
            Console.WriteLine(post1.Content);
            Console.WriteLine(post1.UserId);
            Console.WriteLine(post1.Id);
            Console.WriteLine(post1.CreatedOn);

            _context.Posts.Add(post1);
            await _context.SaveChangesAsync();

            Console.WriteLine(post1.Id);

            return CreatedAtAction("GetPostByUser", new { id =post1.UserId}, post1);
            //return Redirect("/");
        }

        //        [HttpPost]
        //        public ActionResult Add(string name)
        //        {
        //            Console.WriteLine(name);
        //            Console.WriteLine("The form is triggering the post");
        //            _context.TodoItems.Add(new TodoItem { Name = name, IsComplete = false });
        //            _context.SaveChanges();
        //            return Redirect("/");
        //            // Console.WriteLine("still inside the post controller");
        //        }

    }
}
