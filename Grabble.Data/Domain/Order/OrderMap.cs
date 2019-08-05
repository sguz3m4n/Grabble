using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Grabble.Data.Domain
{
    public class OrderMap
    {
        public OrderMap(EntityTypeBuilder<Order> entitybuilder)
        {
            entitybuilder.HasKey(t => t.Id);
            entitybuilder.Property(x => x.OrderGuid).IsRequired();
            entitybuilder.Property(x => x.StoreId).IsRequired();
            entitybuilder.Property(x => x.CustomerId).IsRequired();
            entitybuilder.Property(x => x.BillingAddressId).IsRequired();
            entitybuilder.Property(x => x.ShippingAddressId).IsRequired();
            entitybuilder.Property(x => x.PickupAddressId).IsRequired();
            entitybuilder.Property(x => x.OrderStatusId).IsRequired();
            entitybuilder.Property(x => x.PaymentStatusId).IsRequired();
            entitybuilder.Property(x => x.CustomerCurrencyCode).IsRequired();
            entitybuilder.Property(x => x.CurrencyRate).IsRequired();
            entitybuilder.Property(x => x.OrderSubtotalInclTax).IsRequired();
            entitybuilder.Property(x => x.OrderSubtotalExclTax).IsRequired();
            entitybuilder.Property(x => x.OrderShippingInclTax).IsRequired();
            entitybuilder.Property(x => x.OrderShippingExclTax).IsRequired();
            entitybuilder.Property(x => x.OrderTotal).IsRequired();
            entitybuilder.Property(x => x.CustomerLanguageId).IsRequired();
            entitybuilder.Property(x => x.CardType).IsRequired();
            entitybuilder.Property(x => x.CardName).IsRequired();
            entitybuilder.Property(x => x.CardCvv2).IsRequired();
            entitybuilder.Property(x => x.CardExpirationMonth).IsRequired();
            entitybuilder.Property(x => x.AuthorizationTransactionId).IsRequired();
            entitybuilder.Property(x => x.CaptureTransactionId).IsRequired();

            //entityBuilder.HasOne(t => t.UserProfile).WithOne(u => u.User).HasForeignKey<UserProfile>(x => x.Id);
        }
    }
}
