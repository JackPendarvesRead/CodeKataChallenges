
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.SubArraySum
{
    public class SubArraySumCalculator
    {
        public IEnumerable<int[]> GetSubArrayForSum(int[] inputArray, int sum)
        {
            if(inputArray.Count(x => x < 0) > 0)
            {
                throw new NotSupportedException("Negative values in array are currently not supported");
            }

            // Get the first non-zero value in the array and set as the start point
            int startIndex = inputArray.GetIndexOfNextNonZeroValue();

            for(
                int endIndex = startIndex;
                endIndex < inputArray.Length; 
                endIndex = inputArray.GetIndexOfNextNonZeroValue(endIndex + 1)
                )
            {
                int total = inputArray.GetSum(startIndex, endIndex);

                while(total > sum && startIndex < endIndex)
                {
                    startIndex = inputArray.GetIndexOfNextNonZeroValue(startIndex + 1);
                    total = inputArray.GetSum(startIndex, endIndex);
                }

                if (total == sum)
                {
                    yield return inputArray.GetSubArray(startIndex, endIndex);
                    startIndex = inputArray.GetIndexOfNextNonZeroValue(startIndex + 1);
                }
            }
        }
    }
}
