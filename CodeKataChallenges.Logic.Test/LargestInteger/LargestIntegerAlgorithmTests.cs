using CodeKataChallenges.Logic.LargestInteger;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Test.LargestInteger
{
    internal class LargestIntegerAlgorithmTests
    {
        [Fact]
        public void Test()
        {
            var algorithm = new LargestIntegerAlgorithm();

            var input = new int[] { 10, 7, 76, 415 };
            var expected = "77641510";

            var result = algorithm.GetLargestInteger(input);

            result.Should().Be(expected);
        }
    }
}
