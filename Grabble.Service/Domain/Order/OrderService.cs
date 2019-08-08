using Grabble.Data.Domain;
using Grabble.Repository.Interface;
using System;
using System.Collections.Generic;

namespace Grabble.Services
{
    public class ItemService : IItemService
    {

        private IRepository<Order> orderRespository;

        public ItemService(IRepository<Order> orderrepository)
        {
            this.orderRespository = orderrepository;
        }

        public void DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrders()
        {
            return orderRespository.GetAll();
        }

        public Order GetOrder(int id)
        {
            return orderRespository.Get(id);
        }

        public void InsertOrder(Order order)
        {
            orderRespository.Insert(order);
        }

        public void UpdateOrder(Order order)
        {
            orderRespository.Update(order);
        }
    }
}
