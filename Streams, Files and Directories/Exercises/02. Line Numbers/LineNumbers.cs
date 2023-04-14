namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] lines = File.ReadAllLines(inputFilePath);
            for (int i = 0; i < lines.Length; i++)
            {
                int letters = lines[i].Count(x => char.IsLetter(x));
                int marks = lines[i].Count(x => char.IsPunctuation(x));
                stringBuilder.AppendLine($"Line {i + 1}: -{lines[i]} ({letters})({marks})");
            }
            File.WriteAllText(outputFilePath, stringBuilder.ToString().TrimEnd());
        }
    }
}
