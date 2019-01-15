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
    public class UserController : Controller
    {
        readonly TodoContext _context;

        public UserController(TodoContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<ActionResult<User>> Add(string username, string email, string password)
        {
            //long long1 = 1;
            User user = new User { Username = username, Email = email, Password = password };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            Console.WriteLine(user.Id);

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
            //return Redirect("/");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(long id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }
    }
}
