using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReversalApp
{
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void WriteResult(int caseNumber, string result)
        {
            Console.WriteLine($"Case {caseNumber}: {result}");
        }
    }
}
