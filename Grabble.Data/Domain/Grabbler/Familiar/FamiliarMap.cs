using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grabble.Data.Domain
{
    public  class FamiliarMap
    {
        public FamiliarMap(EntityTypeBuilder<Familiar> entitybuilder)
        {
            entitybuilder.HasKey(t => t.Id);
            entitybuilder.Property(x => x.Username).IsRequired();
            entitybuilder.Property(x => x.Email).IsRequired();
            entitybuilder.Property(x => x.EmailToRevalidate).IsRequired();

        }
    }
}
