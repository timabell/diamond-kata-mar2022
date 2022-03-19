using NUnit.Framework;
using FluentAssertions;

namespace diamond_tests;

public class DiamondTests
{
    [Test]
    public void SingleChar()
    {
        var actual = new DiamondInTheAscii().Bling();
        actual.Should().Be("A");
    }
}

public class DiamondInTheAscii
{
    public string Bling()
    {
        return "A";
    }

}