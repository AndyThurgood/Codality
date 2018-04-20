using Xunit;
using CodilityScenarios;
namespace CodilityUnitTests._5._Prefix_Sums
{
    public class PrefixSumTests
    {
        [Fact]
        public void CountDiv_Should_Process_Simple_Range()
        {
            CountDiv subject = new CountDiv();

            int result = subject.solution(6, 11, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void CountDiv_Should_Process_Alternate_Range()
        {
            CountDiv subject = new CountDiv();

            int result = subject.solution(11, 345, 17);

            Assert.Equal(20, result);
        }

        [Fact]
        public void CountDiv_Should_Process_Min_Max_Range()
        {
            CountDiv subject = new CountDiv();

            int result = subject.solution(0, 200000000, 1);

            Assert.Equal(200000001, result);
        }

        [Fact]
        public void CountDiv_Should_Process_Min_Min_Range()
        {
            CountDiv subject = new CountDiv();

            int result = subject.solution(0, 0, 11);

            Assert.Equal(1, result);
        }
        
        [Fact]
        public void GeonomicRangeQuery_Should_Process_Simple_Arrays()
        {
            GeonomicRangeQuery subject = new GeonomicRangeQuery();

            string sequence = "CAGCCTA";
            int[] leftArray = {2, 5, 0 };
            int[] rightArray = {4, 5, 6 };

            int[] expectedResult = {2, 4, 1 };

            int[] result = subject.solution(sequence, leftArray, rightArray);

            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void GeonomicRangeQuery_Should_Process_Complex_Arrays()
        {
            GeonomicRangeQuery subject = new GeonomicRangeQuery();

            string sequence = "AGCCTACAGCCTAGCCTAGCCTAGCCTAGCCTAGCCTAGCCT";
            int[] leftArray = { 2, 0, 23, 2, 8, 3, 2 };
            int[] rightArray = { 9, 14, 24, 5, 18, 9, 3 };

            int[] expectedResult = { 1, 1, 2, 1, 1, 1, 2};

            int[] result = subject.solution(sequence, leftArray, rightArray);

            Assert.Equal(expectedResult, result);

        }
        
        [Fact]
        public void MinAvgTwoSlice_Should_Process_Simple_Array()
        {
            MinAvgTwoSlice subject = new MinAvgTwoSlice();

            int expectedResult = 1;
            int[] array = {4, 2, 2, 5, 1, 5, 8 };

            int result = subject.solution(array);

            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void PassingSars_Should_Process_Simple_Array()
        {
            PassingCars subject = new PassingCars();

            int[] array = {0, 1, 0, 1, 1};
            int result = subject.solution(array);

            Assert.Equal(5, result);
        }

        [Fact]
        public void PassingSars_Should_Process_East_Only_Array()
        {
            PassingCars subject = new PassingCars();

            int[] array = { 0, 0, 0, 0, 0 };
            int result = subject.solution(array);

            Assert.Equal(0, result);
        }

        [Fact]
        public void PassingCars_Should_Process_West_Only_Array()
        {
            PassingCars subject = new PassingCars();

            int[] array = { 1, 1, 1, 1, 1 };
            int result = subject.solution(array);

            Assert.Equal(0, result);
        }
    }
}