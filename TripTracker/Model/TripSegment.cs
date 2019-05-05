using System;

namespace TripTracker.Model
{
    public class TripSegment
    {
        private int _id;
        private int _tripId;
        private string _name;
        private string _description;
        private DateTimeOffset _startDate;
        private DateTimeOffset _endDate;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public int TripId
        {
            get => _tripId;
            set => _tripId = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public DateTimeOffset StartDate
        {
            get => _startDate;
            set => _startDate = value;
        }

        public DateTimeOffset EndDate
        {
            get => _endDate;
            set => _endDate = value;
        }
    }
}