using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grabble.Data.Domain.GrabPack
{
   public class ContainerMap
    {
        public ContainerMap(EntityTypeBuilder<Container> entitybuilder)
        {
            entitybuilder.HasKey(t => t.Id);
            
        }
    }
}
