using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            ElevatorController controller = new ElevatorController(numElevators: 3, numFloors: 5);

            controller.SetPeopleWaiting(3, 2);

            controller.CallElevator(4);

            controller.DisplayElevatorStatus();
        }
    }
}
