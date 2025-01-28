using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReversalApp
{
    public class WordReversalProcessor
    {
        private readonly IWordReverser _wordReverser;
        private readonly IInputReader _inputReader;
        private readonly IOutputWriter _outputWriter;

        public WordReversalProcessor(IWordReverser wordReverser, IInputReader inputReader, IOutputWriter outputWriter)
        {
            _wordReverser = wordReverser;
            _inputReader = inputReader;
            _outputWriter = outputWriter;
        }

        public void Process()
        {
            int numberOfCases = _inputReader.ReadNumberOfCases();
            var testCases = _inputReader.ReadTestCases(numberOfCases);

            for (int i = 0; i < testCases.Count; i++)
            {
                string reversedWords = _wordReverser.ReverseWords(testCases[i]);
                _outputWriter.WriteResult(i + 1, reversedWords);
            }
        }
    }
}
