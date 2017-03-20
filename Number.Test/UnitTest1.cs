using Xunit;

namespace Number.Test
{
    public class UnitTest1
    {
        private readonly Program _program;
        public UnitTest1() {
            _program = new Program();
        }

        [Fact]
        public void Test1()
        {
            int number = 5;
            var result = _program.AddNumberExtension(number);
            Assert.Equal(result, $"{number}th");
        }
    }
}
