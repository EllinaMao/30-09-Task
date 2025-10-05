using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _30_09_Task
{
    public static class BuilderFileManager
    {
        public static void SaveInFileJson(TextReport report)
        {
            if (report == null)
            {
                return;
            }
            string fileName = $"TextReport_{DateTime.Now:yyyyMMdd_HHmmss}.json";

            try
            {
                // Сериализация объекта в JSON
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };

                string json = JsonSerializer.Serialize(report, options);

                // Сохраняем в файл в той же папке, где запускается приложение
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
