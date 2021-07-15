using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace CustomLeetCodeTests
{
	[TestClass]
	class UniqueMorseCodeWordsTests
	{
		[TestMethod]
		public void EmptyInputShouldReturnZeroUniqueMorseRepresentations()
		{
			// Arrange
			var words = System.Array.Empty<string>();
			var solution = new SolutionUniqueMorseCodeWords();

			// Act
			var uniqueMorseRepresentations = solution.UniqueMorseRepresentations(words);

			// Assert
			Assert.IsTrue(uniqueMorseRepresentations == 0);
		}

		[TestMethod]
		public void NullArrayShouldThrowNullReferenceException()
		{
			// Arrange
			string[] words = null;
			var solution = new SolutionUniqueMorseCodeWords();

			// Act
			// Assert
			_ = Assert.ThrowsException<System.NullReferenceException>(() => solution.UniqueMorseRepresentations(words));
		}

		[TestMethod]
		public void InputArrayLengthGreaterThanOneShouldReturnAtLeastOneUniqueMorseCodeRepresentation()
		{
			// Arrange
			var wordsOneElement = new string[] { "meow" };
			var wordsEvenElements = new string[] { "old", "cat" };
			var wordsOddElements = new string[] { "gin", "zen", "gig" };
			var wordsManyElements = new string[] { "dog", "owl", "messy", "tofu", "pin", "fake", "lolly"};
			var solution = new SolutionUniqueMorseCodeWords();

			// Act
			var uniqueMorseCodeOneElement = solution.UniqueMorseRepresentations(wordsOneElement);
			var uniqueMorseCodeEvenElements = solution.UniqueMorseRepresentations(wordsEvenElements);
			var uniqueMorseCodeOddElements = solution.UniqueMorseRepresentations(wordsOddElements);
			var uniqueMorseCodeManyElements = solution.UniqueMorseRepresentations(wordsManyElements);

			// Assert
			Assert.IsTrue(uniqueMorseCodeOneElement == 1);
			Assert.IsTrue(uniqueMorseCodeEvenElements >= 1);
			Assert.IsTrue(uniqueMorseCodeOddElements >= 1);
			Assert.IsTrue(uniqueMorseCodeManyElements >= 1);
		}

		[TestMethod]
		public void EmptyStringsShouldNotReturnMorseCodeRepresentations()
		{
			// Arrange
			var emptyString = new string[] { "" };
			var containsEmptyString = new string[] { "possum", "" };
			var solution = new SolutionUniqueMorseCodeWords();

			// Act
			var uniqueMorseCodeEmptyString = solution.UniqueMorseRepresentations(emptyString);
			var uniqueMorseCodeContainsEmptyString = solution.UniqueMorseRepresentations(containsEmptyString);

			// Assert
			Assert.IsTrue(uniqueMorseCodeEmptyString == 0);
			Assert.IsTrue(uniqueMorseCodeContainsEmptyString == 1);
		}

		[TestMethod]
		public void WhiteSpaceStringsShouldNotReturnMorseCodeRepresentations()
		{
			// Arrange
			var whiteSpaceString = new string[] { " " };
			var containsWhiteSpaceString = new string[] { "stick", "cup", "  " };
			var solution = new SolutionUniqueMorseCodeWords();

			// Act
			var uniqueMorseCodeWhiteSpaceString = solution.UniqueMorseRepresentations(whiteSpaceString);
			var uniqueMorseCodeContainsWhiteSpaceString = solution.UniqueMorseRepresentations(containsWhiteSpaceString);

			// Assert
			Assert.IsTrue(uniqueMorseCodeWhiteSpaceString == 0);
			Assert.IsTrue(uniqueMorseCodeContainsWhiteSpaceString >= 1);
		}

		[TestMethod]
		public void NullStringsShouldReturnNullReferenceException()
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
		public void Examples()
		{
			// Arrange
			var word = new string[] { "hop" };
			var morse = "....---.--.";
			var solution = new SolutionUniqueMorseCodeWords();

			// Act
			var uniqueMorseCodeWord = solution.UniqueMorseRepresentations(word);

			// Assert
			_ = Assert.Equals(uniqueMorseCodeWord, morse);
		}
	}
}
