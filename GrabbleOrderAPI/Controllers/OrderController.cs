using Grabble.Repository.Repo;
using Grabble.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Grabble.OrderAPI.Controllers
{
    [ApiController]
    public class OrderController : ControllerBase
    {
        [Route("api/order/[action]")]
        [ActionName("test")]
        [HttpGet]
        public ActionResult<String> TestRest()
        {
            var result = new OrderService().RestTest;

            return Content(result);
        }




    }
}