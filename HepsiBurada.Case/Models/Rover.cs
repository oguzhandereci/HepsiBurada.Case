using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.Case.Models
{
    public class Rover
    {
        private Guid _roverId;
        private int _coordX;
        private int _coordY;
        private char _heading;
        private int _destinationCoordX;
        private int _destinationCoordY;
        private char _destinationHeading;
        private char[] _commandsList;

        public Rover(int coordX, int coordY, char heading, int finalCoordX, int finalCoordY, char finalHeading)
        {
            _roverId = new Guid();
            _coordX = coordX;
            _coordY = coordY;
            _heading = heading;
            _destinationCoordX = finalCoordX;
            _destinationCoordY = finalCoordY;
            _destinationHeading = finalHeading;
        }

        public Guid RoverId { get => _roverId;}
        public int CoordX { get => _coordX; set => _coordX = value; }
        public int CoordY { get => _coordY; set => _coordY = value; }
        public char Heading { get => _heading; set => _heading = value; }
        public int DestinationCoordX { get => _destinationCoordX; set => _destinationCoordX = value; }
        public int DestinationCoordY { get => _destinationCoordY; set => _destinationCoordY = value; }
        public char DestinationHeading { get => _destinationHeading; set => _destinationHeading = value; }
        public char[] CommandsListForRotation { get => _commandsList; set => _commandsList = value; }


    }
}
