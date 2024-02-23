using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator_Project
{
    public class ElevatorController
    {
        private List<Elevator> elevators;
        private List<Floor> floors;

        public ElevatorController(int numElevators, int numFloors)
        {
            elevators = new List<Elevator>();
            floors = new List<Floor>();

            for (int i = 0; i < numElevators; i++)
            {
                elevators.Add(new Elevator());
            }

            for (int i = 0; i < numFloors; i++)
            {
                floors.Add(new Floor(i + 1));
            }
        }

        public void CallElevator(int floorNumber)
        {
            Elevator nearestElevator = FindNearestElevator(floorNumber);
            nearestElevator.MoveTo(floorNumber);
            Console.WriteLine($"Elevator called to Floor {floorNumber}");
        }

        private Elevator FindNearestElevator(int floorNumber)
        {
            // Basic logic to find the nearest available elevator
            // In a real-world scenario, you would calculate the distance between elevators and the floor
            // and choose the one that minimizes the distance.
            return elevators[0]; // Just returning the first elevator for now
        }

        public void SetPeopleWaiting(int floorNumber, int numPeople)
        {
            floors[floorNumber - 1].PeopleWaiting = numPeople;
            Console.WriteLine($"People waiting on Floor {floorNumber}: {numPeople}");
        }

        public void DisplayElevatorStatus()
        {
            foreach (var elevator in elevators)
            {
                Console.WriteLine($"Elevator at Floor {elevator.CurrentFloor}, Direction: {elevator.Direction}, Capacity: {elevator.CurrentCapacity}/{elevator.Capacity}, Current Weight: {elevator.CurrentWeight}/{elevator.WeightLimit}");
            }
        }
    }
}
