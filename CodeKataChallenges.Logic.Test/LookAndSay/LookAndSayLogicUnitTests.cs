using CodeKataChallenges.Logic.LookAndSay;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Test.LookAndSay
{
    public class LookAndSayLogicUnitTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "11")]
        [InlineData(3, "21")]
        [InlineData(4, "1211")]
        [InlineData(5, "111221")]
        [InlineData(6, "312211")]
        [InlineData(7, "13112221")]
        [InlineData(8, "1113213211")]
        [InlineData(9, "31131211131221")]
        [InlineData(10, "13211311123113112211")]
        public void Test1(int n, string expected)
        {
            var underTest = new LookAndSayLogic();
            var result = underTest.GetNthTerm(n);
            result.Should().Be(expected);
        }

    }
}
