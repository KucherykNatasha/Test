using System;
using System.Collections.Generic;
namespace TestTask.Models
{
    public class Route
    { 
      
      public string Name { get; set; }
      public  ActiveDays ActiveDays { get; set; }
      public List<Ride> Riders { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set;}

    }
}
