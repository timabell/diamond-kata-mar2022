using NUnit.Framework;
using FluentAssertions;

namespace diamond_tests;

public class DiamondTests
{
    [Test]
    public void SingleChar()
    {
        var actual = new DiamondInTheAscii().Bling("A");
        actual.Should().Be("A");
    }
}

public class DiamondInTheAscii
{
    /// <summary>
    /// Makes ascii diamonds out of A-Z letters
    /// eg:
    /// _ _ A _ _
    /// _ B _ B _
    /// C _ _ _ C
    /// _ B _ B _
    /// _ _ A _ _
    /// </summary>
    /// <param name="fattest">The letter of the widest point in the diamond</param>
    /// <returns>A pretty diamond string, newlines and all</returns>
    public string Bling(string fattest)
    {
        return fattest;
    }

}