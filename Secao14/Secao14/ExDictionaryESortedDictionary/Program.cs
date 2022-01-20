using System;
using System.Collections.Generic;

namespace ExDictionaryESortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["users"] = "Anderson do Nascimento Silva";
            cookies["email"] = "anderson_ns5@hotmail.com";

            Console.WriteLine( cookies["email"]);
            Console.WriteLine(cookies.Count);
            Console.WriteLine(cookies["users"]);

            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
