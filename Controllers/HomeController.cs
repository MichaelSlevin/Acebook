//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using TodoApi.Models;

//namespace TodoApi.Controllers
//{

//    [Route("")]
//    [Route("[controller]")]
//    //[ApiController]
//    public class HomeController : Controller
//    {
//        readonly TodoContext _context;

//        public HomeController(TodoContext context)
//        {
//             _context = context;
//        }
//        // GET api/values
//        [HttpGet]
//        public ActionResult<IEnumerable<string>> Index()
//        {
//            var todoitems = _context.TodoItems.ToList();
//            Console.WriteLine("In the home controller");
//            TodoList todoList = new TodoList();

//            foreach (var item1 in todoitems)
//            {
//                todoList.AddItem(new TodoItem { Id = item1.Id, Name = item1.Name, IsComplete = item1.IsComplete
//                });

//                Console.WriteLine(item1.Name);

//            }
//            Console.WriteLine(_context.GetType());
//            Console.WriteLine("good morning");
//            @ViewData["todoItems"] = todoitems;

//            return View(todoList);

//        }
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

//        //[HttpDelete("{id}")]
//        //public ActionResult Delete(long id)
//        //{
//        //  Console.WriteLine("Delete has been called");
//        //  _context.TodoItems.Delete(id);
//        //  _context.SaveChanges();
//        //  return Redirect("/");
//        //}





//        // GET api/values/5
//        [HttpGet("{id}")]
//        public ActionResult<string> Get(int id)
//        {
//            Console.WriteLine(id);
//            return id.ToString();
//        }

//        // POST api/values
//        [HttpPost]
//        public void Post()

//        //public void Post([FromBody] string value)
//        {
//            Console.WriteLine("Hello");
//            //return new string[] { "Test string", "value2" };
//        }

//        // PUT api/values/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {

//        }

//        // DELETE api/values/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {

//        }
//    }
//}
