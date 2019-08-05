using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grabble.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GrabbleOrder.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService orderservice;
        //private readonly OrderService orderservice;

        public OrdersController(IOrderService orderservice )
        {
            this.orderservice = orderservice;
        }

        // GET api/order
        [HttpGet]
        public string Get()
        {
            return "value";
        }

        // POST: api/order
        [HttpPost]
        public void Post([FromBody] Grabble.Data.Domain.Order order)
        {
            if (ModelState.IsValid)
            {
                orderservice.InsertOrder(order);
            }
        }
    }
}