using Grabble.Data.Domain.Order;
using Grabble.Repository.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Grabble.Repository.Context
{
    public class OrderDbContext : DbContext
    {
        #region Constructor

        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }

        #endregion

        #region Properties

        public DbSet<Order> OrderContext { get; set; }

        #endregion

    }
}
