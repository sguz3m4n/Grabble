using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grabble.Data.Domain
{
    public class ContainerMap
    {
        public ContainerMap(EntityTypeBuilder<Container> entitybuilder)
        {
            entitybuilder.HasKey(t => t.Id);
            entitybuilder.Property(x => x.Height).IsRequired();
            entitybuilder.Property(x => x.Width).IsRequired();
            entitybuilder.Property(x => x.Depth).IsRequired();
            entitybuilder.Property(x => x.Volume).IsRequired();
        }
    }
}
