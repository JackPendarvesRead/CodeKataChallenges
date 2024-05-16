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
        [InlineData(new int[] { 1, 2, 3, 4, 5}, 0, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, 1, new int[] { 2, 3, 4, 5, 1 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, 2, new int[] { 3, 4, 5, 1, 2 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, 3, new int[] { 4, 5, 1, 2, 3 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, 4, new int[] { 5, 1, 2, 3, 4 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, 5, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, 6, new int[] { 2, 3, 4, 5, 1 })]
        public void Rotate_should_move_elements_left_in_list_by_k_amount_for_positive_k(IList<int> input, int k, IList<int> expected)
        {
            var result = ListRotationExtensions.RotateList<int>(input, k);
            result.Should().ContainInConsecutiveOrder(expected);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, 0, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, -1, new int[] { 5, 1, 2, 3, 4 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, -2, new int[] { 4, 5, 1, 2, 3 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, -3, new int[] { 3, 4, 5, 1, 2 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, -4, new int[] { 2, 3, 4, 5, 1 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, -5, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, -6, new int[] { 5, 1, 2, 3, 4 })]
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

    }
}
