using Xunit;
using CodilityScenarios;

namespace CodilityUnitTests._3._Time_Complexity
{
    public class TimeComplexityTests
    {
        [Fact]
        public void TapeEquilibrium_Should_Handle_Empty_Array()
        {
            TapeEquilibrium subject = new TapeEquilibrium();

            int[] array = {};

            int result = subject.solution(array);

            Assert.Equal(0, result);
        }

        [Fact]
        public void TapeEquilibrium_Should_Process_Simple_Array()
        {
            TapeEquilibrium subject = new TapeEquilibrium();

            int[] array = { 3, 1, 2, 4, 3};

            int result = subject.solution(array);

            Assert.Equal(1, result);
        }

        [Fact]
        public void TapeEquilibrium_Should_Process_Negative_Array()
        {
            TapeEquilibrium subject = new TapeEquilibrium();

            int[] array = { -3, -1, -2, -4, -3 };

            int result = subject.solution(array);

            Assert.Equal(1, result);
        }

        [Fact]
        public void TapeEquilibrium_Should_Process_MaxNumbers_Array()
        {
            TapeEquilibrium subject = new TapeEquilibrium();

            int[] array = {-1000, 1000 };

            int result = subject.solution(array);

            Assert.Equal(2000, result);
        }

        [Fact]
        public void TapeEquilibrium_Should_Process_Complex_Array()
        {
            TapeEquilibrium subject = new TapeEquilibrium();

            int[] array = {1000, 500, 3, 5, -1000 };

            int result = subject.solution(array);

            Assert.Equal(1492, result);
        }

        [Fact]
        public void FrogJump_Should_Process_Simple_Values()
        {
            FrogJump subject = new FrogJump();

            int result = subject.solution(10, 85, 30);

            Assert.Equal(3, result);
        }

        [Fact]
        public void FrogJump_Should_Process_Max_Values()
        {
            FrogJump subject = new FrogJump();

            int result = subject.solution(1, 10000000, 1);

            Assert.Equal(9999999, result);
        }

        [Fact]
        public void PermMissingElem_Should_Handle_Empty_Array()
        {
            PermMissingElem subject = new PermMissingElem();

            int[] array = { };

            int result = subject.solution(array);

            Assert.Equal(1, result);
        }

        [Fact]
        public void PermMissingElem_Should_Process_Simple_Values()
        {
            PermMissingElem subject = new PermMissingElem();

            int[] array = {2, 3, 1, 5};

            int result = subject.solution(array);

            Assert.Equal(4, result);
        }

        [Fact]
        public void PermMissingElem_Should_Process_Single_Values()
        {
            PermMissingElem subject = new PermMissingElem();

            int[] array = { 2 };

            int result = subject.solution(array);

            Assert.Equal(1, result);
        }

        [Fact]
        public void PermMissingElem_Should_Process_Complex_Values()
        {
            PermMissingElem subject = new PermMissingElem();

            int[] array = { 2, 3, 1, 5, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                            21, 23, 24, 25, 26, 27, 28, 29, 30};

            int result = subject.solution(array);

            Assert.Equal(22, result);
        }
    }
}