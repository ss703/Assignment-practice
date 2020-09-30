using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 4, 5, 6, 7, 8, 9, 10 };
            Array.Sort(arr);
            foreach (int value in arr)
            {
                Console.WriteLine("arr", value) ;
            }
            Console.ReadKey();
            }
                }
    }
