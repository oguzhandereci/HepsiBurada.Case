using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.Case.Models
{
    public class Rover
    {
        private int _coordX;
        private int _coordY;
        private char _heading;
        private List<char[]> _commandsList;

        public Rover(int coordX, int coordY, char heading)
        {
            _coordX = coordX;
            _coordY = coordY;
            _heading = heading;
        }

        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public char Heading { get; set; }
        public int CoordX { get; set; }


    }
}
