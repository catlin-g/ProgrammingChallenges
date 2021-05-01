namespace Problem3
{
	/// <summary>
	/// Largest Prime Factor
	/// Problem 3
	///
	/// The prime factors of 13195 are 5, 7, 13 and 29.
	///
	/// What is the largest prime factor of the number 600851475143 ?
	///
	/// </summary>
	class Problem3
	{
		public static long FindLargestPrimeFactor(long inputNumber)
		{
			long candidatePrime = 0;
			var isPrime = false;

			for (var iter = 1; iter < inputNumber; iter++)
			{
				if (inputNumber % iter == 0)
				{
					candidatePrime = inputNumber / iter;
					isPrime = CheckIfPrime(candidatePrime);
				}

				if (isPrime)
				{
					return candidatePrime;
				}
			}

			return default;
		}

		public static bool CheckIfPrime(long candidateNumber)
		{
			if (candidateNumber == 2)
			{
				return true;
			}

			if (candidateNumber <= 1 || candidateNumber % 2 == 0)
			{
				return false;
			}

			for (var iter = 3; iter <= candidateNumber / 2; iter += 2)
			{
				if (candidateNumber % iter == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}