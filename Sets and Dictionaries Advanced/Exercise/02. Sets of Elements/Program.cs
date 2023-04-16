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

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            FillSet(firstSet,input[0]);
            FillSet(secondSet,input[1]);
            CheckSet(firstSet, secondSet);
            
            
        }

        private static void CheckSet(HashSet<int> firstSet, HashSet<int> secondSet)
        {
            List<int> numbers = new List<int>();
            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    numbers.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }

        private static HashSet<int> FillSet(HashSet<int> set, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }
            return set;
        }
    }
}
