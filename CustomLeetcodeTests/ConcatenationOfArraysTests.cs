using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CustomLeetCodeTests
{
	[TestClass]
	public class ConcatenationOfArraysTests
	{
		[TestMethod]
		public void NullConcatenationOfArray()
		{
			// arrange
			int[] inputArray = null;
			var solution = new SolutionConcatenationOfArray();

			// act
			// assert
			_ = Assert.ThrowsException<System.NullReferenceException>(() => solution.GetConcatenation(inputArray));
		}

		[TestMethod]
		public void EmptyConcatenationOfArray()
		{
			// arrange
			var inputArray = System.Array.Empty<int>();
			var solution = new SolutionConcatenationOfArray();

			// act
			var outputArray = solution.GetConcatenation(inputArray);

			// assert
			Assert.AreEqual(0, outputArray.Length);
		}

		[TestMethod]
		public void ArrayLengthConcatenationOfArray()
		{
			// arrange
			var inputArray = new int[] { 5, 101, 94 };
			var solution = new SolutionConcatenationOfArray();

			// act
			var outputArray = solution.GetConcatenation(inputArray);

			// assert
			Assert.AreEqual(inputArray.Length * 2, outputArray.Length);
		}

		[TestMethod]
		public void ArrayLengthEvenConcatenationOfArray()
		{
			// arrange
			var inputArray = new int[] { 333, 4, 67 };
			var solution = new SolutionConcatenationOfArray();

			// act
			var outputArray = solution.GetConcatenation(inputArray);

			// assert
			Assert.AreEqual(0, outputArray.Length % 2);
		}

		[TestMethod]
		public void ValidOutputConcatenationOfArray()
		{
			// arrange
			var inputArray = new int[] { 59, 403, 88, 3, 9 };
			var solution = new SolutionConcatenationOfArray();

			// act
			var outputArray = solution.GetConcatenation(inputArray);
			var firstHalf = outputArray.Take(inputArray.Length).ToArray();
			var secondHalf = outputArray.TakeLast(inputArray.Length).ToArray();

			// assert
			CollectionAssert.AreEqual(firstHalf, secondHalf);
			CollectionAssert.AreEqual(inputArray, firstHalf);
			CollectionAssert.AreEqual(inputArray, secondHalf);
		}
	}
}