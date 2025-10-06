using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_5
{
    public static class FileTransfer
    {
        private static List<FileReportItem> _lastReport = new List<FileReportItem>;
        public static void TransferFiles(string source , string destination)
        {
            var reportItems = new List<FileReportItem>();
            var files = Directory.GetFiles(source);
            var hashCodes = new HashSet<string>();

            int total = files.Length;
            int count = 0;

            foreach (var file in files)
            {
                string hash = GetFileHash(file);
                var item = new FileReportItem()
                {
                    Name = Path.GetFileName(file) ,
                    SourcePath = file ,
                    DestinationPath = Path.Combine(destination , Path.GetFileName(file))

                };

                if (!hashCodes.Contains(hash))
                {
                    hashCodes.Add(hash);
                    File.Copy(file , item.DestinationPath , true);
                    item.Status = FileStatus.Перенесено;
                }
                if (hashCodes.Contains(hash))
                {
                    item.Status = FileStatus.Дубликат;
                }
                else
                {
                    item.Status = FileStatus.Провалено;
                }


            }
        }
        public static List<FileReportItem> GetReport()
        {
            lock (_lastReport)
            {
            return new List<FileReportItem>(_lastReport);
            }
        }

        private static string GetFileHash(string path)
        {
            using var md5 = MD5.Create();//md5 быстрее чем то что я использовала в экзаменационной, там он специально был медленный
            using var stream = File.OpenRead(path);
            return BitConverter.ToString(md5.ComputeHash(stream));
        }
    }
}
