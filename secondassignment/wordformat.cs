using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_word_format
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter a num");
            n = Convert.ToInt32(Console.ReadLine());
            string name = "";
            switch(n)
            {
                case 10:
                   name = "TEN";
                 break;
                case 11:
                    name = "EEVEN";
                    break;
                case 12:
                    name = "TWELE";
                    break;
                case 14:
                    name = "FOURTEEN";
                    break;
                case 15:
                    name = "FIFTEEN";
                    break;
                case 16:
                    name = "SIXTEEN";
                    break;
                case 17:
                    name = "SEVENTEEN";
                    break;
                case 18:
                    name = "EIGHTEEN";
                    break;
                case 19:
                    name = "NINTEEN";
                    break;
                case 20:
                    name = "TEWNTY";
                    break;


            }
            Console.WriteLine("in words is=" + name);
            Console.ReadKey();
         
        }
    }
}
