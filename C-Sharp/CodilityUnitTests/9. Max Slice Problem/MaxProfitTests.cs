using Xunit;
using CodilityScenarios;

namespace CodilityUnitTests
{
    /// <summary>
    /// Tests to support the Max Profit Solution
    /// </summary>
    public class MaxProfitTests
    {
        [Fact]
        public void Max_Profit_Should_Handle_Empty_Array()
        {
            MaxProfit subject = new  MaxProfit();
            int[] array = { };

            Assert.Equal(0, subject.solution(array));
        }

        [Fact]
        public void Max_Profit_Should_Identify_No_Profits()
        {
            MaxProfit subject = new  MaxProfit();
            int[] array = {0, 0, 0, 0 };
            
            Assert.Equal(0, subject.solution(array));
        }
        
        [Fact]
        public void Max_Profit_Should_Handle_Negative_Values_And_No_Profits()
        {
            MaxProfit subject = new  MaxProfit();
            int[] array = {5000, 0, 0, 0 };
            
            Assert.Equal(0, subject.solution(array));
        }
        
        [Fact]
        public void Max_Profit_Should_Handle_Simple_Profit_Scenario()
        {
            MaxProfit subject = new  MaxProfit();
            int[] array = {100, 200, 800, 600 };
            
            Assert.Equal(700, subject.solution(array));
        }
        
        [Fact]
        public void Max_Profit_Should_Handle_Complex_Profit_Scenario()
        {
            MaxProfit subject = new  MaxProfit();
            int[] array = {100, 200, 800, 600, 400, 1600, 950, 0, 1500, 2000 };
            
            Assert.Equal(2000, subject.solution(array));
        }
        
        [Fact]
        public void Max_Profit_Should_Handle_Max_Values()
        {
            MaxProfit subject = new  MaxProfit();
            int[] array = {0, 0, 0, 0 , 200000};
            
            Assert.Equal(200000, subject.solution(array));
        }
        
        
    }
}