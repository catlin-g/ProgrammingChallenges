using System;

namespace ClearBrackets
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Console.WriteLine(ClearBrackets.Brackets("(a*(b-c)     )"));
			Console.WriteLine(ClearBrackets.Brackets(" ) (a-b-45/7*(a-34))"));
			Console.WriteLine(ClearBrackets.Brackets("sin(90       )+      cos1)"));
			Console.WriteLine(ClearBrackets.Brackets(" (...). .%_.(.... )"));
			Console.WriteLine(ClearBrackets.Brackets(" (...)...(..(...).... )  "));
			Console.WriteLine(ClearBrackets.Brackets(") .. .() (        ).. . ("));
			Console.WriteLine(ClearBrackets.Brackets(")))((("));
			Console.WriteLine(ClearBrackets.Brackets("  (...).!.)...("));
			Console.WriteLine(ClearBrackets.Brackets("a+b"));
			Console.WriteLine(ClearBrackets.Brackets(""));
			Console.WriteLine(ClearBrackets.Brackets("(a+f).`!£=.)...) "));
		}
	}
}
