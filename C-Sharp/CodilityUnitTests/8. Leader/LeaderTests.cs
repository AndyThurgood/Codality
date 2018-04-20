using CodilityScenarios;
using Xunit;

namespace CodilityUnitTests._8._Leader
{
    public class LeaderTests
    {
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