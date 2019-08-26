using Grabble.Data.Domain;
using System.Collections.Generic;

namespace Grabble.Service
{
    public interface IFlightService
    {
        IEnumerable<Flight> GetFlight();
        Flight GetFlight(int id);
        void InsertFlight(Flight flight);
        void UpdateFlight(Flight flight);
        void DeleteFlight(int id);
    }
}
