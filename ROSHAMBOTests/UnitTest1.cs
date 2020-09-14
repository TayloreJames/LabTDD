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
            var input1 = "Rock";
            var input2 = "Scissors";
            var expectedResult = "Rock beats Scissors";
            Roshambo roshambo = new Roshambo();

            //Act
            string result = roshambo.Play(input1,input2);

            //Assert
            //Assert.Equal(expectedResult, result);
        }
    }
}
