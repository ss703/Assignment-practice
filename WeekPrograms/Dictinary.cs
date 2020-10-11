using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictinary
{
    class Dictinary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> My_dict = new Dictionary<int, string>();
            My_dict.Add(1, "Hii");
            My_dict.Add(2, "thi is");
            My_dict.Add(3, "Soumyaaaa");
            if(My_dict.ContainsKey(1)==true)
            {
                Console.WriteLine("key found");
            }
            else
            {
                Console.WriteLine("key not found");
            }

        }
    }
}
