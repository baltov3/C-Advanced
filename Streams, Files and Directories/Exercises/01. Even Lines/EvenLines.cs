namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StreamReader streamReader = new StreamReader(inputFilePath);
            StringBuilder stringBuilder = new StringBuilder();
            char[] symbols = { '-', ',', '.', '!', '?' };
            int counter = 0;
            while (true)
            {
                string result = streamReader.ReadLine();
                if (result==null)
                {
                    break;
                }
                if (counter%2==0)
                {
                    foreach (var item in symbols)
                    {
                        result = result.Replace(item, '@');
                    }
                    result = string.Join(" ", result.Split().Reverse());
                }
                stringBuilder.AppendLine(result);
                counter++;
            }
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
