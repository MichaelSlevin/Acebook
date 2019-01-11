using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateController : ControllerBase
    {
        // GET api/Create
        [HttpGet("{Name}")]
        public ActionResult<IEnumerable<string>> Get(string Name)
        {
            TodoItem todoItem = new TodoItem();
            Console.WriteLine(todoItem.Name);
            todoItem.Name = "Create this endpoint";
            Console.WriteLine(todoItem.Name);


            return new string[] { Name, "create" };
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    Console.WriteLine(id);
        //    return id.ToString();
        //}

        //// POST api/values
        //[HttpPost]
        //public string[] Post()

        ////public void Post([FromBody] string value)
        //{
        //    //Console.WriteLine("Hello");
        //    return new string[] { "Test string", "value2" };
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{

        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{

        //}
    }
}
