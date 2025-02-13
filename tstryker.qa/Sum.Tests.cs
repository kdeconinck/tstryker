using Xunit;

namespace tstryker.qa;

public sealed class SumTests
{
    [Fact]
    public void TestInvoke()
    {
        var x = Sum.Invoke(1, 2);

        Assert.Equal(10, x);
    }

    [Fact]
    public void TestInvoke2()
    {
        var x = Sum.Invoke(1, 2);

        Assert.Equal(3, x);
    }

    [Fact]
    public void TestInvoke3()
    {
        var x = Sum.Invoke(1, 2);

        Assert.Equal(3, x);
    }
}