using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System.Collections.Generic;

namespace CustomLeetCodeTests
{
	[TestClass]
	public class ValidWordSquareTest
	{
		[TestMethod]
		public void TestValidWordSquare()
		{
			// arrange
			var words1 = new List<string>() { "abcd", "bnrt", "crmy", "dtye" };
			var words2 = new List<string>() { "abcd", "bnrt", "crm", "dt" };
			var words3 = new List<string>() { "ball", "area", "read", "lady" };
			var words4 = new List<string>() { "ball", "asee", "let", "lep" };
			var words5 = new List<string>() { "abc", "a" };
			var solution = new SolutionValidWordSquare();

			// act
			var result1 = solution.ValidWordSquare(words1);
			var result2 = solution.ValidWordSquare(words2);
			var result3 = solution.ValidWordSquare(words3);
			var result4 = solution.ValidWordSquare(words4);
			var result5 = solution.ValidWordSquare(words5);

			// assert
			Assert.IsTrue(result1);
			Assert.IsTrue(result2);
			Assert.IsFalse(result3);
			Assert.IsFalse(result4);
			Assert.IsFalse(result5);
		}

	}
}
