namespace OddLines
{
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader streamReader = new StreamReader(inputFilePath);
            StreamWriter streamWriter = new StreamWriter(outputFilePath);
            int count = 0;
            while (true)
            {
                string line = streamReader.ReadLine();
                if (line==null)
                {
                    break;
                }
                if (count%2!=0)
                {
                    streamWriter.WriteLine(line);
                }
            }
        }
    }
}
