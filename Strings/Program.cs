using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // concat a string
            string str1 = "Hello";
            string str2 = "How are you ?";
            Console.WriteLine(string.Concat(str1 , " " , str2));

            // empty string
            Console.Write("Enter string : ");
            string emp = Console.ReadLine();

            if (emp != string.Empty)
            {
                Console.WriteLine($"  The string is - {emp}  ");
            } else
            {
                Console.WriteLine("Empty string");
            }

            // checking equal string
            string str3 = "Hello";
            string str4 = "Hello";
            if (str3.Equals(str4))
            {
                Console.WriteLine("Same");
            }
            else Console.WriteLine("Not same");

            char[] hello = new[] { 'H', 'e', 'l', 'l', 'o' };
            object str5 = new string(hello);
            object str6 = new string(hello);

            Console.WriteLine($"Is str5 and str6 same equals to each other ? {str5 == str6}");

            // string iteration
            string message = "I started liking C# programming language.";
            for (int i = 0; i < message.Length; i++)
            {
                // works after every 100ms
                Thread.Sleep(10);
                Console.Write(message[i]);
            }
            Console.WriteLine();

            // contains method
            Console.WriteLine($"Does string message contains 'C#' - {message.Contains("C#")}");

            // checking null or empty
            string str7 = "";
            string str8 = null;
            Console.WriteLine($"str7 - {string.IsNullOrEmpty(str7)} \t str8 - {string.IsNullOrEmpty(str8)}");

            // reverse a string
            Console.Write("Enter str9 : ");
            string str9 = Console.ReadLine();
            string newStr = "";
            for (int i = str9.Length-1; i >= 0 ; i--) 
            {
                newStr = newStr + str9[i];
            }
            Console.WriteLine($"newStr - {newStr}");
        }
    }
}
