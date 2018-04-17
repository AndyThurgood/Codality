using System;
using System.Linq;

namespace CodalityTestLibrary
{
    /// <summary>
    /// Write a function, that, given a zero-indexed array A consisting of 
    /// N integers, returns the number of distinct values in array A.
    /// </summary>
    public class Distinct
    {
        public int solution(int[] numericArray)
        {
            // Gaurd against empty array
            if(numericArray.Length == 0)
            {
                return 0;
            }

            // Use linqs distinct built in
            return numericArray.Distinct().Count();
        }
    }
}
