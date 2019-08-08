using Grabble.Data.Domain;
using Grabble.Repository.Properties;
using Microsoft.EntityFrameworkCore;

namespace Grabble.Repository.Domain
{
    public class OrderContext : DbContext
    {
        #region Constructor

        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {

        }

        #endregion

        #region Methods

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //create order map method in Grabble.Data project
            //mapping examples in file
            new OrderMap(builder.Entity<Order>());
        }
        #endregion

    }
}
