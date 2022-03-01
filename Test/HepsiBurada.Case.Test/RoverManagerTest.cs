using HepsiBurada.Case.Business;
using HepsiBurada.Case.Test.Mock;
using HepsiBurada.Case.Test.TheoryData;
using System;
using Xunit;

namespace HepsiBurada.Case.Test
{
    public class RoverManagerTest
    {
        [Theory, ClassData(typeof(MoveRoverTest))]
        public void MoveRover_MustAssertTrue_WhenMovedTheCorrectPosition(MoveRoverTestParameter testParameter)
        {
            var rover = RoverManager.MoveRover(testParameter.Rover, testParameter.movingCommand);

            Assert.Equal(testParameter.ExpectedCoordsForRover.CoordX, rover.CoordX);
            Assert.Equal(testParameter.ExpectedCoordsForRover.CoordY, rover.CoordY);
            Assert.Equal(testParameter.ExpectedCoordsForRover.Heading, rover.Heading);

        }

        [Theory, ClassData(typeof(RotateRoverTest))]
        public void MoveRover_MustAssertTrue_WhenRotatedAndMovedTheCorrectPosition(RotateRoverTestParameter testParameter)
        {
            var rover = RoverManager.RotateRover(testParameter.Rover, testParameter.RotationCommand);

            Assert.Equal(testParameter.ExpectedPositionAndHeadingForRover.CoordX, rover.CoordX);
            Assert.Equal(testParameter.ExpectedPositionAndHeadingForRover.CoordY, rover.CoordY);
            Assert.Equal(testParameter.ExpectedPositionAndHeadingForRover.Heading, rover.Heading);

        }
    }
}
