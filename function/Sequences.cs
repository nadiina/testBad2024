using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.function
{
    public class Sequences
    {
        public static (int[], int[]) FindLongestIncreasingAndDecreasingSequences(int[] numbers)
        {
            int currentIncreasingSequence = 1;
            int maxIncreasingSequence = 1;
            int endIndexIncreasing = 0;

            int currentDecreasingSequence = 1;
            int maxDecreasingSequence = 1;
            int endIndexDecreasing = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    currentIncreasingSequence++;
                }
                else
                {
                    if (currentIncreasingSequence > maxIncreasingSequence)
                    {
                        maxIncreasingSequence = currentIncreasingSequence;
                        endIndexIncreasing = i - 1;
                    }
                    currentIncreasingSequence = 1;
                }

                if (numbers[i] < numbers[i - 1])
                {
                    currentDecreasingSequence++;
                }
                else
                {
                    if (currentDecreasingSequence > maxDecreasingSequence)
                    {
                        maxDecreasingSequence = currentDecreasingSequence;
                        endIndexDecreasing = i - 1;
                    }
                    currentDecreasingSequence = 1;
                }
            }

            // Check the last sequences
            if (currentIncreasingSequence > maxIncreasingSequence)
            {
                maxIncreasingSequence = currentIncreasingSequence;
                endIndexIncreasing = numbers.Length - 1;
            }
            if (currentDecreasingSequence > maxDecreasingSequence)
            {
                maxDecreasingSequence = currentDecreasingSequence;
                endIndexDecreasing = numbers.Length - 1;
            }

            // Create and return the longest increasing and decreasing sequences
            int[] longestIncreasingSequence = new int[maxIncreasingSequence];
            for (int i = endIndexIncreasing - maxIncreasingSequence + 1, j = 0; i <= endIndexIncreasing; i++, j++)
            {
                longestIncreasingSequence[j] = numbers[i];
            }

            int[] longestDecreasingSequence = new int[maxDecreasingSequence];
            for (int i = endIndexDecreasing - maxDecreasingSequence + 1, j = 0; i <= endIndexDecreasing; i++, j++)
            {
                longestDecreasingSequence[j] = numbers[i];
            }

            return (longestIncreasingSequence, longestDecreasingSequence);
        }
    }
}
