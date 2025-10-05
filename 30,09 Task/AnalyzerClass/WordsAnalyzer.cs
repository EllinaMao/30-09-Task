using _30_09_Task.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _30_09_Task.AnalyzerClass
{
    public class WordsAnalyzer : IAnalyzeWords
    {
        public int GetWordCount(string text)
        {
            var pattern = new Regex(@"\b[\p{L}]+(?:['-][\p{L}]+)*\b");
            return pattern.Matches(text).Count;
        }
    }
}
