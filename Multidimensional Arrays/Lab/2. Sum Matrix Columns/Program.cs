using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int [] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < rowInput.Length; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int cowsSum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    cowsSum += matrix[row, col];
                }
                Console.WriteLine(cowsSum);
            }






        }
    }
}
