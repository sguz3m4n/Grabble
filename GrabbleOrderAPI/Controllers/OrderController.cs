using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grabble.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GrabbleOrderAPI.Controllers
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