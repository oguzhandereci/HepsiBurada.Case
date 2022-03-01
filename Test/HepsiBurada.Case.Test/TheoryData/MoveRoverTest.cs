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
    public class MoveRoverTest : TheoryData<MoveRoverTestParameter>
    {
        public MoveRoverTest()
        {
            Add(new MoveRoverTestParameter
            {
                Rover = new Rover(0,0,'N',1,3,'N'),
                ExpectedCoordsForRover = new Rover(5,5,'N',1,3,'N'),
                movingCommand = "5 5"
            });

            Add(new MoveRoverTestParameter
            {
                Rover = new Rover(0, 0, 'N', 1, 3, 'N'),
                ExpectedCoordsForRover = new Rover(1, 2, 'N', 1, 3, 'N'),
                movingCommand = "1 2 N"
            });

            Add(new MoveRoverTestParameter
            {
                Rover = new Rover(0, 0, 'N', 1, 3, 'N'),
                ExpectedCoordsForRover = new Rover(3, 3, 'E', 1, 3, 'N'),
                movingCommand = "3 3 E"
            });
        }
    }
}
