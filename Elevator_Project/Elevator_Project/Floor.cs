using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator_Project
{
    public class Floor
    {
        public int FloorNumber { get; set; }
        public int PeopleWaiting { get; set; }

        public Floor(int floorNumber)
        {
            FloorNumber = floorNumber;
            PeopleWaiting = 0;
        }
    }
}
