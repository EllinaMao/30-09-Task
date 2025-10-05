using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _30_09_Task
{
    public class SymbolsAnalyzer : IAnalyzeSymbols
    {
        public int GetSymbolsCount(string text)
        {
            var pattern = new Regex (@"\S");//любой не пробельный символ
            return pattern.Matches(text).Count;
        }
    }
}
