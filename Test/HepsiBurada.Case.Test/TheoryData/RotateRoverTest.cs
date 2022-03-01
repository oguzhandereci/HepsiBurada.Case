using HepsiBurada.Case.Models;
using HepsiBurada.Case.Test.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HepsiBurada.Case.Test.TheoryData
{
    public class RotateRoverTest : TheoryData<RotateRoverTestParameter>
    {
        public RotateRoverTest()
        {
            Add(new RotateRoverTestParameter
            {
                Rover = new Rover(1, 2, 'N'),
                ExpectedPositionAndHeadingForRover = new Rover(2, 1, 'E'),
                RotationCommand = "L M L M L M M"
            });

            Add(new RotateRoverTestParameter
            {
                Rover = new Rover(1, 2, 'N'),
                ExpectedPositionAndHeadingForRover = new Rover(3, 4, 'N'),
                RotationCommand = "M M R M M R M R R M"
            });
        }
    }
}
