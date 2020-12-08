using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2.MultidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of batches:");
            int nb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of students:");
            int ns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of subjects:");
            int nsub = Convert.ToInt32(Console.ReadLine());
            
            int[,,] arr = new int[nb,ns,nsub];
            Console.WriteLine();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.WriteLine("Enter marks of batch no. {0}, student no. {1}, subject no. {2}:",i,j,k);
                        arr[i,j,k] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("MARKS ==>>");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.WriteLine("Marks of batch no. {0}, student no. {1}, subject no. {2}: {3}", i, j, k, arr[i,j,k]);
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
