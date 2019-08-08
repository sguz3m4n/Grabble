using Grabble.Data.Domain;
using Grabble.Repository.Interface;
using System;
using System.Collections.Generic;

namespace Grabble.Services.Domain
{
    public class ItemService : IItemService
    {

        private IRepository<Item> itemRespository;

        public ItemService(IRepository<Item> itemrepository)
        {
            this.itemRespository = itemrepository;
        }

        public void DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
            return itemRespository.GetAll();
        }

        public Item GetItem(int id)
        {
            return itemRespository.Get(id);
        }

        public void InsertItem(Item item)
        {
            itemRespository.Insert(item);
        }

        public void UpdateItem(Item item)
        {
            itemRespository.Update(item);
        }
    }
}
