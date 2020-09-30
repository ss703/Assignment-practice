using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paindrome
{
    class Program
    {

       
        static void Main(string[] args)
        {
            string str, rev = "";
            Console.WriteLine("enter a string");
            str = Console.ReadLine();
            for(int i=str.Length-1;i>=0;i--)//string reverse
            {
                rev +=str[i].ToString();


            }
            if(rev==str)
            {
                Console.WriteLine("string is palindrome");

            }
            else
            {
                Console.WriteLine("not a paindrome");
            }
            Console.ReadKey();
        }
    }
}
