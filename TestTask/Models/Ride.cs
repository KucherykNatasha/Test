using System;
using System.Collections.Generic;


namespace TestTask.Models
{
    public class Ride
    {   
        public DateTime  DateOfRide { get; set; }
        public string StartTime { get; set; }
        public string PlannedStartTime {get; set;}
        public List<Station> Stations { get; set; }
        public Driver Driver { get; set; }

        public Driver PlannedDriver { get; set; }
        public bool ? Cancelled { get; set; }
    }
}
