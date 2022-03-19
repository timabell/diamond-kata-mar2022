using System;
using System.Collections.Generic;
using System.Linq;

namespace diamond_tests;

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
	public string Bling(char fattest)
	{
		// todo: validate input, simple regex
		// todo: uppercase for user convenience

		// just use the char indexes? how readable will that code be?
		// can we make it less procedural and more declarative?

		int first = (int)'A';
		int last = (int)fattest;
		int size = last - first + 1;
		return MakeLine(first, size);
	}

	public string MakeLine(int index, int max)
	{
		if (index < 0){
			throw new ArgumentOutOfRangeException(nameof(index), "index must be >=0");
		}
		if (max <-1){
			throw new ArgumentOutOfRangeException(nameof(max), "max must be >0");
		}
		if (index >= max){
			throw new ArgumentOutOfRangeException("index must be < max");
		}

		// I'm sure I'm missing some simpler maths here,
		// let's get the tests passing then make the code better

		int indentSize = max - index - 1;
		var indent = new string(' ', indentSize);

		const int UPPERCASE_OFFSET = 65;
		var thisChar = (char)(index + UPPERCASE_OFFSET);
		var leftChar = thisChar;

		// only one char needed on first line, all the rest are pairs
		char? rightChar = index == 0 ? null : thisChar;

		var middleGapSize = Math.Max(0, index * 2 - 1);
		var middleGap = new string(' ', middleGapSize);

		return $"{indent}{leftChar}{middleGap}{rightChar}\n";
	}
}
