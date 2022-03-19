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
		return ((char)(index+65)).ToString() + "\n";
	}
}
