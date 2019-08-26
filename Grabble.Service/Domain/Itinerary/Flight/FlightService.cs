using System;
using System.Collections.Generic;
using Grabble.Repository.Interface;
using Grabble.Data.Domain;

namespace Grabble.Service
{
    public class FlightService : IFlightService
    {
        private IRepository<Flight> flightRepository;
        public FlightService(IRepository<Flight> flightrepository)
        {
            this.flightRepository = flightrepository;
        }
        public void DeleteFlight(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Flight> GetFlight()
        {
            return flightRepository.GetAll(); 
        }

        public Flight GetFlight(int id)
        {
            return flightRepository.Get(id);
        }

        public void InsertFlight(Flight flight)
        {
            flightRepository.Insert(flight);
        }

        public void UpdateFlight(Flight flight)
        {
            flightRepository.Update(flight);
        }
    }
}
