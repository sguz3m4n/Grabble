using Grabble.Data.Domain.Order;
using Grabble.Repository.Context;
using Grabble.Services;
using Microsoft.EntityFrameworkCore;
using System;

namespace Grabble.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctxt = new OrderDbContext(options: new DbContextOptions<OrderDbContext>());

            var order = new Order
            {
                OrderNumber = Guid.NewGuid(),
                PaymentType = "Credit Card",
                OrderDate = DateTime.Now,
                ModifyDate = DateTime.Today,
                CreateDate = DateTime.Now,
                Instructions = "Lemme Grabble Now"
            };

      

            Console.WriteLine("Hello World!" + order.OrderNumber.ToString());

        }

     
    }
}
