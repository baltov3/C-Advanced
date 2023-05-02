namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            StreamWriter streamWriter = new StreamWriter(outputFilePath);
            for (int i = 0; i < lines.Length; i++)
            {
                streamWriter.WriteLine($"{i + 1}. {lines[i]}");
            }
        }
    }
}
