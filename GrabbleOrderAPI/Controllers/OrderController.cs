using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Grabble.OrderAPI.Controllers
{

    [ApiController]
   [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {

        // GET: api/v1/Order
        [HttpGet]     
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Order/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Order
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Order/5
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
