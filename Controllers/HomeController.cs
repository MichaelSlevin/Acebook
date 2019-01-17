using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{

    [Route("")]
    [Route("[controller]")]
    //[HomeController]
    public class HomeController : Controller
    {
        readonly TodoContext _context;

        public HomeController(TodoContext context)
        {
            _context = context;
        }
        // GET api/values

        
        [HttpGet("{username}")]
        public ActionResult<IEnumerable<string>> Index(string username)
        {
            var posts = _context.Posts.ToList();

            long userid = _context.Users.Where(x => x.Username == username).Select(x => x.Id).First();
            Console.WriteLine($"userid is {userid}");
            IEnumerable<Post> UPosts = posts.Where(post => post.UserId == userid);

            Console.WriteLine("In the home controller");
            Profile profile = new Profile(username);

            foreach (var post in UPosts)
            {

                profile.AddPost(new Post
                {
                    Id = post.Id,
                    UserId = post.UserId,
                    Content = post.Content,
                    CreatedOn = post.CreatedOn
                });
                 
                Console.WriteLine(post.Content);

            }
            Console.WriteLine(_context.GetType());
            Console.WriteLine("good morning");
            @ViewData["posts"] = posts;

            return View(profile);
        }

        [HttpPost("adding_post")]
        public ActionResult Add(string content, string username)
        {
            Console.WriteLine("The form is triggering the post");
            Console.WriteLine($"username is {username}");
            long userid = _context.Users.Where(x => x.Username == username).Select(x => x.Id).First();
            Console.WriteLine($"userid is {userid}");
           
            _context.Posts.Add(new Post { UserId = userid, Content = content, CreatedOn = System.DateTime.UtcNow });
            _context.SaveChanges();
           
            return Redirect("/" + username);
        }
        
        [Route("register")]
        [HttpGet]
        public ActionResult Register()
        {
          Console.WriteLine("I made it into the register route!!!!!!!");
          return View();
        }
        [HttpPost]
        public ActionResult Add(string username, string email, string password)
        {
            Console.WriteLine($"Username is {username}");
            Console.WriteLine($"Email is {email}");
            Console.WriteLine($"Password is {password}");
            Console.WriteLine("The form is triggering the post");
            Encrypt encrypt = new Encrypt();
            string encryptedPW = encrypt.EncryptDecrypt(password, 200);
            Console.WriteLine($"Encrypted password is {encryptedPW}");
            Console.WriteLine($"Does encrypted password = stored password");
            Console.WriteLine(encryptedPW == encrypt.EncryptDecrypt(password, 200));
            _context.Users.Add(new User { Username = username, Email = email, Password = encryptedPW });
            _context.SaveChanges();
            return Redirect($"/{username}");
            // Console.WriteLine("still inside the post controller");
        }
       
    }
}