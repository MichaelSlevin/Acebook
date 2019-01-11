using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class ValsController : ControllerBase
    {
        // GET api/vals
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "New value for vals route", "value2" };
        }

        // GET api/vals/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            Console.WriteLine(id);
            return id.ToString();
        }

        // POST api/vals//public void Post([FromBody] string value)
        [HttpPost]
        public void Post()
        {
            Console.WriteLine("Hello, this is a post request");
            //return new string[] { "Test string", "value2" };
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
