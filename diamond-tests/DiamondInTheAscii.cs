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

		var charlist = Range('A', fattest).ToArray();
		var size = charlist.Length;
		return size.ToString();
	}

	/// <summary>
	/// Some slightly-too-clever code for generating a list of chars.
	///  Not so sure this is a good idea, just experimenting with approaches.
	/// </summary>
	/// <param name="start"></param>
	/// <param name="end"></param>
	/// <returns></returns>
	private static IEnumerable<char> Range(char start, char end)
	{
		// from https://stackoverflow.com/questions/5693854/a-to-z-list-of-char-from-enumerable-range/43563612#43563612
		return Enumerable.Range((int)start, (int)end - (int)start + 1).Select(i => (char)i);
	}
}
