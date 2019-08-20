using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grabble.Data.Domain.Inventory
{
    public  class StockMap
    {
        public StockMap(EntityTypeBuilder<Stock> entitybuilder)
        {
            entitybuilder.HasKey(t => t.Id);
            entitybuilder.Property(x => x.ItemName).IsRequired();
            entitybuilder.Property(x => x.ExternalCount).IsRequired();
            entitybuilder.Property(x => x.ItemCount).IsRequired();
        }
    }
}
