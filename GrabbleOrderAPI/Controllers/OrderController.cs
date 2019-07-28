using Grabble.Data.Domain.Order;
using Grabble.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Grabble.OrderAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService iorder;
        private readonly OrderService orderservice;

        public OrderController( OrderService orderservice)
        {
            this.orderservice = orderservice;
        }

        // GET: api/Order
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
        public void Post([FromBody] Order order)
        {
            if (ModelState.IsValid)
            {
                orderservice.InsertOrder(order);
            }
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
