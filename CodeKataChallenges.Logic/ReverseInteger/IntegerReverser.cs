using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.ReverseInteger
{
    public static class IntegerReverser
    {
        public static int Reverse(int input)
        {            
            try
            {
                return int.Parse(new string(Math.Abs(input).ToString().ToCharArray().Reverse().ToArray())) * (input > 0 ? 1 : -1);
            }
            catch (OverflowException)
            {
                return 0;
            }
        }
    }
}
