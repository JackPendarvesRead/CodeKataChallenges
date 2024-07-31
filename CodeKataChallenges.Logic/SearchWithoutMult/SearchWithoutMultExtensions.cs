﻿using System;
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
            int i = 0;

            int diff = end - start;

            while (i + i < diff)
            {
                i++;
            }

            return start + i;
        }
    }
}
