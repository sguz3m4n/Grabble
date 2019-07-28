using Grabble.Data.Domain.Order;
using Grabble.Repository.Context;
using Grabble.Repository.Interface;
using Grabble.Services;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;

namespace Grabble.ConsoleApp
{
  public  class Program
    {

        static void Main(string[] args)
        {
            var ctxt = new OrderDbContext(options: new DbContextOptions<OrderDbContext>());
            
            Order order = new Order
            {
                OrderGuid = Guid.NewGuid(),
                CustomerId = 1,
                BillingAddressId = 2,
                ShippingAddressId = 3,
                PickupAddressId = 4,
                PaymentStatusId = 5,
                CustomerCurrencyCode = "BBD",
                CurrencyRate = 2.00M,
                OrderSubtotalInclTax = 4.23M,
                OrderSubtotalExclTax = 3.23M,
                OrderSubTotalDiscountInclTax = 3.45M,
                OrderSubTotalDiscountExclTax = 3.45M,
                OrderTotal = 23.34M,
                CustomerLanguageId = 34,
                CardName = "Visa",
                CardType = "Credit Card",
                CardNumber = "23455555",
                CardCvv2 = "254",
                CardExpirationMonth = "Jan",
                CardExpirationYear = "22",
                AuthorizationTransactionId="22",
                CaptureTransactionId="34"

            };
            var json = JsonConvert.SerializeObject(order);

            order.ModifyBy = order.CreateBy = "test";

            ////orderservice.Insert(order);
            //orderservice.Get(3);
        }
    }
}
