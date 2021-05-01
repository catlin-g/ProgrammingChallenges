using System;
using System.Linq;

/// <summary>
/// Largest Palindrome Product
/// Problem 4
///
/// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
///
/// Find the largest palindrome made from the product of two 3-digit numbers.
/// </summary>

namespace Problem4
{
	class Problem4
	{
		public static int LargestPalindromeFromProduct(int digits)
		{
			var largestPalindrome = int.MinValue;

			var minOperand = (int)Math.Pow(10, digits - 1);
			var maxOperand = (int)Math.Pow(10, digits) - 1;

			for (var i = maxOperand; i >= minOperand; i--)
			{
				for (var j = maxOperand; j >= (maxOperand - i); j--)
				{
					var product = i * j;
					if (IsPalindrome(product) && largestPalindrome < product)
					{
						largestPalindrome = product;
					}
				}
			}

			return largestPalindrome;
		}

		private static bool IsPalindrome(int inputNumber)
		{
			var possPalindrome = inputNumber.ToString();
			return possPalindrome.SequenceEqual(possPalindrome.Reverse());
		}
	}
}