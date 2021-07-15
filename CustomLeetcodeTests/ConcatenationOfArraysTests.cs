using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CustomLeetCodeTests
{
	[TestClass]
	public class ConcatenationOfArraysTests
	{
		[TestMethod]
		public void ConcatenatedArrayLengthShouldBeDoubleInputArrayLength()
		{
			// Arrange
			var inputArray = new int[] { 5, 101, 94 };
			var solution = new SolutionConcatenationOfArray();

			// Act
			var outputArray = solution.GetConcatenation(inputArray);

			// Assert
			Assert.IsTrue(inputArray.Length * 2 == outputArray.Length);
		}

		[TestMethod]
		public void ConcatenatedEmptyArrayShouldBeLengthZero()
		{
			// Arrange
			var inputArray = System.Array.Empty<int>();
			var solution = new SolutionConcatenationOfArray();

			// Act
			var outputArray = solution.GetConcatenation(inputArray);

			// Assert
			Assert.IsTrue(outputArray.Length == 0);
		}

		[TestMethod]
		public void ConcatenatingNULLArrayShouldThrowNullReferenceException()
		{
			// Arrange
			int[] inputArray = null;
			var solution = new SolutionConcatenationOfArray();

			// Act
			// Assert
			_ = Assert.ThrowsException<System.NullReferenceException>(() => solution.GetConcatenation(inputArray));
		}

		[TestMethod]
		public void ConcatenatedArrayLengthShouldAlwaysBeEven()
		{
			// Arrange
			var inputArray = new int[] { 333, 4, 67 };
			var solution = new SolutionConcatenationOfArray();

			// Act
			var outputArray = solution.GetConcatenation(inputArray);

			// Assert
			Assert.IsTrue(outputArray.Length % 2 == 0);
		}


		[TestMethod]
		public void ConcatedArrayValuesInFirstHalfShouldEqualValuesInSecondHalf()
		{
			// Arrange
			var inputArray = new int[] { 59, 403, 88, 3, 9 };
			var solution = new SolutionConcatenationOfArray();

			// Act
			var outputArray = solution.GetConcatenation(inputArray);
			var firstHalf = outputArray.TakeLast(inputArray.Length).ToArray();
			var secondHalf = outputArray.Take(inputArray.Length).ToArray();

			// Assert
			CollectionAssert.AreEqual(firstHalf, secondHalf);
		}

		[TestMethod]
		public void InputArrayValuesShouldExistInOrderTwiceInConcatenatedArray()
		{
			// Arrange
			var inputArray = new int[] { 7, 28, 406, 1000 };
			var solution = new SolutionConcatenationOfArray();

			// Act
			var outputArray = solution.GetConcatenation(inputArray);
			var firstHalf = outputArray.TakeLast(inputArray.Length).ToArray();
			var secondHalf = outputArray.Take(inputArray.Length).ToArray();

			// Assert
			CollectionAssert.AreEqual(inputArray, firstHalf);
			CollectionAssert.AreEqual(inputArray, secondHalf);
		}
	}
}