using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grabble.Data.Domain
{
  public  class ContentMap
    {
        public ContentMap(EntityTypeBuilder<Content> entitybuilder)
        {
            entitybuilder.HasKey(t => t.Id);
            entitybuilder.Property(x => x.OrderGuid).IsRequired();
            entitybuilder.Property(x => x.ItemId).IsRequired();
        }
    }
}
