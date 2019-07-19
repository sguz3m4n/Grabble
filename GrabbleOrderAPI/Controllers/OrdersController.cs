﻿using Grabble.Data.Domain.Order;
using Grabble.Repository.Interface;
using Grabble.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Grabble.OrderAPI.Controllers
{
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private static string _version = "v1";
        public IRepository<Order> _order { get; set; }
        public OrderService _orderservice { get; set; }
        //public OrderController(IRepository<Order> order)
        //{
        //    _order = order;
        //}

        [Route("api/v1/orders")]
        [HttpGet]
        public ActionResult<String> ListOrders()
        {
            /* Returns a list of Orders*/
            return Content("Orders API versoin: " + OrdersController._version);
        }

        [Route("api/v1/orders")]
        [HttpPost]
        public ActionResult<String> CreateOrder()
        {
            /* creates a new Order*/
            return Content("Orders API versoin: " + OrdersController._version);
        }

        [Route("api/v1/orders/{id}")]
        [HttpPut]
        public ActionResult<String> UpdateOrder()
        {
            /* update an Order*/
            return Content("Orders API versoin: " + OrdersController._version);
        }

        [Route("api/v1/orders/{id}")]
        [HttpDelete]
        public ActionResult<String> DeleteOrder()
        {
            /* deletes an Order*/
            return Content("Orders API versoin: " + OrdersController._version);
        }


        //// POST: api/company/register
        //[Route("api/order/[action]")]
        //[ActionName("register")]
        //[HttpPost]
        //public async Task<ActionResult<Order>> RegisterCompany(Order order)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (order != null)
        //        {
        //            var orderservice = new OrderService(_order);
        //            orderservice.InsertOrder(order);
        //        }
        //        return Content("success");
        //    }
        //    return Content(null);
        //}


        //// GET: api/company/fetchall
        //[Route("api/order/[action]")]
        //[ActionName("fetchall")]
        //[HttpGet]
        //public async Task<ActionResult<String>> GetCompanies()
        //{
        //                //var company = await _context.DbContextCompany.Where(x => x.Status == "Active").ToListAsync();
        //    //var contact = await _context.DbContextContacts.Include(x => x.Company).ToListAsync<Contact>();
        //    //var coord = await _context.DbContextGeo.Include(x => x.Company).ToListAsync<GeoLocate>();
        //    //if (company.Count == 0)
        //    //{
        //    //    return NotFound();
        //    //}
        //    //var setting = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects };
        //    //string companyjson = JsonConvert.SerializeObject(company, Formatting.Indented, setting);
        //    return Content("");
        //}
    }
}