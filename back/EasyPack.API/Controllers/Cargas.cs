using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyPack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cargas : ControllerBase
    {
        // GET: api/<Cargas>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Cargas>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Cargas>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Cargas>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Cargas>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
