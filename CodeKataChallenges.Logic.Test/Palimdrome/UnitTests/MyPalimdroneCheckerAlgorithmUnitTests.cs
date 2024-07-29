using CodeKataChallenges.Logic.Palimdrome;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Test.Palimdrome
{
    public class MyPalimdroneCheckerAlgorithmUnitTests
    {
        [Fact]
        public void CheckPalimdrome_should_return_false_if_not_a_palimdrome()
        {
            // Arrange
            const string input = "this is not a palimdrome";
            var underTest = GetUnderTest();

            // Act
            var output = underTest.CheckPalimdrome(input);

            // Assert
            output.Should().BeFalse();
        }

        [Fact]
        public void CheckPalimdrome_should_return_true_if_is_a_palimdrome_with_even_length_input()
        {
            // Arrange
            const string input = "abccba";
            var underTest = GetUnderTest();

            // Act
            var output = underTest.CheckPalimdrome(input);

            // Assert
            output.Should().BeTrue();
        }

        [Fact]
        public void CheckPalimdrome_should_return_true_if_is_a_palimdrome_with_odd_length_input()
        {
            // Arrange
            const string input = "abcdcba";
            var underTest = GetUnderTest();

            // Act
            var output = underTest.CheckPalimdrome(input);

            // Assert
            output.Should().BeTrue();
        }

        private IPalimdromeCheckerAlgorithm GetUnderTest()
        {
            return new MyPalimdromeCheckerAlgorithm();
        }
    }
}
