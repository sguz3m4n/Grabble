using Grabble.Data.Domain;
using Grabble.Services.Domain;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GrabbleItem.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService itemservice;
        //private readonly ItemService itemservice;

        public ItemsController(IItemService itemservice)
        {
            this.itemservice = itemservice;
        }

        // GET: api/v1/items
        [HttpGet]
        public string Get()
        {
            var result = itemservice.GetItems();
            string json = JsonConvert.SerializeObject(result);

            return json;
        }

        // GET: api/v1/items/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            var result = itemservice.GetItem(id);
            string json = JsonConvert.SerializeObject(result);

            return json;
        }

        // POST: api/v1/items
        [HttpPost]
        public void Post([FromBody] Item item)
        {
            if (ModelState.IsValid)
            {
                itemservice.InsertItem(item);
            }
        }

        // PUT: api/v1/Grabble/5 - update item  [do we want to support this?]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }

        // DELETE: api/item/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            itemservice.DeleteItem(id);
        }
    }
}