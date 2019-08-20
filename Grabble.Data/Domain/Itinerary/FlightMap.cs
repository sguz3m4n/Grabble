using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grabble.Data.Domain.Itinerary
{
  public  class FlightMap
    {
        public FlightMap(EntityTypeBuilder<Flight> entitybuilder)
        {
            entitybuilder.HasKey(t => t.Id);
            entitybuilder.Property(x => x.Destination).IsRequired();
            entitybuilder.Property(x => x.Airline).IsRequired();
            entitybuilder.Property(x => x.DepartureDate).IsRequired();
            entitybuilder.Property(x => x.DepartureTime).IsRequired();
        }
    }
}
