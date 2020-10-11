using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] Jag_arr = new int[3][];
            Jag_arr[0] = new int[1] { 2 };
            Jag_arr[1] = new int[4] { 2,3,4,5 };
            Jag_arr[2] = new int[2] { 1,2 };
           // Jag_arr[3] = new int[6] { 1,28,9,7,4,1 };
            for(int i=0;i<Jag_arr.Length;i++)
            {
                for(int j=0;j<Jag_arr[i].Length;j++)
                {
                    Console.Write( Jag_arr[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
