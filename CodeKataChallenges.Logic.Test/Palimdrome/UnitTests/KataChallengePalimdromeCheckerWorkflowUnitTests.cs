using CodeKataChallenges.Logic.Palimdrome;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Test.Palimdrome
{
    public class KataChallengePalimdromeCheckerWorkflowUnitTests
    {
        private readonly Mock<IInputPreprocessor> mockPreproccessor;
        private readonly Mock<IPalimdromeCheckerAlgorithm> mockAlgorithm;

        public KataChallengePalimdromeCheckerWorkflowUnitTests()
        {
            mockPreproccessor = new Mock<IInputPreprocessor>();
            mockAlgorithm = new Mock<IPalimdromeCheckerAlgorithm>();
        }

        [Fact]
        public void CheckPalimdrome_should_return_true_if_algorithm_returns_true()
        {
            // Arrange
            const string input = "This is input";
            const string processedInput = "Processed";

            mockPreproccessor.Setup(x => x.Preprocess(input)).Returns(processedInput);
            mockAlgorithm.Setup(x => x.CheckPalimdrome(processedInput)).Returns(true);

            var underTest = GetUnderTest();

            // Act
            var output = underTest.CheckPalimdrome(input);

            // Assert
            output.Should().BeTrue();
        }

        [Fact]
        public void CheckPalimdrome_should_return_false_if_algorithm_returns_false()
        {
            // Arrange
            const string input = "This is input";
            const string processedInput = "Processed";

            mockPreproccessor.Setup(x => x.Preprocess(input)).Returns(processedInput);
            mockAlgorithm.Setup(x => x.CheckPalimdrome(processedInput)).Returns(false);

            var underTest = GetUnderTest();

            // Act
            var output = underTest.CheckPalimdrome(input);

            // Assert
            output.Should().BeFalse();
        }

        private KataChallengePalimdromeCheckerWorkflow GetUnderTest()
        {
            return new KataChallengePalimdromeCheckerWorkflow(mockPreproccessor.Object, mockAlgorithm.Object);
        }
    }
}
