using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.RotatingList
{
    public static class ListRotationExtensions
    {
        /// <summary>
        /// Rotates this list by k units
        /// </summary>
        /// <typeparam name="TItem">The type of the item contained within list</typeparam>
        /// <param name="input">The list which is having its items rotated</param>
        /// <param name="k">The number in which list items should be rotated by. Positive value shifts items left.</param>
        /// <returns>The list with its items shifted by k</returns>
        public static IList<TItem> RotateList<TItem>(this IList<TItem> input, int k)
        {
            k %= input.Count;

            if (k == 0)
                return input;

            int run = 0;
            int index = 0;
            TItem current = input[0];
            while(run < input.Count)
            {
                int replacementIndex = GetReplacementIndex(index, k, input.Count);
                TItem itemToReplace = input[replacementIndex];
                input[replacementIndex] = current;
                current = itemToReplace;

                run++;
                index = replacementIndex;
            }
            return input;
        }

        /// <summary>
        /// Get the index in which item at index i should be placed
        /// </summary>
        /// <param name="i">Index of item to be moved</param>
        /// <param name="k">The number of indices that item should be moved (positive = clockwise)</param>
        /// <param name="listLength">The length of the list which is being rotated</param>
        /// <returns>The index which item at index i should be placed</returns>
        private static int GetReplacementIndex(int i, int k, int listLength)
        {
            var replacementIndex = i - k;

            replacementIndex %= listLength;
            if(replacementIndex < 0)
            {
                replacementIndex += listLength;
            }

            return replacementIndex;
        }
    }
}
