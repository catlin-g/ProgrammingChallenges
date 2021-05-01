using System;

/// <summary>
/// Create a function Brackets() that takes a string and checks that the brackets in the math expression are correct.
/// The function should return true or false.
///
/// Examples
/// Brackets("(a*(b-c)..... )") ➞ true
/// Brackets(")(a-b-45/7*(a-34))") ➞ false
/// Brackets("sin(90...)+.............cos1)") ➞ false
///
/// Notes
/// The string may not contain brackets, then return true.
/// String may contain spaces.
/// The string may be empty.
///
/// </summary>

namespace ClearBrackets
{
	class ClearBrackets
	{
		public static bool Brackets(string str)
		{
			var balanced = 0;

			foreach (var c in str)
			{
				_ = c.Equals('(') ? balanced++ : balanced;
				_ = c.Equals(')') ? balanced-- : balanced;

				if (balanced < 0)
				{
					return false;
				}
			}

			return balanced == 0;
		}
	}
}