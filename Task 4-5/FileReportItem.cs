using System.Text.Json.Serialization;

namespace Task_4_5
{
    public enum FileStatus
    {
        Перенесено,
        Провалено,
        Дубликат
    }
    public class FileReportItem
    {
        [JsonPropertyName("Имя")]
        public string Name { get; set; } = string.Empty;
        [JsonPropertyName("Источник")]
        public string SourcePath { get; set; } = string.Empty;
        [JsonPropertyName("Конечная папка")]
        public string DestinationPath { get; set; } = string.Empty;
        [JsonPropertyName("Тип")]
        public string Type
        {
            get
            {
                return Path.GetExtension(Name)?.TrimStart('.').ToLower() ?? "";
            }

        }
        [JsonPropertyName("Статус")]
        public FileStatus Status { get; set; }

    }
}
