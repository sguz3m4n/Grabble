using Grabble.Data.Domain;
using Microsoft.EntityFrameworkCore;


namespace Grabble.Repository.Domain.Item
{
    public  class ItemContext:DbContext
    {
        #region Constructor

        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {

        }

        #endregion

        #region Methods

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //create order map method in Grabble.Data project
            //mapping examples in file
            new ItemMap(builder.Entity<Grabble.Data.Domain.Item>());
        }

        #endregion
    }
}
