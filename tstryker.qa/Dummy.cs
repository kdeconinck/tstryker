using Xunit;

namespace tstryker.qa;

public sealed class Dummy
{
    [Fact]
    public void IsTrue()
    {
        Assert.True(true);
    }
}