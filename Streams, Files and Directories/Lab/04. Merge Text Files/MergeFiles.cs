namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            StreamReader reader1 = new StreamReader(firstInputFilePath);
            StreamReader reader2 = new StreamReader(secondInputFilePath);
            SortedSet<int> numbers = new SortedSet<int>();
            while (true)
            {
              string num= reader1.ReadLine();
                if (num==null)
                {
                    break;
                }
                int numeber = int.Parse(num);
                numbers.Add(numeber);
                
            }
            while (true)
            {
                string num = reader2.ReadLine();
                if (num == null)
                {
                    break;
                }
                int numeber = int.Parse(num);
                numbers.Add(numeber);

            }
            StreamWriter streamWriter = new StreamWriter(outputFilePath);
            foreach (var item in numbers)
            {
                streamWriter.WriteLine(item);
            }

        }
    }
}
