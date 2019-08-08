using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grabble.Data.Domain
{
    public  class ConsumerMap
    {
        public ConsumerMap(EntityTypeBuilder<Consumer> entitybuilder)
        {
            entitybuilder.HasKey(t => t.Id);
            entitybuilder.Property(t => t.Username).IsRequired();
            entitybuilder.Property(t => t.Firstname).IsRequired();
            entitybuilder.Property(t => t.Lastname).IsRequired();
            entitybuilder.Property(t => t.Email).IsRequired();
            entitybuilder.Property(t => t.Phone).IsRequired();
            entitybuilder.Property(t => t.EmailToRevalidate).IsRequired();
            entitybuilder.Property(t => t.Age).IsRequired();
            entitybuilder.Property(t => t.Gender).IsRequired();
            entitybuilder.Property(t => t.BillingAddressId).IsRequired();
            entitybuilder.Property(t => t.ShippingAddressId).IsRequired();
        }
    }
}
