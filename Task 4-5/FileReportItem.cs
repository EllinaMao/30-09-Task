using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Name { get; set; }
        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }
        public string Type
        {
            get
            {
                return Path.GetExtension(Name)?.TrimStart('.').ToLower() ?? "";
            }

        }
        public FileStatus Status { get; set; }
    
    }
}
