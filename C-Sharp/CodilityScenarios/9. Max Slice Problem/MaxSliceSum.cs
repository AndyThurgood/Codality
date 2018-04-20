
namespace CodilityScenarios
{
    /// <summary>
    /// Write a function that, given an array A consisting of N integers,
    /// returns the maximum sum of any slice of A.
    /// </summary>
    public class MaxSliceSum
    {
        public int solution(int[] numericArray)
        {
            // Defensive code
            if (numericArray.Length == 0)
            {
                return 0;
            }
            
            // store the greatest slice value
            int sliceTotal = 0;

            // loop and compute if we get a higher value
            for (int i = 0; i < numericArray.Length; i++)
            {
                int slice = numericArray[i];
                
                if (slice > sliceTotal)
                {
                    sliceTotal = slice;
                }
                
                // Handle the fact that a slice can only be 1 or 2 elements
                if ((i + 1) < numericArray.Length)
                {
                    if (numericArray[i + 1] + slice > sliceTotal)
                    {
                        sliceTotal = numericArray[i + 1] + slice;
                    }
                }
            }

            return sliceTotal;
        }
    }
}