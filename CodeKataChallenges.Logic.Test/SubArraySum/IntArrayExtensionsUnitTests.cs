using CodeKataChallenges.Logic.SubArraySum;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Test.SubArraySum
{
    public class IntArrayExtensionsUnitTests
    {
        #region Tests

        [Theory]
        [MemberData(nameof(GetSumData))]
        public void GetSum_should_return_expected_result(int[] input, int start, int end, int expectedSum)
        {
            input.GetSum(start, end).Should().Be(expectedSum);
        }

        [Theory]
        [MemberData(nameof(GetSubArrayData))]
        public void GetSubArray_should_return_expected_array(int[] input, int start, int end, int[] expectedArray)
        {
            input.GetSubArray(start, end).Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void GetIndexOfNextNonZeroValue_should_return_first_nonzero_index_by_default()
        {
            var array = new int[] { 0, 0, 1, 0, 0, 1 , 2, 3 };
            var result = array.GetIndexOfNextNonZeroValue();
            result.Should().Be(2);
        }

        [Fact]
        public void GetIndexOfNextNonZeroValue_should_return_next_nonzero_index()
        {
            var array = new int[] { 0, 0, 1, 0, 0, 1, 2, 3 };
            var result = array.GetIndexOfNextNonZeroValue(3);
            result.Should().Be(5);
        }

        [Fact]
        public void GetIndexOfNextNonZeroValue_should_return_final_index_plus_one_if_no_nonzero_values()
        {
            var array = new int[] { 0, 0, 0, 0 };
            var result = array.GetIndexOfNextNonZeroValue();
            result.Should().Be(array.Length + 1);
        }

        #endregion

        #region Member Data

        public static IEnumerable<object[]> GetSumData()
        {
            int[] testArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            yield return new object[]
            {
                testArray,
                0,
                3,
                6
            };

            yield return new object[]
            {
                testArray,
                4,
                5,
                9
            };

            yield return new object[]
            {
                testArray,
                7,
                9,
                24
            };
        }

        public static IEnumerable<object[]> GetSubArrayData()
        {
            var testArray = new int[] { 0,1,2,3,4,5,6,7,8,9 };

            yield return new object[]
            {
                testArray,
                0,
                2,
                new int[] { 0, 1, 2 }
            };

            yield return new object[]
           {
                testArray,
                6,
                9,
                new int[] { 6,7,8,9 }
           };

            yield return new object[]
           {
                testArray,
                5,
                6,
                new int[] { 5, 6 }
           };
        }

        #endregion
    }
}
