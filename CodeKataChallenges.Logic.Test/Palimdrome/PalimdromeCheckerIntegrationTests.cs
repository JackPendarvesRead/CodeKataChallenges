using CodeKataChallenges.Logic.Palimdrome;
using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Test.Palimdrome
{
    public class PalimdromeCheckerIntegrationTests
    {
        [Theory]
        [InlineData("A man, a plan, a canal, Panama", true)]
        [InlineData("No 'x' in Nixon", true)]
        [InlineData("Hello, World!", false)]
        public void Workflow_should_give_correct_result(string input, bool expected)
        {
            var workflow = GetUnderTest();
            var output = workflow.CheckPalimdrome(input);
            output.Should().Be(expected);
        }

        private IPalimdromeCheckerWorkflow GetUnderTest()
        {
            return new KataChallengePalimdromeCheckerWorkflow(
                new AlphernumericOnlyInputPreprocessor(),
                new MyPalimdromeCheckerAlgorithm());
        }
    }
}
