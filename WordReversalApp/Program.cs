using System;
using System.Collections.Generic;
using WordReversalApp;

namespace WordReversalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWordReverser wordReverser = new WordReverser();
            IInputReader inputReader = new ConsoleInputReader();
            IOutputWriter outputWriter = new ConsoleOutputWriter();

            var processor = new WordReversalProcessor(wordReverser, inputReader, outputWriter);
            processor.Process();
        }
    }
}

