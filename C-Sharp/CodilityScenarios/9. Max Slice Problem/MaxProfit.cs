
namespace CodilityScenarios
{
    /// <summary>
    /// Write a function that, given an array A consisting of N integers containing daily
    /// prices of a stock share for a period of N consecutive days, returns the maximum possible
    /// profit from one transaction during this period. The function should return 0 if it was
    /// impossible to gain any profit.
    /// </summary>
    public class MaxProfit
    {
        public int solution(int[] numericArray)
        {
            // Defensive code
            if (numericArray.Length == 0)
            {
                return 0;
            }
            
            // Store min and sell values
            int minValue = int.MaxValue;
            int sellValue = 0;

            // loop and conditionally set values
            foreach (int stockPrice in numericArray)
            {
                if (stockPrice < minValue)
                {
                    minValue = stockPrice;
                }

                if (stockPrice - minValue > sellValue)
                {
                    sellValue = stockPrice - minValue;
                }
            }

            return sellValue;
        }
    }
}