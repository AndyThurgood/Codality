using System.Collections.Generic;
using Xunit;
using CodilityScenarios;

namespace CodilityUnitTests._4._Counting_Elements
{
    public class CountingElementTests
    {
        [Fact]
        public void PermCheck_Should_Handle_Empty_Array()
        {
            PermCheck subject = new PermCheck();

            int[] array = { };

            int result = subject.solution(array);

            Assert.Equal(0, result);
        }

        [Fact]
        public void PermCheck_Should_Validate_Permutation_Array()
        {
            PermCheck subject = new PermCheck();

            int[] array = {4, 1, 3, 2 };

            int result = subject.solution(array);

            Assert.Equal(1, result);
        }

        [Fact]
        public void PermCheck_Should_Validate_Single_Permutation_Array()
        {
            PermCheck subject = new PermCheck();

            int[] array = { 1 };

            int result = subject.solution(array);

            Assert.Equal(1, result);
        }

        [Fact]
        public void PermCheck_Should_Invalidate_Non_Permutation_Array()
        {
            PermCheck subject = new PermCheck();

            int[] array = { 4, 1, 2 };

            int result = subject.solution(array);

            Assert.Equal(0, result);
        }

        [Fact]
        public void FrogRiverOne_Should_Handle_Empty_Array()
        {
            FrogRiverOne subject = new FrogRiverOne();

            int[] array = { };

            int result = subject.solution(1, array);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void FrogRiverOne_Should_Validate_Complete_Array()
        {
            FrogRiverOne subject = new FrogRiverOne();

            int[] array = { 1, 3, 1, 4, 2, 3, 5, 4 };

            int result = subject.solution(5, array);

            Assert.Equal(6, result);
        }

        [Fact]
        public void FrogRiverOne_Should_Invalidate_Incomplete_Array()
        {
            FrogRiverOne subject = new FrogRiverOne();

            int[] array = { 4, 1, 2 };

            int result = subject.solution(5, array);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void FrogRiverOne_Should_Validate_Complex_Array()
        {
            FrogRiverOne subject = new FrogRiverOne();

            int[] array = { 4, 1, 2, 8, 7, 3, 2, 6, 1, 2, 9, 11, 13, 14, 16, 17, 12, 13, 14, 15, 18, 5, 10};

            int result = subject.solution(10, array);

            Assert.Equal(22, result);
        }

        [Fact]
        public void MaxCounters_Should_Validate_Simple_Array()
        {
            MaxCounters subject = new MaxCounters();

            int[] array = { 3, 4, 4, 6, 1, 4, 4 };

            int[] expectedArray = { 3, 2, 2, 4, 2 };

            int[] result = subject.solution(5, array);

            Assert.Equal(expectedArray, result);
        }

        [Fact]
        public void MaxCounters_Should_Validate_Single_Array()
        {
            MaxCounters subject = new MaxCounters();

            int[] array = { 3 };

            int[] expectedArray = {0, 0, 1 };

            int[] result = subject.solution(3, array);

            Assert.Equal(expectedArray, result);
        }
        
        [Fact]
        public void MissingIntegers_Should_Handle_EmptyArray()
        {
            MissingIntegers subject = new MissingIntegers();

            List<int> parameter = new List<int>();
            int result = subject.solution(parameter.ToArray());

            Assert.Equal(1, result);
        }

        [Fact]
        public void MissingIntegers_Should_Handle_NegtiveArray()
        {
            MissingIntegers subject = new MissingIntegers();

            List<int> parameter = new List<int>{-1, -2, -3};
            int result = subject.solution(parameter.ToArray());

            Assert.Equal(1, result);
        }

        [Fact]
        public void MissingIntegers_Should_Handle_SimpleArray()
        {
            MissingIntegers subject = new MissingIntegers();

            List<int> parameter = new List<int> { 1, 2, 3, 6, 7, 8, 9};
            int result = subject.solution(parameter.ToArray());

            Assert.Equal(4, result);
        }

        [Fact]
        public void MissingIntegers_Should_Process_SequentialArray()
        {
            MissingIntegers subject = new MissingIntegers();

            List<int> parameter = new List<int> { 1, 2, 3 };
            int result = subject.solution(parameter.ToArray());

            Assert.Equal(4, result);
        }

        [Fact]
        public void MissingIntegers_Should_Process_Negative_And_Positive()
        {
            MissingIntegers subject = new MissingIntegers();

            List<int> parameter = new List<int> { -1000, 2000 };
            int result = subject.solution(parameter.ToArray());

            Assert.Equal(1, result);
        }

        [Fact]
        public void MissingIntegers_Should_Process_Max_Values()
        {
            MissingIntegers subject = new MissingIntegers();

            List<int> parameter = new List<int> { -100000, 100000 };
            int result = subject.solution(parameter.ToArray());

            Assert.Equal(1, result);
        }
    }
}