using _30_09_Task.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_09_Task
{
    public class BuilderTextAnalyzer
    {
        private readonly string _text;
        private readonly TextReport _report = new();

        private readonly IAnalyzeSentences? _sentenceAnalyzer;
        private readonly IAnalyzeSymbols? _symbolsAnalyzer;
        private readonly IAnalyzeWords? _wordAnalyzer;
        private readonly IAnalyzeQuestions? _questionAnalyzer;
        private readonly IAnalyzeExclamations? _exclamationAnalyzer;


        public BuilderTextAnalyzer(string text,
            IAnalyzeSentences? sentenceAnalyzer = null,
            IAnalyzeSymbols? charAnalyzer = null,
            IAnalyzeWords? wordAnalyzer = null,
            IAnalyzeQuestions? questionAnalyzer = null,
            IAnalyzeExclamations? exclamationAnalyzer = null)
        {
            _text = text;
            _sentenceAnalyzer = sentenceAnalyzer;
            _symbolsAnalyzer = charAnalyzer;
            _wordAnalyzer = wordAnalyzer;
            _questionAnalyzer = questionAnalyzer;
            _exclamationAnalyzer = exclamationAnalyzer;
        }

        public TextReport Build()
        {
            if (_sentenceAnalyzer != null)
                _report.SentenceCount = _sentenceAnalyzer.GetSentenceCount(_text);

            if (_symbolsAnalyzer != null)
                _report.SymbolsCount = _symbolsAnalyzer.GetSymbolsCount(_text);

            if (_wordAnalyzer != null)
                _report.WordCount = _wordAnalyzer.GetWordCount(_text);

            if (_questionAnalyzer != null)
                _report.QuestionSentenceCount = _questionAnalyzer.GetQuestionCount(_text);

            if (_exclamationAnalyzer != null)
                _report.ExclamationSentenceCount = _exclamationAnalyzer.GetExclamationCount(_text);

            return _report;
        }



    }
}
