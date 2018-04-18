using System.Collections.Generic;
using System.Linq;

namespace CodilityScenarios
{
    /// <summary>
    /// Write a function that, given a zero-indexed array A, returns 1 
    /// if array A is a permutation and 0 if it is not.
    /// </summary>
    public class PermCheck
    {
        public int solution(int[] numericArray)
        {
            // Handle empty Array
            if(numericArray.Length == 0)
            {
                return 0;    
            }

            // Get the expected array content based on known values
            IEnumerable<int> expectedArray = Enumerable.Range(1, numericArray.Max());

            // Sort the array to ensure validity
            IEnumerable<int> targetArray = numericArray.OrderBy(x => x);

            // Compare projected array to actual
            if(targetArray.SequenceEqual(expectedArray))
            {
                return 1;
            }

            // Default
            return 0;
        }
    }
}