using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            int line = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            FillDictionary(numbers, line);
            PrintResult(numbers);
            
            
            
        }

        private static void PrintResult(Dictionary<int, int> numbers)
        {
            int num = 0;
            foreach (var item in numbers)
            {
                if (item.Value%2==0)
                {
                    num = item.Key;
                }
            }
            Console.WriteLine(num);
        }

        private static Dictionary<int, int> FillDictionary(Dictionary<int, int> numbers, int line)
        {
            for (int i = 0; i < line; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(currentNum))
                {
                    numbers.Add(currentNum, 0);
                }
                numbers[currentNum]++;
            }
            return numbers;
        }
    }
}
