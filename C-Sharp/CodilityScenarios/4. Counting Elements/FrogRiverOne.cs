using System.Collections.Generic;

namespace CodilityScenarios
{
    /// <summary>
    /// Write a function that, given a non-empty zero-indexed array A 
    /// consisting of N integers and integer X, returns the earliest time 
    /// when the frog can jump to the other side of the river.
    /// </summary>
    public class FrogRiverOne
    {
        public int solution(int target, int[] numericArray)
        {
            // Handle empty Array
            if (numericArray.Length == 0)
            {
                return -1;
            }

            // Get the expected array content based on known values
            HashSet<int> requiredRange = new HashSet<int>();

            // Iterate until all required array elements are encountered.
            for (int i = 0; i < numericArray.Length; i ++)
            {
                int arrayValue = numericArray[i];
                if (!requiredRange.Contains(arrayValue) && arrayValue <= target)
                {
                    requiredRange.Add(arrayValue);
                }

                if(requiredRange.Count == target){
                    return i;
                }
            }

            return -1;
        }
    }
}