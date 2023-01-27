using System;
using System.Collections.Generic;

namespace Collection_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 15, 3, 6, 7 };

            Console.WriteLine(intArr[2]);
            Console.WriteLine();

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Schlüssel1", 42);
            dict.Add("Schlüssel2", 21); 
            //dict.Add("Schlüssel1", 43);       Exception: Key muss einzigartig sein

            Console.WriteLine(dict["Schlüssel2"]);

            Dictionary<short, char> dict2 = new Dictionary<short, char>();
            List<char> li = new List<char>();
        }
    }
}
