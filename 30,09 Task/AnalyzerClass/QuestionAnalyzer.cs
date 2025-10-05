using _30_09_Task.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _30_09_Task.AnalyzerClass
{
    public class QuestionAnalyzer : IAnalyzeQuestions
    {
        public int GetQuestionCount(string text)
        {
            var pattern = new Regex(@"[?]+");
            return pattern.Matches(text).Count;
        }
    }
}
