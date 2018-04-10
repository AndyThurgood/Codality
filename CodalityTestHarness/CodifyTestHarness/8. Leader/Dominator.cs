using System;
using System.Linq;
namespace CodalityTestLibrary
{
    /// <summary>
    /// Write a function that, given a zero-indexed array A consisting of 
    /// N integers, returns index of any element of array A in which 
    /// the dominator of A occurs. The function should return −1 if array A does not have a dominator.
    /// </summary>
    public class Dominator
    {
        public int solution(int[] numericArray)
        {
            // Guard against an empty Array
            if(numericArray.Length == 0)
            {
                return -1;
            }

            // Group the array and then sort to get the most occurances
            IGrouping<int, int> maxOccurance = numericArray.GroupBy(x => x)
                                                           .OrderByDescending(g => g.Count())
                                                           .FirstOrDefault();

            // Check if the number of occurances is more than half.
            if (numericArray.Length / 2 < maxOccurance.Count())
            {
                return Array.IndexOf(numericArray, maxOccurance.Key);
            }

            // Return a default outcome
            return -1;
        }
    }
}
