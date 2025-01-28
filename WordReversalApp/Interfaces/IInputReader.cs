using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReversalApp
{
    public interface IInputReader
    {
        int ReadNumberOfCases();
        List<string> ReadTestCases(int numberOfCases);
    }
}
