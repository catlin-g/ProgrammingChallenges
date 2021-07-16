using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace CustomLeetCodeTests
{
	[TestClass]
	public class ShortestWordDistanceTest
	{
		[TestMethod]
		public void TestShortestWordDistanceMinWordLength()
		{
			// arrange
			var wordsDict = new string[] { "butterfly", "a", "zenith", "bee", "memory", "a", "alpha", "zebra" };
			var word1 = "a";
			var word2 = "alpha";
			var solution = new SolutionShortestWordDistance();

			// act
			var distance = solution.ShortestDistance(wordsDict, word1, word2);

			// assert
			Assert.AreEqual(1, distance);
		}

		[TestMethod]
		public void TestShortestWordDistanceMaxWordLength()
		{
			// arrange
			var wordsDict = new string[] { "puzzlingly", "computer", "bee", "talk", "puzzle", "bee" };
			var word1 = "bee";
			var word2 = "puzzlingly";
			var solution = new SolutionShortestWordDistance();

			// act
			var distance = solution.ShortestDistance(wordsDict, word1, word2);

			// assert
			Assert.AreEqual(2, distance);
		}

		[TestMethod]
		public void TestShortestWordDistanceMinimumDictLength()
		{
			// arrange
			var wordsDict = new string[] { "cat", "kitten" };
			var word1 = "kitten";
			var word2 = "cat";
			var solution = new SolutionShortestWordDistance();

			// act
			var distance = solution.ShortestDistance(wordsDict, word1, word2);

			// assert
			Assert.AreEqual(1, distance);
		}

		[TestMethod]
		public void TestShortestWordDistanceGeneralCase()
		{
			// arrange
			var wordsDict = new string[] { "practice", "makes", "perfect", "coding", "makes" };
			var word1 = "coding";
			var word2 = "practice";
			var word3 = "makes";
			var word4 = "coding";
			var solution = new SolutionShortestWordDistance();

			// act
			var distance1 = solution.ShortestDistance(wordsDict, word1, word2);
			var distance2 = solution.ShortestDistance(wordsDict, word3, word4);

			// assert
			Assert.AreEqual(3, distance1);
			Assert.AreEqual(1, distance2);
		}

		[TestMethod]
		public void TestShortestWordDistanceLastWord()
		{
			// arrange
			var wordsDict = new string[] { "five", "carpet", "rain", "rain", "five" };
			var word1 = "five";
			var word2 = "rain";
			var solution = new SolutionShortestWordDistance();

			// act
			var distance = solution.ShortestDistance(wordsDict, word1, word2);

			// assert
			Assert.AreEqual(1, distance);
		}
	}
}
