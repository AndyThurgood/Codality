using System.Linq;

namespace CodalityTestLibrary
{
    /// <summary>
    /// Write a function that, given a non-empty zero-indexed array A, 
    /// returns the value of the maximal product of any triplet
    /// </summary>
    public class MaxProductOfThree
    {
        public int solution(int[] numericArray)
        {
            // Guard against empty array
            if(numericArray.Length == 0){
                return 0;
            }

            // Get the values in order High --> Low
            int[] sortedArray = numericArray.OrderByDescending(x => x).ToArray();

            // Get the first 3 highest values, and compute them them
            int positiveCalculation = (sortedArray[0] * sortedArray[1] * sortedArray[2]);

            // Math says that computing 2 negatives makes a positive so...
            int negativeCalculation = (sortedArray[sortedArray.Length - 1] * sortedArray[sortedArray.Length - 2] * sortedArray[0]);

            return positiveCalculation > negativeCalculation ? positiveCalculation : negativeCalculation;
        }
    }
}
