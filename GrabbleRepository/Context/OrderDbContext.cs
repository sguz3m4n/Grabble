using Grabble.Data.Domain.Order;
using Grabble.Repository.Properties;
using Microsoft.EntityFrameworkCore;

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

        #region Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //use this string to target local environment
                //this is not working for asynch calls 
                var connlocal = Resources.connLocal;
                //use this string to target remote environment
                var connremote = Resources.connRemote;
#if DEBUG
                optionsBuilder.UseSqlServer(connlocal,
                               provideroptions => provideroptions.CommandTimeout(60))
                           .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
#else
                optionsBuilder.UseSqlServer(connremote,
                               provideroptions => provideroptions.CommandTimeout(60))
                           .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
#endif


            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}
