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
        //[HttpPost]
        //public ActionResult Add(string name)
        //{
        //    Console.WriteLine(name);
        //    Console.WriteLine("The form is triggering the post");
        //    _context.TodoItems.Add(new TodoItem { Name = name, IsComplete = false });
        //    _context.SaveChanges();
        //    return Redirect("/");
        //    // Console.WriteLine("still inside the post controller");
        //}

    }
}
