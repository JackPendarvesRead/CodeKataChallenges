using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Test.SimpleCompoundInterest
{
    public class SimpleCompoundInterestUnitTests
    {
        [Theory]
        [InlineData(100, 0.1,  1, 110, 110)]
        [InlineData(100, 0.1,  2, 120, 121)]
        [InlineData(100, 0.1, 10, 200, 259)]
        public void Calculate_ShouldReturnCorrectCompoundInterest(double principal, double rate, int periods, int expectedSimpleInterest, int expectedCompoundIntereest)
        {
            // Arrange
            var calculator = new CodeKataChallenges.Logic.SimpleCompoundInterest.InterestCalculator();
            
            // Act
            var result = calculator.Calculate(principal, rate, periods);
           
            // Assert
           result.compoundInterest.Should().Be(expectedCompoundIntereest);
           result.simpleInterest.Should().Be(expectedSimpleInterest);
        }
    }
}
