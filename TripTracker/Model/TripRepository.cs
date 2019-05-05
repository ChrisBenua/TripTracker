using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.Model
{

    public interface IRepository<T>
    {
        IList<T> GetItems();

        Task<IEnumerable<T>> GetItemsAsync();

        T FindById(int id);

        void AddItem(T item);
        void UpdateItem(T item);
        void RemoveItem(int id);
    }

    
    public class TripRepository: IRepository<Trip>
    {
        private List<Trip> MyTrips = new List<Trip>()
        {
            new Trip()
            {
                Id = 1,
                Name = "MVP Summit",
                StartDate = new DateTime(2018, 3, 5),
                EndDate = new DateTime(2018, 3, 8),
            },
            new Trip()
            {
                Id = 2,
                Name = "DevIntersection",
                StartDate = new DateTime(2018, 3, 25),
                EndDate = new DateTime(2018, 3, 27),
            },
            new Trip()
            {
                Id = 3,
                Name = "MSBuild 2018",
                StartDate = new DateTime(2018, 5, 7),
                EndDate = new DateTime(2018, 5, 9)
            }
        };

        public async Task<IEnumerable<Trip>> GetItemsAsync()
        {
            return MyTrips.AsEnumerable();
        }
        public IList<Trip> GetItems()
        {
            return MyTrips;
        }

        public Trip FindById(int id)
        {
            return this.MyTrips.Find(el => el.Id == id);
        }

        public void AddItem(Trip trip)
        {
            MyTrips.Add(trip);
        }

        public void UpdateItem(Trip trip)
        {
            this.RemoveItem(trip.Id);
            this.AddItem(trip);
        }

        public void RemoveItem(int id)
        {
            MyTrips.Remove(MyTrips.First(el => el.Id == id));
        }
    }
}