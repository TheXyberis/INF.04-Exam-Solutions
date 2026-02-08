using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_06_Lotto_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many sets to generate?");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                return;
            }
            int[,] lotteryResults = new int[n, 6];

            FillLotterSets(lotteryResults);
            DisplayLotteryResults(lotteryResults);
            DisplayStatistics(lotteryResults);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static void FillLotterSets(int[,] results)
        {
            Random random = new Random();
            int rowCount = results.GetLength(0);

            for (int i = 0; i < rowCount; i++)
            {
                HashSet<int> uniqueNumbers = new HashSet<int>(); //HashSet ensures numbers in a single set do not repeat

                while (uniqueNumbers.Count < 6)
                {
                    uniqueNumbers.Add(random.Next(1, 50));
                }

                int col = 0;
                foreach (int num in uniqueNumbers)
                {
                    results[i, col] = num;
                    col++;
                }
            }
        }
        static void DisplayLotteryResults(int[,] results)
        {
            int rows = results.GetLength(0);
            Console.WriteLine("\nSets of drawn numbers:");

            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Draw {(i + 1).ToString().PadLeft(2)}:");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(results[i, j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }
        }
        static void DisplayStatistics(int[,] results)
        {
            int[] occurrences = new int[50];
            int rows = results.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    int number = results[i, j];
                    occurrences[number]++;
                }
            }

            Console.WriteLine("\nOccurrences statistics (Number: Count)");
            for (int i = 1; i <= 49; i++)
            {
                if (occurrences[i] > 0)
                {
                    Console.WriteLine($"Number {(i).ToString().PadLeft(2)} count: {occurrences[i]}");
                }
            }
            Console.WriteLine();
        }
    }
}
