using Xunit;
using CodilityScenarios;

namespace CodilityUnitTests._2._Arrays
{
    public class ArrayTests
    {
        
        [Fact]
        public void CyclicRotation_Should_Handle_Zero_Value()
        {
            CyclicRotation subject = new CyclicRotation();

            int[] array = {};

            int[] result = subject.solution(array, 0);

            Assert.Equal(array, result);
        }

        [Fact]
        public void CyclicRotation_Should_Process_Simple_Values()
        {
            CyclicRotation subject = new CyclicRotation();

            int[] array = {1,2,3,4};

            int[] result = subject.solution(array, 1);

            int[] expectedResult = { 4, 1, 2, 3 };

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CyclicRotation_Should_Process_Complex_Values()
        {
            CyclicRotation subject = new CyclicRotation();

            int[] array = { 12, 14, 18, 19, 100, 1999, 345, 1223, 45436, 654654 };

            int[] result = subject.solution(array, 15);

            int[] expectedResult = { 1999, 345, 1223, 45436, 654654, 12, 14, 18, 19, 100};

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void OddOccurances_Should_Handle_Empty_Array()
        {
            OddOccurances subject = new OddOccurances();

            int[] array = {  };

            int result = subject.solution(array);

            Assert.Equal(0, result);
        }

        [Fact]
        public void OddOccurances_Should_Process_Valid_Array()
        {
            OddOccurances subject = new OddOccurances();

            int[] array = {1, 5, 9, 1, 4, 5, 9, 4, 11};

            int result = subject.solution(array);

            Assert.Equal(11, result);
        }

        [Fact]
        public void OddOccurances_Should_Process_Complex_Array()
        {
            OddOccurances subject = new OddOccurances();

            int[] array = { 1, 4, 5, 9, 1, 4, 5, 9, 11 , 11, 11};

            int result = subject.solution(array);

            Assert.Equal(11, result);
        }
    }
}