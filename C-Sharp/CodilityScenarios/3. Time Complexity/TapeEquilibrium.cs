using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityScenarios
{
    /// <summary>
    /// Tape equilibrium.
    /// </summary>
    public class TapeEquilibrium
    {
        public int solution(int[] numericArray)
        {
            // Handle empty array
            if (numericArray.Length == 0)
            {
                return 0;
            }
           
            // Storage for the diff of parts
            List<int> results = new List<int>();
            int interationLimit = numericArray.Length;

            // Iterate through the array and get the diff between i <-- and remaining array values
            for (int i = 1; i < interationLimit; i++)
            {
                results.Add(Math.Abs(numericArray.Take(i).Sum() - numericArray.Skip(i).Sum()));                   
            }

            return results.Min();    
        }
    }
}