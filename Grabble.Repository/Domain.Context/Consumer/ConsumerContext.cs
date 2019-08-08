using Grabble.Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace Grabble.Repository.Domain
{
    public  class ConsumerContext:DbContext
    {
        #region Constructor

        public ConsumerContext(DbContextOptions<ConsumerContext> options) : base(options)
        {

        }

        #endregion

        #region Methods

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //create order map method in Grabble.Data project
            //mapping examples in file
            new ConsumerMap(builder.Entity<Grabble.Data.Domain.Consumer>());
        }

        #endregion
    }
}
