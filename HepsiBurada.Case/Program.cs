using HepsiBurada.Case.Business;
using HepsiBurada.Case.Constants;
using HepsiBurada.Case.Models;
using System;
using System.Collections.Generic;

namespace HepsiBurada.Case
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rover> createdRoverList = new List<Rover>();
            List<string> commandListForMoving = new List<string> { "5 5", "1 2 N", "3 3 E" };
            List<string> commandListForRotation = new List<string> { "L M L M L M M", "M M R M M R M R R M" };

            Rover rover1 = RoverManager.CreateRover(0, 0, Convert.ToChar(Compass.North), 1, 3, Convert.ToChar(Compass.North));
            Rover rover2 = RoverManager.CreateRover(0, 0, Convert.ToChar(Compass.North), 5, 1, Convert.ToChar(Compass.East));

            createdRoverList.Add(rover1);
            createdRoverList.Add(rover2);

            foreach (var rover in createdRoverList)
            {
                GetActionForRover(commandListForMoving, commandListForRotation, rover);
            }
        }

        private static void GetActionForRover(List<string> commandListForMoving, List<string> commandListForRotation, Rover rover)
        {
            Console.WriteLine("Select a position info which will send to the rover for moving. 1)5 5 \n2)1 2 N \n3)3 3 E ");
            int chooseForMoving = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select a command info which will send to the rover for rotation. 1)L M L M L M M \n2)M M R M M R M R R M");
            int chooseForRotation = Convert.ToInt32(Console.ReadLine());

            RoverManager.MoveRover(rover, commandListForMoving[chooseForMoving - 1]);
            RoverManager.RotateRover(rover, commandListForRotation[chooseForRotation - 1]);

            if (RoverManager.isRoverOnFinalCoords(rover))
            {
                Console.WriteLine($"The rover which its id is {rover.RoverId} now on its final coordinates.");
            }
            else
            {
                GetActionForRover(commandListForMoving, commandListForRotation, rover);
            }
        }
    }
}
