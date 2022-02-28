﻿using HepsiBurada.Case.Constants;
using HepsiBurada.Case.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.Case.Business
{
    public static class RoverManager
    {
        public static Rover CreateRover(int coordX, int coordY, char heading, int finalCoordX, int finalCoordY, char finalHeading)
        {
            return new Rover(coordX, coordY, heading, finalCoordX, finalCoordY, finalHeading);
        }

        public static Rover MoveRover(Rover rover, string movingCommand)
        {
            var arr = movingCommand.Split(" ");

            rover.CoordX = Convert.ToInt32(arr[0]);
            rover.CoordY = Convert.ToInt32(arr[1]);
            rover.Heading = Convert.ToChar(arr[2]);

            return rover;
        }

        public static Rover RotateRover(Rover rover, string rotationCommand)
        {
            Direction directionValue;
            Compass headingValue;

            var arr = rotationCommand.Split(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                directionValue = (Direction)Enum.ToObject(typeof(Direction), Convert.ToChar(arr[i]));
                headingValue = (Compass)Enum.ToObject(typeof(Compass), rover.Heading);
                switch (directionValue)
                {
                    case Direction.Left:
                        RotateLeft(rover, headingValue);
                        break;
                    case Direction.Right:
                        RotateRight(rover, headingValue);
                        break;
                    case Direction.Move:
                        Move(rover, headingValue);
                        break;

                }
            }
            
            return rover;
        }

        public static bool isRoverOnFinalCoords(Rover rover)
        {
            bool ifStatement = (rover.CoordX == rover.DestinationCoordX) &&
                               (rover.CoordY == rover.DestinationCoordY) &&
                               (rover.Heading == rover.DestinationHeading);
            return ifStatement;
        }

        private static void Move(Rover rover, Compass headingValue)
        {
            if (headingValue == Compass.North || headingValue == Compass.South)
            {
                rover.CoordY++;
            }
            else
            {
                rover.CoordX++;
            }
        }

        private static void RotateRight(Rover rover, Compass headingValue)
        {
            if (headingValue == Compass.North)
            {
                rover.Heading = (char)Compass.East;
            }
            else if (headingValue == Compass.East)
            {
                rover.Heading = (char)Compass.South;

            }
            else if (headingValue == Compass.South)
            {
                rover.Heading = (char)Compass.West;

            }
            else if (headingValue == Compass.West)
            {
                rover.Heading = (char)Compass.North;

            }
        }

        private static void RotateLeft(Rover rover, Compass headingValue)
        {
            if (headingValue == Compass.North)
            {
                rover.Heading = (char)Compass.West;
            }
            else if (headingValue == Compass.East)
            {
                rover.Heading = (char)Compass.North;

            }
            else if (headingValue == Compass.South)
            {
                rover.Heading = (char)Compass.East;

            }
            else if (headingValue == Compass.West)
            {
                rover.Heading = (char)Compass.South;

            }
        }
    }
}
