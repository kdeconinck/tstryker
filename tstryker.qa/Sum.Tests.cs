using Xunit;

namespace tstryker.qa;

public sealed class SumTests
{
    [Fact]
    public void TestInvoke()
    {
        var x = Sum.Invoke(10, 20);

        Assert.Equal(30, x);
    }
}