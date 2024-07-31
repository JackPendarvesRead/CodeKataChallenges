using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.SearchWithoutMult
{
    public static class SearchWithoutMultExtensions
    {
        public static bool ContainsWithoutMult(this List<int> sortedList, int n)
        {
            int start = 0;
            int end = sortedList.Count - 1;

            if (n < sortedList[start] || n > sortedList[end])
            {
                return false;
            }

            while (start <= end)
            {
                int mid = GetMidpointIndex(start, end);

                if (n > sortedList[mid])
                {
                    start = mid + 1;
                }
                else if (n < sortedList[mid])
                {
                    end = mid - 1;
                }

                else
                {
                    return true;
                }
            }

            return false;
        }

        private static int GetMidpointIndex(int start, int end)
        {
            int diff = end - start;
            if(diff == 0)
            {
                return start;
            }

            int i = 1;
            while (i + i < diff)
            {
                // This will not find perfect mid-point but should be faster for large ranges
                i += i;
            }

            return start + i;
        }
    }
}
