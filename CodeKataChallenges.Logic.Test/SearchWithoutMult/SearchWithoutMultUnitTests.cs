using CodeKataChallenges.Logic.SearchWithoutMult;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Test.SearchWithoutMult
{
    public class SearchWithoutMultUnitTests
    {
        [Theory]
        [InlineData(5)]
        [InlineData(30)]
        public void Should_return_false_n_outside_bounds_of_list(int n)
        {
            var input = new List<int>() { 10, 15, 20, 25 };
            input.ContainsWithoutMult(n).Should().BeFalse();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void Should_return_true_if_odd_length_list_contains_n(int n)
        {
            var input = new List<int>() { 1, 2, 3, 4, 5 };
            input.ContainsWithoutMult(n).Should().BeTrue();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void Should_return_true_if_even_length_list_contains_n(int n)
        {
            var input = new List<int>() { 1, 2, 3, 4, 5, 6 };
            input.ContainsWithoutMult(n).Should().BeTrue();
        }

        [Theory]
        [InlineData(12)]
        [InlineData(16)]
        [InlineData(28)]
        public void Should_return_false_if_odd_length_list_does_not_contain_n(int n)
        {
            var input = new List<int>() { 10, 15, 20, 25, 30 };
            input.ContainsWithoutMult(n).Should().BeFalse();
        }

        [Theory]
        [InlineData(12)]
        [InlineData(16)]
        [InlineData(28)]
        [InlineData(34)]
        public void Should_return_false_if_even_length_list_does_not_contain_n(int n)
        {
            var input = new List<int>() { 10, 15, 20, 25, 30, 35 };
            input.ContainsWithoutMult(n).Should().BeFalse();
        }
    }
}
