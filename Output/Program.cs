using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 21;
            string firstName = "Kanishk";
            string lastName = "Rastogi";
            // concatenation of string
            string name = string.Concat(firstName , " " , lastName);

            // prints the age as a string
            Console.WriteLine(age.ToString());

            // string formatting
            Console.WriteLine($"My name is {name} and I'm {age} years old");

            // verbatim string
            const string path = @"C:\Users\Asus\Desktop\C#";
            Console.WriteLine(path);

            // concatenation in array
            string[] names = new string[] { "atharva ", "rama ", "shiv " };
            Console.WriteLine(string.Concat(names));
        }
    }
}
