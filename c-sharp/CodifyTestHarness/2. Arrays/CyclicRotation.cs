using System.Collections.Generic;
using System.Linq;

namespace CodalityTestLibrary
{
    /// <summary>
    /// Write a function that, given a zero-indexed array A consisting of N 
    /// integers and an integer K, returns the array A rotated K times.
    /// </summary>
    public class CyclicRotation
    {
        public int[] solution(int[] numericArray, int rotations)
        {

            // Handle empty parameters
            if (numericArray.Any() || rotations == 0)
            {
                return numericArray;
            }

            // Extend array to get Linq functions
            List<int> numericList = numericArray.ToList();

            // Iterate on rotation count, move last array item from back to front
            for (int i = 1; i <= rotations; i++)
            {
                int lastValue = numericList.LastOrDefault();
                numericList.RemoveAt(numericList.Count() - 1);
                numericList.Insert(0, lastValue);
            }

            return numericList.ToArray();
        }
    }
}
