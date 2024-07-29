using CodeKataChallenges.Logic.Palimdrome;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Test.Palimdrome
{
    
    public class AlphernumericOnlyInputPreprocessorUnitTests
    {
        [Fact]
        public void Preprocess_should_replace_all_non_alphanumerics_with_empty_string()
        {
            // Arrange
            const string input = "This is, possibly, 1 of the 23 outcomes.";
            const string expected = "Thisispossibly1ofthe23outcomes";
            var underTest = GetUnderTest();

            // Act
            var output = underTest.Preprocess(input);

            // Assert
            output.Should().Be(expected);
        }


        private IInputPreprocessor GetUnderTest()
        {
            return new AlphernumericOnlyInputPreprocessor();
        }
    }
}
