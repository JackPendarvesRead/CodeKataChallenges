
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
            if(inputArray.Any(x => x < 0))
            {
                throw new NotSupportedException("Negative values in array are currently not supported");
            }

            // Get the first non-zero value in the array and set as the start point
            int startIndex = inputArray.GetIndexOfNextNonZeroValue();

            for(
                int endIndex = startIndex;
                endIndex < inputArray.Length; 
                // each loop set the end index to the next non zero value
                endIndex = inputArray.GetIndexOfNextNonZeroValue(endIndex + 1)
                )
            {
                // Get the current sum of array between start and end index
                int total = inputArray.GetSum(startIndex, endIndex);

                // If the sum exceeds the total then bring the startIndex forward and recalculate total
                while(total > sum && startIndex < endIndex)
                {
                    startIndex = inputArray.GetIndexOfNextNonZeroValue(startIndex + 1);
                    total = inputArray.GetSum(startIndex, endIndex);
                }

                // If sum is matched then return the array value and bring forward the startIndex
                if (total == sum)
                {
                    yield return inputArray.GetSubArray(startIndex, endIndex);
                    startIndex = inputArray.GetIndexOfNextNonZeroValue(startIndex + 1);
                }
            }
        }
    }
}
