using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task_4_5
{
    public static class FileSaveManager
    {
        public static void SaveInJson(List<FileReportItem> report)
        {
            string fileName = $"TextReport_{DateTime.Now:yyyyMMdd_HHmmss}.json";
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                string json = JsonSerializer.Serialize(report, options);
                File.WriteAllText(fileName, json);
                MessageBox.Show($"Отчет сохранен в файл {fileName}", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
