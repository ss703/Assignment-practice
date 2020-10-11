using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegullarExpressions
{
    class RegularExprexpressions
    {
        static void Main(string[] args)
        {
            //Create a obj for Regex
            //Regex R = new Regex(@"\d+");//Finding whether digit present or not
            //Match match=R.Match("soumya66");
            //if(match.Success)
            //{
            //    Console.WriteLine("match found", match.Value);//If match found
            //}
           


            ////Start End Matching
            //string t = "hisoumya";
            //if(Regex.IsMatch(t,"^hi"))
            //    {
            //    Console.WriteLine("start matches here");
            //}
            //if (Regex.IsMatch(t, "soumya$"))
            //{
            //    Console.WriteLine("End matches here");
            //}

            //NextMatch
            //Create a obj for Regex

            //string value = "99999";
            //Match match = Regex.Match(value, @"\d");
            //if (match.Success)
            //{
            //    Console.WriteLine(match.Value);//9

            //}
            //match = match.NextMatch();
            //if (match.Success)
            //{
            //    Console.WriteLine(match.Value);//9

            //}
            //match = match.NextMatch();
            //if (match.Success)
            //{
            //    Console.WriteLine(match.Value);//9

            //}
            //match = match.NextMatch();
            //if (match.Success)
            //{
            //    Console.WriteLine(match.Value);//9

            //}

            //replace
            //Regex R = new Regex(@"\d+");//Obj cration
            //string value = R.Replace("sou 1234 234 987 ","praveen");//it will repace with name praveen here whenvenr we write digits
            //Console.WriteLine(" {0}",value);


            //Greedy Matching
            string test = "/soumya/swathi/";
            var res = Regex.Match(test, "^/.*?/");//? lazy
            if (res.Success)
            {
                Console.WriteLine("NON-GREEDY: {0}", res.Value);
            }
            var res1 = Regex.Match(test, "^/.?/");
            if(res1.Success)
            {
                Console.WriteLine("Non Greedy {0}",res1.Value);
                
            }


            //**********VALUE INDEX LENGTH***********

            //Ex1
            Match m = Regex.Match("123 Axxxxy", @"A.*y");
            if (m.Success)
            {
                Console.WriteLine("Value  = " + m.Value);
                Console.WriteLine("Length = " + m.Length);
                Console.WriteLine("Index  = " + m.Index);
            }


            //****************Bool Meethod**************:
            bool IsValid(string value)
            {
                return Regex.IsMatch(value, @"^[a-zA-Z0-9]*$");
            }

            void Main()
            {
                // Test the strings with the IsValid method.
                Console.WriteLine(IsValid("dotnetperls0123"));
                Console.WriteLine(IsValid("DotNetPerls"));
                Console.WriteLine(IsValid(":-)"));
                // Console.WriteLine(IsValid(null)); // Throws an exception
            }

            //********IGNORE CASE************
            const string value = "SOUMYA";
            // ... This ignores the case of the "SO" characters.
            if (Regex.IsMatch(value, "so...", RegexOptions.IgnoreCase))
            {
                Console.WriteLine(true);
            }




            Console.ReadKey();


        }
    }
}
