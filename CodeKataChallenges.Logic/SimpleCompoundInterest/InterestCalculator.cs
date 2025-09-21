using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.SimpleCompoundInterest
{
    public class InterestCalculator
    {
        // I think this method is horrible but just following the prompt instructions
        public (int simpleInterest, int compoundInterest) Calculate(double principal, double rate, int periods)
        {
            if(principal < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(principal), "Principal amount cannot be negative");
            }
            if(rate < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rate), "Rate cannot be negative");
            }
            if(periods < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(periods), "Must have at least one period");
            }

            int simpleInterest = (int)Math.Round(principal * (1 + rate * periods), 0, MidpointRounding.ToEven);
            int compoundInterest = (int)Math.Round(principal * Math.Pow(1 + rate, periods), 0, MidpointRounding.ToEven);

            return (simpleInterest, compoundInterest);
        }
    }
}
