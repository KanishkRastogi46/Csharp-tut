using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dictionary data structure same like arraylist in java or object in js or dictionary of Python
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Kanishk");
            dict.Add(2, "Rama");
            dict.Add(3, "Krishna");


            Console.WriteLine("For loop");
            for (int i = 0; i < dict.Count; i++) 
            {
                KeyValuePair<int , string> pair = dict.ElementAt(i);
                Console.WriteLine($"{pair.Key} : {pair.Value}");  
            }

            Console.WriteLine("Foreach loop");
            foreach (KeyValuePair<int, string> pair in dict) Console.WriteLine($"{pair.Key} : {pair.Value}");

            Console.WriteLine();
            Console.WriteLine($"dict[1] = {dict[1]}");
            Console.WriteLine($"dict[3] = {dict[3]}");
        }
    }
}
