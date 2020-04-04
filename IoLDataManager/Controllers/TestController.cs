using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using IoLDataManager.Models;

namespace IoLDataManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public TestController()
        {
        }

        // GET api/test
        [HttpGet("")]
        public ActionResult<IEnumerable<string>> Getstrings()
        {
            return new List<string> {"lala", "lolo", "lele" };
        }

        // GET api/test/5
        [HttpGet("{id}")]
        public ActionResult<string> GetstringById(int id)
        {
            return id.ToString();
        }

        // POST api/test
        [HttpPost("")]
        public void Poststring(string value)
        {
        }

        // PUT api/test/5
        [HttpPut("{id}")]
        public void Putstring(int id, string value)
        {
        }

        // DELETE api/test/5
        [HttpDelete("{id}")]
        public void DeletestringById(int id)
        {
        }
    }
}