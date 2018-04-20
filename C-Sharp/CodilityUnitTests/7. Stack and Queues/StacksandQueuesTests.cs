using Xunit;
using CodilityScenarios;

namespace CodilityUnitTests._7._Stack_and_Queues
{
    public class StacksandQueuesTests
    {
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
    }
}