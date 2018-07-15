using FluentAssertions;
using Xunit;

namespace DemoApp.ApplicationService.Tests
{
    public class CustomerServiceTests
    {
        [Fact]
        public void SmokeTest()
        {
            true.Should().BeTrue();
        }
    }
}