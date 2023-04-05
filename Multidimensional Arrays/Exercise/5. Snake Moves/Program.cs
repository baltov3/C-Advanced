using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snakeSimbols = Console.ReadLine();

            char[,] matrix = new char[rowCols[0],rowCols[1]];
            bool rightToLeft = true;
            int indexOfSymbol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
              
                    if (rightToLeft)
                    {
                        for (int cow = 0; cow < matrix.GetLength(1); cow++)
                        {
                           matrix[row, cow] = snakeSimbols[indexOfSymbol++];
                          if (indexOfSymbol == snakeSimbols.Length)
                          {
                            indexOfSymbol = 0;
                        
                          }

                        }   
                    
                        rightToLeft = false;
                    }
                    else
                    {
                    for (int cow = matrix.GetLength(1)-1; cow >=0; cow--)
                    {
                        matrix[row, cow] = snakeSimbols[indexOfSymbol++];
                        if (indexOfSymbol == snakeSimbols.Length)
                        {
                            indexOfSymbol = 0;
                        }
                    }
                  
                    rightToLeft = true;
                    }

                
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int cow = 0; cow < matrix.GetLength(1); cow++)
                {
                    Console.Write(matrix[row,cow]);
                }
                Console.WriteLine();

            }
           
           
           
        }
    }
}
