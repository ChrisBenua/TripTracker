using System;

namespace TripTracker.Model
{
    public class Trip
    {
        private int _id;
        private string _name;
        private DateTime _startDate;
        private DateTime _endDate;
        
        public string Name
        {
            get => _name;
            set { _name = value; }
        }

        public DateTime StartDate
        {
            get => _startDate;
            set => _startDate = value;
        }

        public DateTime EndDate
        {
            get => _endDate;
            set => _endDate = value;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }
    }
}