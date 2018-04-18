using System.Linq;

namespace CodilityScenarios
{
    /// <summary>
    /// Write a function that, given an array A consisting of N integers 
    /// The array contains an odd number of elements, and each element of the 
    /// array can be paired with another element that has the same value, 
    /// except for one element that is left unpaired. 
    /// Returns the value of the unpaired element.
    /// </summary>
    public class OddOccurances
    {
        public int solution(int[] numericArray)
        {
            // Handle empty array
            if(numericArray.Length == 0)
            {
                return 0;
            }

            // Group the array, get any orphan values, grab the first
            // assuming the array is correctly constructed
            return numericArray.GroupBy(x => x)
                               .Where(y => y.Count()%2 == 1)
                               .Select(g => g.Key)
                               .FirstOrDefault();
                  
        } 
    }
}