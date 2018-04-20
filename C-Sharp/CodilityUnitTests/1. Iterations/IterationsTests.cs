using CodilityScenarios;
using Xunit;

namespace CodilityUnitTests._1._Iterations
{
    public class IterationsTests
    {
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
    }
}