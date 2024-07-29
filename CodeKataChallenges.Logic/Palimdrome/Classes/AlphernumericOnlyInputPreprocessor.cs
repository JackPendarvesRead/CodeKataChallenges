using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Palimdrome
{
    public class AlphernumericOnlyInputPreprocessor : IInputPreprocessor
    {
        private static Regex alphanumericsOnlyRegex = new Regex(@"[^a-zA-Z0-9]");

        public string Preprocess(string input)
        {
            return alphanumericsOnlyRegex.Replace(input, "");
        }
    }
}
