namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            StreamReader streamReader = new StreamReader(wordsFilePath);
            StringBuilder stringBuilder = new StringBuilder();
            while (true)
            {
                string line = streamReader.ReadLine();
                if (line==null)
                {
                    break;
                }
                stringBuilder.Append(line);
            }
            string[] words = stringBuilder.ToString().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StreamReader streamReadertext = new StreamReader(textFilePath);
            StringBuilder stringBuildertext = new StringBuilder();
            while (true)
            {
                string line = streamReadertext.ReadLine();
                if (line == null)
                {
                    break;
                }
                stringBuildertext.Append(line);
            }
            string[] text = stringBuildertext.ToString().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            foreach (var item in words)
            {
                int count = text.Count(x => x==(item));
                dictionary.Add(item, count);

            }
            StreamWriter streamWriter = new StreamWriter(outputFilePath);
            foreach (var item in dictionary)
            {
                streamWriter.WriteLine($"{item.Key} - {item.Value}");
            }

        }
    }
}
