
namespace CodilityScenarios
{
    /// <summary>
    /// Write a function that, given an integer N and a non-empty zero-indexed 
    /// array A consisting of M integers, returns a sequence of integers 
    /// representing the values of the counters.
    /// </summary>
    public class MaxCounters
    {
        public int[] solution(int counterLimit, int[] numericArray)
        {
            // Instantiate the counters
            int[] counters = new int[counterLimit];
            int maxValue = 0;

            for (int i = 0; i < numericArray.Length; i++)
            {
                int element = numericArray[i];

                // Guard against out of range 
                if (element > counterLimit)
                {
                    // check if we need to max counters
                    if (element == (counterLimit + 1))
                    {
                        // Dot Net Core Solution
                        // Array.Fill(counters, counters.Max());

                        // .NET 4.5 :(
                        for (int ii = 0; ii < counterLimit; ii++){
                            
                            counters[ii] = maxValue;
                        }
                    }

                    continue;
                }

                // Standard Increment    
                counters[element - 1]++;

                // Track the max value
                if(maxValue < counters[element - 1])
                {
                    maxValue = counters[element - 1];
                }
            }

            return counters;
        }
    }
}
