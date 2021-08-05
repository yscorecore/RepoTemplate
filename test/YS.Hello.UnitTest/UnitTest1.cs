
using FluentAssertions;
using Xunit;

namespace Hello.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            "abc".Should().Be("abc");
        }
        
    }
}
