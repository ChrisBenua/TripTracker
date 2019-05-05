using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripTracker.Model;

namespace TripTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : Controller
    {
        private IRepository<Trip> _tripRepository;

        public TripsController(IRepository<Trip> repo)
        {
            this._tripRepository = repo;
        }

        [HttpGet]
        public IEnumerable<Trip> GetTrips()
        {
            return this._tripRepository.GetItems();
        }

        [HttpGet("{id}")]
        public Trip GetById(int id)
        {
            return this._tripRepository.FindById(id);
        }

        [HttpPost]
        public void PostTrip([FromBody] Trip trip)
        {
            this._tripRepository.AddItem(trip);
        }

        [HttpPut("{id}")]
        public void PutTrip(int id, [FromBody] Trip trip)
        {
            this._tripRepository.UpdateItem(trip);
        }

        [HttpDelete("{id}")]
        public void DeleteTrip(int id)
        {
            this._tripRepository.RemoveItem(id);
        }
    }
}