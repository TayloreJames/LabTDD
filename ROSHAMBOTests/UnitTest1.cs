using System;
using Xunit;
using ROSHAMBO;

namespace ROSHAMBOTests
{
    public class UnitTest1
    {
        [Fact]
        public void RockBeatsScissorsTests()
        {
            //Arrange
            var input = 3;
            var expectedResult = "Rock beats Scissors";
            ROSHAMBO.Roshambo roshambo = new Roshambo();

            //Act
            //string result = fizzBuzz.Generate(input);

            //Assert
            //Assert.Equal(expectedResult, result);
        }
    }
}
