using HepsiBurada.Case.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.Case.Test.Mock
{
    public class RotateRoverTestParameter
    {
        public Rover Rover { get; set; }
        public Rover ExpectedPositionAndHeadingForRover { get; set; }
        public string RotationCommand { get; set; }
    }
}
