using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace CustomLeetCodeTests
{
	[TestClass]
	public class UniqueMorseCodeWordsTests
	{
		[TestMethod]
		public void NullUniqueMorseCodeWords()
		{
			// arrange
			string[] words = null;
			var solution = new SolutionUniqueMorseCodeWords();

			// act
			// assert
			_ = Assert.ThrowsException<System.NullReferenceException>(() => solution.UniqueMorseRepresentations(words));
		}

		[TestMethod]
		public void EmptyUniqueMorseCodeWords()
		{
			// arrange
			var words = System.Array.Empty<string>();
			var solution = new SolutionUniqueMorseCodeWords();

			// act
			var uniqueMorseRepresentations = solution.UniqueMorseRepresentations(words);

			// assert
			Assert.AreEqual(0, uniqueMorseRepresentations);
		}

		[TestMethod]
		public void NullStringUniqueMorseCodeWords()
		{
			// Arrange
			var word = new string[] { null };
			var words = new string[] { "water", "hat", null };
			var solution = new SolutionUniqueMorseCodeWords();

			// Act
			// Assert
			_ = Assert.ThrowsException<System.NullReferenceException>(() => solution.UniqueMorseRepresentations(word));
			_ = Assert.ThrowsException<System.NullReferenceException>(() => solution.UniqueMorseRepresentations(words));
		}

		[TestMethod]
		public void EmptyStringUniqueMorseCodeWords()
		{
			// Arrange
			var emptyString = new string[] { string.Empty };
			var containsEmptyString = new string[] { "possum", string.Empty };
			var solution = new SolutionUniqueMorseCodeWords();

			// Act
			var uniqueMorseCodeEmptyString = solution.UniqueMorseRepresentations(emptyString);
			var uniqueMorseCodeContainsEmptyString = solution.UniqueMorseRepresentations(containsEmptyString);

			// Assert
			Assert.AreEqual(0, uniqueMorseCodeEmptyString);
			Assert.AreEqual(1, uniqueMorseCodeContainsEmptyString);
		}

		[TestMethod]
		public void WhiteSpaceStringUniqueMorseCodeWords()
		{
			// arrange
			var whiteSpaceString = new string[] { " " };
			var containsWhiteSpaceString = new string[] { "stick", "cup", "  " };
			var solution = new SolutionUniqueMorseCodeWords();

			// act
			var uniqueMorseCodeWhiteSpaceString = solution.UniqueMorseRepresentations(whiteSpaceString);
			var uniqueMorseCodeContainsWhiteSpaceString = solution.UniqueMorseRepresentations(containsWhiteSpaceString);

			// assert
			Assert.AreEqual(0, uniqueMorseCodeWhiteSpaceString);
			Assert.AreEqual(2, uniqueMorseCodeContainsWhiteSpaceString);
		}

		[TestMethod]
		public void TransformationUniqueMorseCodeWords()
		{
			// arrange
			var word = new string[] { "hop" };
			var morse = "....---.--.";
			var solution = new SolutionUniqueMorseCodeWords();

			// act
			var uniqueMorseCodeWord = solution.UniqueMorseRepresentations(word);

			// assert
		}

		[TestMethod]
		public void UniqueMorseCodeWords()
		{
			// arrange
			var wordsOneElement = new string[] { "meow" };
			var wordsEvenElements = new string[] { "old", "cat" };
			var wordsOddElements = new string[] { "gin", "zen", "gig" };
			var solution = new SolutionUniqueMorseCodeWords();

			// act
			var uniqueMorseCodeOneElement = solution.UniqueMorseRepresentations(wordsOneElement);
			var uniqueMorseCodeEvenElements = solution.UniqueMorseRepresentations(wordsEvenElements);
			var uniqueMorseCodeOddElements = solution.UniqueMorseRepresentations(wordsOddElements);

			// assert
			Assert.AreEqual(1, uniqueMorseCodeOneElement);
			Assert.AreEqual(2, uniqueMorseCodeEvenElements);
			Assert.AreEqual(2, uniqueMorseCodeOddElements);
		}

		[TestMethod]
		public void Bound100WordsUniqueMorseCodeWords()
		{
			// arrange

			// act

			// assert
		}

		[TestMethod]
		public void Bound12LettersUniqueMorseCodeWords()
		{
			// arrange
			var word12Letters = new string[] { "hippopotamus" };
			var expectedOutput = ".......--..--.---.--.----.---..-...";
			var solution = new SolutionUniqueMorseCodeWords();

			// act
			var uniqueMorseCode = solution.UniqueMorseRepresentations(word12Letters);

			// assert
			Assert.AreEqual(1, uniqueMorseCode);
		}
	}
}
