using Grabble.Data.Domain.Order;
using Grabble.Repository.Context;
using Grabble.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace Grabble.ConsoleApp
{
    class Program
    {
        static IRepository<Order> _repo { get; set; }

        private static IRepository<Order> CRUD(IRepository<Order> order)
        {
            return _repo = order;
        }
        static void Main(string[] args)
        {


            var ctxt = new OrderDbContext(options: new DbContextOptions<OrderDbContext>());
            var reposit = new Repository<Order>(ctxt);
            var order = new Order
            {
                OrderNumber = Guid.NewGuid(),
                PaymentType = "Credit Card",
                OrderDate = DateTime.Now,
                ModifyDate = DateTime.Today,
                CreateDate = DateTime.Now,
                Instructions = "Lemme Grabble Now"
            };
            CRUD(reposit).GetAll();
            //CRUD(reposit).Insert(order);

            Console.WriteLine("Hello World!" + order.OrderNumber.ToString());

        }


    }
}
