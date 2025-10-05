using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _30_09_Task
{
    public class SentenceAnalyzer : IAnalyzeSentences
    {
        public int GetSentenceCount(string text)
        {
            var pattern = new Regex (@"(?<=[\p{L}\)]) [.!?]+");
            return pattern.Matches(text).Count;
        }
    }
}
