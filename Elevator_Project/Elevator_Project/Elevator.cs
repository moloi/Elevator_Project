using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator_Project
{
    public class Elevator
    {
        public int CurrentFloor { get; set; }
        public Direction Direction { get; set; }
        public int Capacity { get; set; }
        public int CurrentCapacity { get; set; }
        public int WeightLimit { get; set; }
        public int CurrentWeight { get; set; }

        public Elevator()
        {
            CurrentFloor = 1;
            Direction = Direction.Stationary;
            Capacity = 10;
            CurrentCapacity = 0;
            WeightLimit = 1000; // Assuming weight limit is 1000 kg
            CurrentWeight = 0;
        }

        public void MoveTo(int targetFloor)
        {
            if (targetFloor > CurrentFloor)
                Direction = Direction.Up;
            else if (targetFloor < CurrentFloor)
                Direction = Direction.Down;
            else
                Direction = Direction.Stationary;

            CurrentFloor = targetFloor;
        }

        public void UpdateDirection(int targetFloor)
        {
            if (targetFloor > CurrentFloor)
                Direction = Direction.Up;
            else if (targetFloor < CurrentFloor)
                Direction = Direction.Down;
            else
                Direction = Direction.Stationary;
        }

        public bool CanAddWeight(int weight)
        {
            return CurrentWeight + weight <= WeightLimit;
        }
    }

}
