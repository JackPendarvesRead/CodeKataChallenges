using CodeKataChallenges.Logic.ReverseInteger;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Test.ReverseInteger
{
    public class ReverseIntegerTests
    {
        const int max = 2147483647;


        [Theory]
        [InlineData(123, 321)]
        [InlineData(10000000, 1)]
        [InlineData(10000001, 10000001)]
        [InlineData(-123, -321)]
        public void Reverse_should_reverse_integer(int input, int expected)
        {
            var result = IntegerReverser.Reverse(input);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(Int32.MaxValue)]
        [InlineData(Int32.MinValue)]
        [InlineData(1000000009)]
        [InlineData(-1000000009)]
        public void Reverse_should_return_zero_when_overflow(int input)
        {
            var result = IntegerReverser.Reverse(input);
            result.Should().Be(0);
        }

    }
}
