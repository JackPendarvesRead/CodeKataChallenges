using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Palimdrome
{
    public class KataChallengePalimdromeCheckerWorkflow : IPalimdromeCheckerWorkflow
    {
        private readonly IInputPreprocessor inputPreprocessor;
        private readonly IPalimdromeCheckerAlgorithm palimdromeCheckerAlgorithm;

        public KataChallengePalimdromeCheckerWorkflow(IInputPreprocessor inputPreprocessor, IPalimdromeCheckerAlgorithm palimdromeCheckerAlgorithm)
        {
            this.inputPreprocessor = inputPreprocessor;
            this.palimdromeCheckerAlgorithm = palimdromeCheckerAlgorithm;
        }

        public bool CheckPalimdrome(string input)
        {
            var processed = inputPreprocessor.Preprocess(input);
            return palimdromeCheckerAlgorithm.CheckPalimdrome(processed);
        }
    }
}
