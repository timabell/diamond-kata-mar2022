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

	[TestCase(0,1,"A\n")]
	//
	[TestCase(0,2," A\n")]
	[TestCase(1,2,"B B\n")]
	//
	[TestCase(0,3,"  A\n")]
	[TestCase(1,3," B B\n")]
	[TestCase(2,3,"C   C\n")]
	public void TestmakeLine(int index, int max, string expected)
	{
		new DiamondInTheAscii().MakeLine(index,max).Should().Be(expected);
	}
}
