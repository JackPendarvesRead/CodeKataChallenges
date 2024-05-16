
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
            return inputArray.Any(x => x < 0) 
                ? NegativesSupported(inputArray, sum) 
                : PositiveOnlyMethod(inputArray, sum);
        }

        private IEnumerable<int[]> PositiveOnlyMethod(int[] inputArray, int sum)
        {
            // Get the first non-zero value in the array and set as the start point
            int startIndex = inputArray.GetIndexOfNextNonZeroValue();

            int total = 0;
            for (
                int endIndex = startIndex;
                endIndex < inputArray.Length;
                // each loop set the end index to the next non zero value
                endIndex = inputArray.GetIndexOfNextNonZeroValue(endIndex + 1)
                )
            {
                // Get the current sum of array between start and end index
                total += inputArray[endIndex];

                // If the sum exceeds the total then bring the startIndex forward and recalculate total
                while (total > sum && startIndex < endIndex)
                {
                    startIndex = inputArray.GetIndexOfNextNonZeroValue(startIndex + 1);
                    total = inputArray.GetSum(startIndex, endIndex);
                }

                // If sum is matched then return the array value and bring forward the startIndex
                if (total == sum)
                {
                    yield return inputArray.GetSubArray(startIndex, endIndex);
                    startIndex = inputArray.GetIndexOfNextNonZeroValue(startIndex + 1);
                    total = inputArray.GetSum(startIndex, endIndex);
                }
            }
        }

        private IEnumerable<int[]> NegativesSupported(int[] inputArray, int sum)
        {
            throw new NotImplementedException();
        }
    }
}
