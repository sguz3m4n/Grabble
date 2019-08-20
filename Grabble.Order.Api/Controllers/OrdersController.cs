using Grabble.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GrabbleOrder.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService orderservice;
        //private readonly OrderService orderservice;

        public OrdersController(IOrderService orderservice)
        {
            this.orderservice = orderservice;
        }

        // GET: api/v1/orders
        [HttpGet]
        public string Get()
        {
            var result = orderservice.GetOrders();
            string json = JsonConvert.SerializeObject(result);

            return json;
        }

        // GET: api/v1/orders/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            var result = orderservice.GetOrder(id);
            string json = JsonConvert.SerializeObject(result);

            return json;
        }

        // POST: api/v1/orders
        [HttpPost]
        public void Post([FromBody] Grabble.Data.Domain.Order order)
        {
            if (ModelState.IsValid)
            {
                orderservice.InsertOrder(order);
            }
        }

        // PUT: api/v1/Grabble/5 - update order  [do we want to support this?]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }

        // DELETE: api/order/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            orderservice.DeleteOrder(id);
        }
    }
}