using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpgenericsclass1
{
    //mutiple Generic classes
        class example<T>
    {
        public T Data { get; set; }
    }
    class KeyValuePair<TKey, TValue>
    {
      public  TKey Key{get;set;}
      public TValue Value { get; set; }
    }

      class generic
    {
        static void Main(string[] args)
        {
            KeyValuePair<int, string> val = new KeyValuePair<int, string>();
            val.Key=1;
            val.Value="soumya";
            Console.WriteLine("the key and value pair are" + val.Key+""+ val.Value);


            KeyValuePair<string, string> val1 = new KeyValuePair<string, string>();
            val1.Key = "1";
            val.Value = "swa";
            Console.WriteLine("the key and value pair are" + val1.Key + "" + val1.Value);


            Console.ReadKey();
        }
    }
}
