using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Grabble.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GrabbleController : ControllerBase
    {
        // GET: api/v1/Grabble
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/v1/Grabble/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/v1/Grabble - Create new grabble form order
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //Call GUID Service
            //Respond with link containing guid to grabble chooser resource
        }

        // PUT: api/v1/Grabble/5 - update order  [do we want to support this?]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
