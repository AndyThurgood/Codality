using Xunit;
using CodilityScenarios;

namespace CodilityUnitTests._6._Sorting
{
    public class SortingTests
    {
        [Fact]
        public void Distinct_Should_Hanlde_Empty_Array()
        {
            Distinct subject = new Distinct();

            int[] array = { };

            int result = subject.solution(array);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Distinct_Should_Process_Simple_Array()
        {
            Distinct subject = new Distinct();

            int[] array = {2, 1, 1, 2, 3, 1 };

            int result = subject.solution(array);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Distinct_Should_Process_Complex_Array()
        {
            Distinct subject = new Distinct();

            int[] array = { 2, 1, 1, 2, 3, 1, 2, 1, 1, 2, 3, 1, 2, 1, 1, 2, 3, 1,
                5, 7, 8, 3, 2, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 6, 7};

            int result = subject.solution(array);

            Assert.Equal(10, result);
        }

        [Fact]
        public void MaxProductOfThree_Should_Handle_Empty_Array()
        {
            MaxProductOfThree subject = new MaxProductOfThree();

            int[] array = { };

            int result = subject.solution(array);

            Assert.Equal(0, result);
        }

        [Fact]
        public void MaxProductOfThree_Should_Process_Simple_Array()
        {
            MaxProductOfThree subject = new MaxProductOfThree();

            int[] array = {-3, 1, 2, -2, 5, 6 };

            int result = subject.solution(array);

            Assert.Equal(60, result);
        }

        [Fact]
        public void MaxProductOfThree_Should_Process_Negative_Array(){

            MaxProductOfThree subject = new MaxProductOfThree();

            int[] array = { -5, 5, -5, 4 };

            int result = subject.solution(array);

            Assert.Equal(125, result);

        }
    }
}