namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] files = Directory.GetFiles(inputFolderPath, ".");
            Dictionary<string, Dictionary<string, double>> fileInfo = new Dictionary<string, Dictionary<string, double>>();
            foreach (var item in files)
            {
                string filename = Path.GetFileName(item);
                string extention = Path.GetExtension(item);
                double size = new FileInfo(item).Length / 1024.0;
                if (!fileInfo.ContainsKey(extention))
                {
                    fileInfo.Add(extention, new Dictionary<string, double>());
                }
                fileInfo[extention].Add(filename, size);
                
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in fileInfo.OrderBy(x => x.Value.Count).ThenBy(x=>x.Key))
            {
                stringBuilder.AppendLine(item.Key);
                foreach (var file in item.Value.OrderBy(x=>x.Value))
                {
                    stringBuilder.AppendLine($"{file.Key} - {file.Value}kb");
                }
            }
            return stringBuilder.ToString().TrimEnd();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"/report.txt";
            File.WriteAllText(path, textContent);
        }
    }
}
