using _30_09_Task.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _30_09_Task.AnalyzerClass
{
    public class SentenceAnalyzer : IAnalyzeSentences
    {
        public int GetSentenceCount(string text)
        {
            var pattern = new Regex(@"[.!?]+(?=\s|$)");
            return pattern.Matches(text).Count;
        }
    }
}
