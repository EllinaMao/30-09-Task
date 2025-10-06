using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _30_09_Task
{
    public class TextReport
    {
        [JsonPropertyName("Количество предложений")]
        public int? SentenceCount { get; set; } = null;
        [JsonPropertyName("Количество символов")]
        public int? SymbolsCount { get; set; } = null;
        [JsonPropertyName("Количество слов")]
        public int? WordCount { get; set; } = null;
        [JsonPropertyName("Количество вопросительных предложений")]
        public int? QuestionSentenceCount { get; set; } = null;
        [JsonPropertyName("Количество восклицательных предложений")]
        public int? ExclamationSentenceCount { get; set; } = null;



    }
}
