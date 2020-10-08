using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    class jaggedarray
    {
        static void Main(string[] args)
        {
            int[,] num = {
                 { 9,8,7},//oth row
                  { 6, 9, 5 },//1st row
                  { 1, 2, 3}//2nd row
            };
            Console.WriteLine(num.GetLength(0));//num of rows
            Console.WriteLine(num.GetLength(1));//number of col for 1st row
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int k = 0; k < num.GetLength(1); k++)
                {
                    Console.Write(num[i,k] + "");

                }
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
}
