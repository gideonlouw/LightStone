using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReversalApp
{
    public class ConsoleInputReader : IInputReader
    {
        public int ReadNumberOfCases()
        {
            Console.Write("Enter number of test cases (N): ");
            return int.Parse(Console.ReadLine());
        }

        public List<string> ReadTestCases(int numberOfCases)
        {
            var testCases = new List<string>();
            for (int i = 1; i <= numberOfCases; i++)
            {
                Console.Write($"Enter test case {i}: ");
                testCases.Add(Console.ReadLine());
            }
            return testCases;
        }
    }
}
