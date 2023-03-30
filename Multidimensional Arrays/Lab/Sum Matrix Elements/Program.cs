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
                int [] rowInput = Console.ReadLine().Split( ", " ).Select(int.Parse).ToArray();
                for (int col = 0; col < rowInput.Length; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

           int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {            
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    
                    sum+=matrix[row, col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);




        }
    }
}
