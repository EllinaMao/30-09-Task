using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _30_09_Task
{
    public class QuestionAnalyzer : IAnalyzeQuestions
    {
        public int GetQuestionCount(string text)
        {
            var pattern = new Regex(@"[/p{L}?]+");
            return pattern.Matches(text).Count;
        }
    }
}
