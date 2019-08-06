using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grabble.Data.Domain
{
    public class ItemMap
    {
        #region Constructor
        public ItemMap(EntityTypeBuilder<Item> entitybuilder)
        {
            entitybuilder.Property(t => t.Id);

        }
        #endregion

    
    }
}
