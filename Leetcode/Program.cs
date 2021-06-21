using System;

namespace LeetCode
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var prefixOfWord = new SolutionIsPrefixOfWord();
			Console.WriteLine(prefixOfWord.IsPrefixOfWord("hello form the other side", "they"));
		}
	}
}