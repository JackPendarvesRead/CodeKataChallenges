using CodeKataChallenges.Logic.RotatingList;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Test.RotatingList
{
    public class RotatingListUnitTests
    {
        [Theory]
        [MemberData(nameof(GetPositiveEvenArrayTestData))]
        [MemberData(nameof(GetPositiveOddArrayTestData))]
        public void Rotate_should_move_elements_left_in_list_by_k_amount_for_positive_k(IList<int> input, int k, IList<int> expected)
        {
            var result = ListRotationExtensions.RotateList<int>(input, k);
            result.Should().ContainInConsecutiveOrder(expected);
        }

        [Theory]
        [MemberData(nameof(GetNegativeEvenArrayTestData))]
        [MemberData(nameof(GetNegativeOddArrayTestData))]
        public void Rotate_should_move_elements_right_in_list_by_k_amount_for_negative_k(IList<int> input, int k, IList<int> expected)
        {
            var result = ListRotationExtensions.RotateList<int>(input, k);
            result.Should().ContainInConsecutiveOrder(expected);
        }

        [Fact]
        public void Rotate_should_move_string_elements()
        {
            var list = new List<string>() { "this", "should", "work", "just", "as", "well" };
            var expected = new List<string>() { "well", "this", "should", "work", "just", "as" };

            var result = list.RotateList(-1);
            result.Should().ContainInConsecutiveOrder(expected);
        }

        [Fact]
        public void Test_for_ank()
        {
            const int k = 2;
            var input = new[] { -1, -100, 3, 99 };
            var expected = new[] {  3, 99, -1, -100 };
            var result = input.RotateList(k);
            result.Should().ContainInConsecutiveOrder(expected);
        }

        [Fact]
        public void Test_for_ank2()
        {
            const int k = -2;
            var input = new[] { 1, 2, 3, 4, 5, 6 };
            var expected = new[] { 5, 6, 1, 2, 3, 4 };
            var result = input.RotateList(k);
            result.Should().ContainInConsecutiveOrder(expected);
        }


        #region Member Data

        public static IEnumerable<object[]> GetPositiveOddArrayTestData()
        {
            yield return new object[] { new int[] { 1, 2, 3, 4, 5}, 0, new int[] { 1, 2, 3, 4, 5 }};
            yield return new object[] { new int[] { 1, 2, 3, 4, 5}, 1, new int[] { 2, 3, 4, 5, 1 }};
            yield return new object[] { new int[] { 1, 2, 3, 4, 5}, 2, new int[] { 3, 4, 5, 1, 2 }};
            yield return new object[] { new int[] { 1, 2, 3, 4, 5}, 3, new int[] { 4, 5, 1, 2, 3 }};
            yield return new object[] { new int[] { 1, 2, 3, 4, 5}, 4, new int[] { 5, 1, 2, 3, 4 }};
            yield return new object[] { new int[] { 1, 2, 3, 4, 5}, 5, new int[] { 1, 2, 3, 4, 5 }};
            yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, 6, new int[] { 2, 3, 4, 5, 1 } };
        }

        public static IEnumerable<object[]> GetNegativeOddArrayTestData()
        {
            yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, 0, new int[] { 1, 2, 3, 4, 5 } };
            yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, -1, new int[] { 5, 1, 2, 3, 4 } };
            yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, -2, new int[] { 4, 5, 1, 2, 3 } };
            yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, -3, new int[] { 3, 4, 5, 1, 2 } };
            yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, -4, new int[] { 2, 3, 4, 5, 1 } };
            yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, -5, new int[] { 1, 2, 3, 4, 5 } };
            yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, -6, new int[] { 5, 1, 2, 3, 4 } };
        }

        public static IEnumerable<object[]> GetNegativeEvenArrayTestData()
        {
            yield return new object[] { new int[] { 1, 2, 3, 4 }, 0, new int[] { 1, 2, 3, 4 } };
            yield return new object[] { new int[] { 1, 2, 3, 4 }, -1, new int[] { 4, 1, 2, 3 } };
            yield return new object[] { new int[] { 1, 2, 3, 4 }, -2, new int[] { 3, 4, 1, 2 } };
            yield return new object[] { new int[] { 1, 2, 3, 4 }, -3, new int[] { 2, 3, 4, 1 } };
            yield return new object[] { new int[] { 1, 2, 3, 4 }, -4, new int[] { 1, 2, 3, 4 } };
            yield return new object[] { new int[] { 1, 2, 3, 4 }, -5, new int[] { 4, 1, 2, 3 } };
        }

        public static IEnumerable<object[]> GetPositiveEvenArrayTestData()
        {
            yield return new object[] { new int[] { 1, 2, 3, 4 }, 0, new int[] { 1, 2, 3, 4 } };
            yield return new object[] { new int[] { 1, 2, 3, 4 }, 1, new int[] { 2, 3, 4, 1 } };
            yield return new object[] { new int[] { 1, 2, 3, 4 }, 2, new int[] { 3, 4, 1, 2 } };
            yield return new object[] { new int[] { 1, 2, 3, 4 }, 3, new int[] { 4, 1, 2, 3 } };
            yield return new object[] { new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4 } };
            yield return new object[] { new int[] { 1, 2, 3, 4 }, 5, new int[] { 2, 3, 4, 1 } };
        }

        #endregion

    }
}
