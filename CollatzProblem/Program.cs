using System;

namespace CollatzProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            long maxNumber = 1000000; // Maximum number to consider
            long longestChainNumber = 0; // Number with the longest chain
            int longestChainLength = 0; // Length of the longest chain

            for (long i = 2; i < maxNumber; i++)
            {
                long n = i;
                int chainLength = 1;

                // Generate the Collatz sequence
                while (n != 1)
                {
                    if (n % 2 == 0)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        n = 3 * n + 1;
                    }
                    chainLength++;
                }

                // Update longest chain if necessary
                if (chainLength > longestChainLength)
                {
                    longestChainLength = chainLength;
                    longestChainNumber = i;
                }
            }

            Console.WriteLine($"The starting number under {maxNumber} that produces the longest chain is: {longestChainNumber}");
            Console.WriteLine($"The length of the longest chain is: {longestChainLength}");
        }
    }
}
