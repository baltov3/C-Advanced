using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int lines  = int.Parse(Console.ReadLine());
            Dictionary<string,Dictionary<string,int>> wardrobe = new Dictionary<string,Dictionary<string,int>>();
            FillWard(wardrobe, lines);
            string[] clothesToFind = Console.ReadLine().Split();
            string color = clothesToFind[0];
            string cloth = clothesToFind[1];
            PrintWardrobe(wardrobe, color, cloth);
        }

        private static void PrintWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, string color, string cloth)
        {
            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var cloths in item.Value)
                {
                    if (color==item.Key&&cloth==cloths.Key)
                    {
                        Console.WriteLine($"* {cloths.Key} - {cloths.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloths.Key} - {cloths.Value}");
                    }
                   
                }

            }
        }

        private static Dictionary<string, Dictionary<string, int>>  FillWard(Dictionary<string, Dictionary<string, int>> wardrobe, int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                string currentColor = input[0];
                string[] clothes = input[1].Split(',');

                if (!wardrobe.ContainsKey(currentColor))
                {
                    wardrobe.Add(currentColor, new Dictionary<string, int>());

                }
                foreach (var item in clothes)
                {
                    if (!wardrobe[currentColor].ContainsKey(item))
                    {
                        wardrobe[currentColor].Add(item, 0);
                    }
                    wardrobe[currentColor][item]++;


                }
            }
            return wardrobe;
        }
    }
}
