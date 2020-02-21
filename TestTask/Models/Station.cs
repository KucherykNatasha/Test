using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class Station
    {
        
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Passenger> Passengers { get; set; }
        public int Order { get; set; }//не знаю запитати
        public int PlannedOrder { get; set; }
        public bool IsActive { get; set; }

    }
}
