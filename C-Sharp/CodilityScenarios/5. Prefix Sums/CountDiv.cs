namespace CodilityScenarios
{
    /// <summary>
    /// Write a function that, given three integers A, B and K, returns the 
    /// number of integers within the range [A..B] that are divisible by K
    /// </summary>
    public class CountDiv
    {
        public int solution(int a, int b, int k)
        {
            // linq solution (slow)
            //IEnumerable<int> numericRange = Enumerable.Range(a, (b - a));
            //return numericRange.Count(x => x % k == 0);

            // Loop solution (Still slow)
            int divisibleCount = 0;
           
            for (int i = a; i <= b; i++)
            {
                if(i % k == 0)
                {
                   divisibleCount++;    
                }
            }

            return divisibleCount;

            // Do the Math
            // return b/k - (a-1)/k;
        }
    }
}