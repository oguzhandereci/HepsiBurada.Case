using HepsiBurada.Case.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.Case.Test.Mock
{
    public class MoveRoverTestParameter
    {
        public Rover Rover { get; set; }
        public string movingCommand { get; set; }
        public Rover ExpectedCoordsForRover { get; set; }
    }
}
