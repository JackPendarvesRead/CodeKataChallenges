using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.SubArraySum
{
    public static class IntArrayExtensions
    {
        public static int GetSum(this int[] array, int startIndex, int endIndex)
        {
            int sum = 0;
            for(int i = startIndex; i <= endIndex; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static int[] GetSubArray(this int[] array, int startIndex, int endIndex)
        {
            return Enumerate(array, startIndex, endIndex).ToArray();

            static IEnumerable<int> Enumerate(int[] array, int startIndex, int endIndex)
            {
                for(int i = startIndex; i <= endIndex; ++i)
                {
                    yield return array[i];
                }
            }
        }

        public static int GetIndexOfNextNonZeroValue(this int[] array, int start = 0)
        {
            for(int i = start; i < array.Length; ++i)
            {
                if(array[i] != 0)
                {
                    return i;
                }
            }

            return array.Length + 1;
        }
    }
}
