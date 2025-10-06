using System.Security.Cryptography;


namespace Task_4_5
{
    public static class FileTransfer
    {
        private static List<FileReportItem> _lastReport = new List<FileReportItem>();

        public static void TransferFiles(string source, string destination)
        {
            var report = new List<FileReportItem>();
            var hashCode = new HashSet<string>();//что бы одинаковые файлы не копировать
            CopyDirectory(source, destination, report, hashCode);
            lock (_lastReport)
            {
                _lastReport = report;
            }
        }

        private static void CopyDirectory(string currentSource, string currentDest,
                                  List<FileReportItem> reportItems, HashSet<string> hashCodes)
        {

            Directory.CreateDirectory(currentDest);
            foreach (var file in Directory.GetFiles(currentSource))
            {
                string hash = GetFileHash(file);
                var fileName = Path.GetFileName(file);
                var destination = Path.Combine(currentDest, fileName);

                var item = new FileReportItem()
                {
                    Name = fileName,
                    SourcePath = file,
                    DestinationPath = destination
                };
                if (!hashCodes.Contains(hash)){
                    try
                    {
                        File.Move(file, destination, false);//не переписывает предметы
                        item.Status = FileStatus.Перенесено;
                        hashCodes.Add(hash);
                    }
                    catch
                    {
                        item.Status = FileStatus.Провалено;
                    }
                }
                else
                {
                    item.Status = FileStatus.Дубликат;
                }
                reportItems.Add(item);
                foreach (var dir in Directory.GetDirectories(currentSource))
                {
                    var dir_ = Path.GetFileName(dir);
                    CopyDirectory(dir, Path.Combine(currentDest, dir_), reportItems, hashCodes);
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
