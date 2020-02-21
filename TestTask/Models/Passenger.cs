using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class Passenger
    {
        
        public Person Person { get; set; }
        public string DestinationStation { get; set; }
        public bool IsActive { get; set; }
    }
}
