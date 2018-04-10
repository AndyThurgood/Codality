using System;
using System.Collections.Generic;
using System.Linq;

namespace CodalityTestLibrary
{
    /// <summary>
    /// Write a function that, given a non-empty zero-indexed array A of N 
    /// integers, returns the number of pairs of passing cars
    /// </summary>
    public class PassingCars
    {
        public int solution(int[] numericArray)
        {
            int passCount = 0;

            for (int i = 0; i < numericArray.Length; i++)
            {
                if (numericArray[i] == 0)
                {
                    passCount += numericArray.Skip(i).Sum();
                }
            }

            return passCount;
        }
    }
}
