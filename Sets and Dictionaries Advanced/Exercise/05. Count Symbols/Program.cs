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

            string input = Console.ReadLine();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            FillDictionary(symbols,input);
            PrintResult(symbols);
            
            
            
        }

        private static SortedDictionary<char, int> FillDictionary(SortedDictionary<char, int> symbols, string input)
        {
            foreach (var item in input)
            {
                if (!symbols.ContainsKey(item))
                {
                    symbols.Add(item, 0);
                }
                symbols[item]++;
            }
            return symbols;
        }

        private static void PrintResult(SortedDictionary<char, int> symbols)
        {
            foreach (var item in symbols)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }

        
    }
}
