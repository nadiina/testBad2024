using System;
using System.Diagnostics;
using System.IO;
using test.function;

class Program
{
    static void Main()
    {
        try
        {
            System.Diagnostics.Stopwatch sw = new Stopwatch();
            sw.Start();

            string path = "10m.txt";
            if (!File.Exists(path))
            {
                throw new Exception("Failed to read text file");
            }

            string[] lines = File.ReadAllLines(path);
            int[] numbers = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                numbers[i] = int.Parse(lines[i]);
            }

            int[] sortedNumbers = QuickSort.Sort(numbers);
            Console.WriteLine("Numbers.Length: " + sortedNumbers.Length);
            Console.WriteLine("Min item: " + sortedNumbers.First());
            Console.WriteLine("Max item: " + sortedNumbers.Last());
            Console.WriteLine("Median: " + Statistics.Median(sortedNumbers));
            Console.WriteLine("Average function: " + Statistics.AverageFunction(sortedNumbers));
            Console.WriteLine("Average LINQ: " + sortedNumbers.Average());

            //var test = new int[] { 1, 2, 3, 4, 5, 6 };
            var sequences = Sequences.FindLongestIncreasingAndDecreasingSequences(numbers);
            Console.WriteLine();

            Console.WriteLine("The largest sequence, strictly increasing: ");
            foreach (var number in sequences.Item1)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("sequences.Item1.Length: " + sequences.Item1.Length);
            Console.WriteLine();

            Console.WriteLine("The longest sequence, strictly descending: ");
            foreach (var number in sequences.Item2)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("sequences.Item2.Length: " + sequences.Item2.Length);
            Console.WriteLine();

            sw.Stop();
            Console.WriteLine("The total time: " + sw.Elapsed);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
