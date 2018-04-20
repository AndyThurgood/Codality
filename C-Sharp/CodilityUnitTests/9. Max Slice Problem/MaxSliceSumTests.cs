using Xunit;
using CodilityScenarios;

namespace CodilityUnitTests
{
    public class MaxSliceSumTests
    {
        [Fact]
        public void Max_Slice_Sum_Should_Handle_Empty_Array()
        {
            MaxSliceSum subject = new MaxSliceSum();
            int[] array = { };
            
            Assert.Equal(0, subject.solution(array));
        }
        
        [Fact]
        public void Max_Slice_Sum_Should_Handle_Equal_Array()
        {
            MaxSliceSum subject = new MaxSliceSum();
            int[] array = {0, 0, 0, 0, 0 };
            
            Assert.Equal(0, subject.solution(array));
        }
        
        [Fact]
        public void Max_Slice_Sum_Should_Handle_Linear_Array()
        {
            MaxSliceSum subject = new MaxSliceSum();
            int[] array = {1, 2, 3, 4, 5 };
            
            Assert.Equal(9, subject.solution(array));
        }
        
        [Fact]
        public void Max_Slice_Sum_Should_Handle_Jumbled_Array()
        {
            MaxSliceSum subject = new MaxSliceSum();
            int[] array = {1, 2, -8, 4, -5, 6};
            
            Assert.Equal(6, subject.solution(array));
        }
        
        [Fact]
        public void Max_Slice_Sum_Should_Handle_Decreasing_Array()
        {
            MaxSliceSum subject = new MaxSliceSum();
            int[] array = {1, 2, -8, 4, -5, 1};
            
            Assert.Equal(4, subject.solution(array));
        }
    }
}