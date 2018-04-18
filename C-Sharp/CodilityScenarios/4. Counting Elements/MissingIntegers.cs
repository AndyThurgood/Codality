using System.Linq;

namespace CodilityScenarios
{
    /// <summary>
    /// Write a function that, given an array A of N integers, returns the 
    /// smallest positive integer(greater than 0) that does not occur in A.
    /// </summary>
    public class MissingIntegers
    {
        public int solution(int[] numericArray)
        {
            int minimalReturnValue = 1;

            // defensive code
            if (numericArray.Length == 0)
            {
                return minimalReturnValue;
            }

            // Handle edge case negative array
            if (numericArray.All(x => x <= 0))
            {
                return minimalReturnValue;
            }

            // Get the potential possible list entries between known min (1) and the max array 
            // value, then find the first (smallest) missing instance
            int returnValue = Enumerable.Range(minimalReturnValue, numericArray.Max())
                                    .Except(numericArray)
                                    .FirstOrDefault();

            // If we have a positive value then return that
            if (returnValue > 0)
            {
                return returnValue;
            }

            if (returnValue < 0)
            {
                return minimalReturnValue;
            }

            // If we hit a this, assume sequential array so return the next max value
            return numericArray.Max() + 1;
        }
    }
}
