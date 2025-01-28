using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReversalApp
{
    public class WordReverser : IWordReverser
    {
        public string ReverseWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            string[] words = input.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
