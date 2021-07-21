using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomLeetCodeTests
{
	[TestClass]
	public class HighFiveTests
	{
		[TestMethod]
		public void TestHighFiveScoresLength()
		{
			// arrange
			var items = new int[][] { new int[] {3, 67 }, new int[] { 1, 99 }, new int[] { 1, 90}, new int[] { 2, 86 },
						new int[] {2, 72 }, new int[] { 1, 64 }, new int[] { 2, 58 }, new int[] { 1, 92 }, new int[] { 3, 88 },
						new int[] { 1, 88 }, new int[] { 1, 69 }, new int[] { 2, 66 }, new int[] { 2, 85 }, new int[] { 3, 56 },
						new int[] { 3, 40 }, new int[] { 3, 58 } };
			var solution = new SolutionHighFive();

			// act
			var highfive = solution.HighFive(items);

			// assert
			Assert.AreEqual(3, highfive.Length);
		}

		[TestMethod]
		public void TestHighFiveScoresValues()
		{
			// arrange
			//var items = new int[][] { new int[] { 1, 91 }, new int[] { 1, 92}, new int[] { 2, 93 },
						//new int[] {2, 97 }, new int[] { 1, 60 }, new int[] { 2, 77 }, new int[] { 1, 65 },
						//new int[] { 1, 87 }, new int[] { 1, 100 }, new int[] { 2, 100 }, new int[] { 2, 76 } };
			var items2 = new int[][] { new int[] { 1, 100 }, new int[] { 7, 100 }, new int[] { 1, 100 },
						new int[] { 7, 100 }, new int[] { 1, 100 }, new int[] { 7, 100 }, new int[] { 1, 100 },
						new int[] { 7, 100 }, new int[] { 1, 100 }, new int[] { 7, 100 } };
			var solution = new SolutionHighFive();
			//var expectedOutput = new int[][] { new int[] { 1, 87 }, new int[] { 2, 88 } };
			var expectedOutput2 = new int[][] { new int[] { 1, 100 }, new int[] { 7, 100 } };

			// act
			//var highfive = solution.HighFive(items);
			var highfive2 = solution.HighFive(items2);

			// assert

			//CollectionAssert.AreEqual(expectedOutput, highfive);
			CollectionAssert.AreEqual(expectedOutput2, highfive2);
		}

		[TestMethod]
		public void TestHighFiveScoresError()
		{
			// arrange
			var items = new int[][] { new int[] { 1, 89 }, new int[] { 1, 58 }, new int[] { 1, 77 }, new int[] { 1, 8 },
						new int[] { 1, 98 }, new int[] { 1, 0 }, new int[] { 1, 54 }, new int[] { 1, 44 }, new int[] { 1, 31 },
						new int[] { 1, 34 }, new int[] { 1, 43 }, new int[] { 1, 59 }, new int[] { 1, 0 }, new int[] { 1, 7 },
						new int[] { 1, 39 }, new int[] { 1, 51 }, new int[] { 1, 50 }, new int[] { 1, 87 }, new int[] { 1, 93 },
						new int[] { 1, 88 } };
			var solution = new SolutionHighFive();
			var expectedOutput = new int[][] { new int[] { 1, 91 } };

			// act
			var highfive = solution.HighFive(items);

			// assert

			CollectionAssert.AreEqual(expectedOutput, highfive);
		}
	}
}