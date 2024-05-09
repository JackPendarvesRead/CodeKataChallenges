using CodeKataChallenges.Logic.SubArraySum;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Test.SubArraySum
{
    public class SubArraySumCalculatorUnitTests
    {
        #region Tests

        [Fact]
        public void GetSubArrayForSum_should_return_empty_IEnumerable_if_sum_not_found()
        {
            // Arrange
            var sum = 0;
            var inputArray = new int[] { 1, 2, 3, 4, 5 };
            var underTest = GetUnderTest();

            // Act
            var result = underTest.GetSubArrayForSum(inputArray, sum);

            // Assert
            result.Should().BeEmpty();
        }

        [Fact]
        public void GetSubArrayForSum_should_return_not_include_any_trailiong_zeroes_in_returned_array()
        {
            // Arrange
            var sum = 5;
            var inputArray = new int[] { 1, 2, 3, 0, 0 };
            var expected = new int[] { 2, 3 };
            var underTest = GetUnderTest();

            // Act
            var result = underTest.GetSubArrayForSum(inputArray, sum);

            // Assert
            result.Should().HaveCount(1);
            result.First().Should().BeEquivalentTo(expected);
        }



        [Fact]
        public void GetSubArrayForSum_should_ignore_preceeding_zeroes_in_returned_array()
        {
            // Arrange
            var sum = 7;
            var inputArray = new int[] { 0, 0, 3, 4 };
            var expected = new int[] { 3, 4 };
            var underTest = GetUnderTest();

            // Act
            var result = underTest.GetSubArrayForSum(inputArray, sum);

            // Assert
            result.Should().HaveCount(1);
            result.First().Should().BeEquivalentTo(expected);
        }

        [Theory]
        [MemberData(nameof(GetSubArrayForSumData))]
        public void GetSubArrayForSum_should_return_IEnumerable_of_array_of_sums_if_sum_found(int[] inputArray, int sum, IEnumerable<int[]> expected)
        {
            // Arrange
            var underTest = GetUnderTest();

            // Act
            var result = underTest.GetSubArrayForSum(inputArray, sum);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }

        #endregion

        #region Member Data

        public static IEnumerable<object[]> GetSubArrayForSumData()
        {
            yield return new object[] 
            { 
                new int[] { 1, 2, 3, 4, 5 }, 
                6, 
                new List<int[]>() 
                {
                    new int[3] { 1, 2, 3 }
                } 
            };

            yield return new object[]
            {
                new int[] { 1, 2, 3, 2, 1 },
                6,
                new List<int[]>()
                {
                    new int[] { 1, 2, 3 },
                    new int[] { 3, 2, 1 }
                }
            };

            yield return new object[]
            {
                new int[] { 4, 5, 9 },
                9,
                new List<int[]>()
                {
                    new int[] { 4, 5 },
                    new int[] { 9 }
                }
            };


            yield return new object[]
            {
                new int[] { 44, 22, 70, 8, 0, 0, 92, 8, 92, 3, 5, 8, 2, 50, 32, 5, 5 },
                100,
                new List<int[]>()
                {
                    new int[] { 22, 70, 8 },
                    new int[] { 8, 0, 0, 92 },
                    new int[] { 92, 8 },
                    new int[] { 8, 92 },
                    new int[] { 92, 3, 5 },
                    new int[] { 3, 5, 8, 2, 50, 32 }
                }
            };
        }

        #endregion

        #region Helper Methods

        private SubArraySumCalculator GetUnderTest()
        {
            return new SubArraySumCalculator();
        }

        #endregion
    }
}
