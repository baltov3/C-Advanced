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

            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string username = Console.ReadLine();
                set.Add(username);
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            
            
        }
    }
}
