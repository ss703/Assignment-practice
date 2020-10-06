using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegularExpressions1
{
    class Program
    {
        static void Main(string[] args)
        {

            //**********Apply regex and find for matchvalue.  value=99,value=55*******

            //Step:1=>>Create a regex-Object need to be created
            //Digit or not
            //Regex R = new Regex(@"\d+");//Find the digits present/match in the string.
            //Match match = R.Match("soumya87soumya");
            //Match match=R.Match("9999");
            //if (match.Success)
            // {
            //      Console.WriteLine("The match value of digit:" + match.Value);
            //}


            // ********without creating instance of regex using static *************

            //string input = "/content/alternate-1.aspx";

            //// Part 2: call Regex.Match.
            //Match match = Regex.Match(input, @"content/([A-Za-z0-9\-]+)\.aspx$",
            //  RegexOptions.IgnoreCase);

            //// Part 3: check the Match for Success.
            //if (match.Success)
            //{
            //    // Part 4: get the Group value and display it.
            //    string key = match.Groups[1].Value;
            //    Console.WriteLine(key);
            //}



            // ****************START ,END MATCHING********
            //Frst example
            //string test = "aabb";
            ////Match the start of a string

            //if(Regex.IsMatch(test,"^aa"))
            //{
            //    Console.WriteLine("start matches");//start matches
            //}
            //if(Regex.IsMatch(test,"bb$"))
            //{
            //    Console.WriteLine("End matches");//end marches

            //}


            //Second example
            //string test = "soumya@gmail";
            ////Match the start

            //if (Regex.IsMatch(test, "^soumya")) 
            //{
            //    Console.WriteLine("start match");
            //}
            //if(Regex.IsMatch(test,"@gmail$"))
            //{
            //    Console.WriteLine("end match");
            //}

            //************NEXT MATCH*********          
            //string value = "4 and 5";
            //Match match = Regex.Match(value, @"\d");
            //if(match.Success)
            //{
            //    Console.WriteLine(match.Value);

            //}
            //match=match.NextMatch();
            //if(match.Success)
            //{
            //    Console.WriteLine(match.Value);

            //}




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

            //********REPLACE***********
            //Regex regex = new Regex(@"\d");
            //string input = regex.Replace("soumya 12233 64646"," swathi");
            //Console.WriteLine("input {0}", input);

            //******GREEDY MATCHING*********//

            //string test = "/soumya/swathi/";

            ////case1:Lazy 
            //var res = Regex.Match(test, "^/.*?/");//? lazy
            //if (res.Success)
            //{
            //    Console.WriteLine("NON-GREEDY: {0}", res.Value);
            //}
            ////case2.Default regex
            //var res1 = Regex.Match(test, "^/.*/");//? lazy
            //if (res1.Success)
            //{
            //    Console.WriteLine("NON-GREEDY: {0}", res1.Value);
            //}


            //**********MATCH PARSE NUMBERS
            ////Ex 1:
            //string input = "Dot Net 100 Perls";
            //Match match = Regex.Match(input, @"\d+");
            //if (match.Success)
            //{
            //    int.TryParse(match.Value, out int number);
            //    // Show that we have the numbers.
            //    Console.WriteLine("NUMBERS: {0}, {1}", number, number + 1);
            //}

            //Ex:2
            //string input = "programmin is 14 15 16 is fun";
            //Match match = Regex.Match(input, @"\d+");
            //if (match.Success)
            //{
            //    int.TryParse(match.Value, out int number);
            //    // Show that we have the numbers.
            //    Console.WriteLine("NUMBERS: {0}, {1}", number, number + 1);
            //}



            //**********VALUE INDEX LENGTH***********

            //Ex1
            //Match m = Regex.Match("123 Axxxxy", @"A.*y");
            //if (m.Success)
            //{
            //    Console.WriteLine("Value  = " + m.Value);
            //    Console.WriteLine("Length = " + m.Length);
            //    Console.WriteLine("Index  = " + m.Index);
            //}


            //Ex2
            //Match m = Regex.Match("123 Axxxxy", @"A.*y");
            //if (m.Success)
            //{
            //    Console.WriteLine("Value  = " + m.Value);
            //    Console.WriteLine("Length = " + m.Length);
            //    Console.WriteLine("Index  = " + m.Index);
            //}

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
        
























        Console.ReadKey();
        }
    }
}
    








   
