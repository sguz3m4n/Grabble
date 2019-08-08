using Grabble.Repository.Properties;
using Microsoft.EntityFrameworkCore;
using Grabble.Data.Domain;


namespace Grabble.Repository.Context
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
            new ItemMap(builder.Entity<Item>());
        }

        #endregion
    }
}
