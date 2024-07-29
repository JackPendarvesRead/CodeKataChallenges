using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Palimdrome
{
    public class MyPalimdromeCheckerAlgorithm : IPalimdromeCheckerAlgorithm
    {
        public bool CheckPalimdrome(string input)
        {
            int max = (int)Math.Floor((double)input.Length / 2.0);
            for(int i = 0; i <= max; i++)
            {
                bool isEqual = string.Equals(input.Substring(i, 1), input.Substring(input.Length - i - 1, 1), StringComparison.OrdinalIgnoreCase);

                if (!isEqual)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
