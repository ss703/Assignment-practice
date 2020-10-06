using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpgenericclass2
{
    class example<T>
    {
        T data;
        public example( T Data)
            {
            this.data = Data; 
            }
        public void display()
        {
            Console.WriteLine("values are" + this.data);
        }
}
    class generics
    {
        static void Main(string[] args)
        {
            example<int> d = new example<int>(10);
            example<string> d1 = new example<string>("soumya");
            // example<int,string> d2=new example<int,string>()
            example<char> d3 = new example<char>('sou');
            d.display();
            d1.display();
            d3.display();
            Console.ReadKey();

        }
    }
}
