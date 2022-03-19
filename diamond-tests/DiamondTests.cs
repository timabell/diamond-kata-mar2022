using NUnit.Framework;
using FluentAssertions;

namespace diamond_tests;

public class DiamondTests
{
    [Test]
    public void SingleChar()
    {
        var actual = new DiamondInTheAscii().Bling('A');
        actual.Should().Be("A");
    }

    [Test]
    public void DiamondAB()
    {
        var actual = new DiamondInTheAscii().Bling('B');
        actual.Should().Be(
            " A\n" +
            "B B\n" +
            " A\n");
    }
}
