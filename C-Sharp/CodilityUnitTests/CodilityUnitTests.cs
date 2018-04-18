using System.Collections.Generic;
using CodilityScenarios;
using Xunit;

namespace CodilityUnitTests
{
    public class CodalityUnitTests
    {
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
    
        [Fact]
        public void BinaryGap_Should_Handle_Zero_Value()
        {
            BinaryGap subject = new BinaryGap();

            int result = subject.solution(0);

            Assert.Equal(0, result);
        }

        [Fact]
        public void BinaryGap_Should_Process_Simple_Value()
        {
            BinaryGap subject = new BinaryGap();

            int result = subject.solution(6);

            Assert.Equal(0, result);
        }

        [Fact]
        public void BinaryGap_Should_Process_Complex_Value()
        {
            BinaryGap subject = new BinaryGap();

            int result = subject.solution(51712);

            Assert.Equal(2, result);
        }

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

        [Fact]
        public void StoneWall_Should_Process_Simple_Array()
        {
            StoneWall subject = new StoneWall();

            int[] array = { 8, 8, 5, 7, 9, 8, 7, 4, 8 };

            int result = subject.solution(array);

            Assert.Equal(7, result);

        }

        [Fact]
        public void StoneWall_Should_Handle_Empty_Array()
        {
            StoneWall subject = new StoneWall();

            int[] array = {  };

            int result = subject.solution(array);

            Assert.Equal(0, result);

        }

        [Fact]
        public void StoneWall_Should_Handle_One_Value_Array()
        {
            StoneWall subject = new StoneWall();

            int[] array = { 1 };

            int result = subject.solution(array);

            Assert.Equal(1, result);

        }

        [Fact]
        public void StoneWall_Should_Handle_Two_Value_Array()
        {
            StoneWall subject = new StoneWall();

            int[] array = { 1, 2 };

            int result = subject.solution(array);

            Assert.Equal(2, result);

        }

        [Fact]
        public void Brackets_Should_Handle_Simple_StringPattern()
        {
            Brackets subject = new Brackets();

            string testValue = "{[()()]}";

            int result = subject.solution(testValue);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Brackets_Should_Handle_Complex_StringPattern()
        {
            Brackets subject = new Brackets();

            string testValue = "{}()[]{()()()()}[][]({}{}{})";

            int result = subject.solution(testValue);

            Assert.Equal(1, result);
        }


        [Fact]
        public void Brackets_Should_Handle_Empty_String()
        {
            Brackets subject = new Brackets();

            string testValue = "";

            int result = subject.solution(testValue);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Brackets_Should_Handle_Uneven_String()
        {
            Brackets subject = new Brackets();

                string testValue = "{{}}(";

            int result = subject.solution(testValue);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Brackets_Should_Handle_SingleCharType_String()
        {
            Brackets subject = new Brackets();

            string testValue = "[[[[";

            int result = subject.solution(testValue);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Dominator_Should_Handle_Simple_Array()
        {
            Dominator subject = new Dominator();

            int[] array = { 3, 4, 3, 2, 3, -1, 3, 3 };

            int result = subject.solution(array);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Dominator_Should_Handle_Single_Entry_Array()
        {
            Dominator subject = new Dominator();

            int[] array = { 3 };

            int result = subject.solution(array);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Dominator_Should_Handle_Equal_Array()
        {
            Dominator subject = new Dominator();

            int[] array = { 3, 3, 3, 3, 5, 4, 4, 4, 4 };

            int result = subject.solution(array);

            Assert.Equal(-1, result);
        }

    }
}
