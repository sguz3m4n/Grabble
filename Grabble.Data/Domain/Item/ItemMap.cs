using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grabble.Data.Domain
{
    public class ItemMap
    {
        public ItemMap(EntityTypeBuilder<Item> entitybuilder)
        {
            entitybuilder.HasKey(t => t.Id);
            entitybuilder.Property(t => t.ItemGuid).IsRequired();
            entitybuilder.Property(t => t.BarcodeNumber).IsRequired();
            entitybuilder.Property(t => t.UnitPriceInclTax).IsRequired();
            entitybuilder.Property(t => t.UnitPriceExclTax).IsRequired();
            entitybuilder.Property(t => t.PriceInclTax).IsRequired();
            entitybuilder.Property(t => t.PriceExclTax).IsRequired();
            entitybuilder.Property(t => t.OriginalProductCost).IsRequired();
            entitybuilder.Property(t => t.ItemWeight).IsRequired();
            entitybuilder.Property(t => t.ItemHeight).IsRequired();
            entitybuilder.Property(t => t.ItemWidht).IsRequired();
            entitybuilder.Property(t => t.ItemVolume).IsRequired();
        }
    }
}
