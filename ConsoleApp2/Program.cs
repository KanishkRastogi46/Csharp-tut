using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // numeric data types
            byte c = 12;
            short d = 13;
            int a = 10;
            long b = 10L;

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(a);
            Console.WriteLine(b);

            float e = 50.77f;
            double f = 50.6756d;
            decimal g = 67.456m;

            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);

            // boolean type
            bool h = true;

            Console.WriteLine(h);

            // char and string
            char i = 'i';
            string name = "kanishk";

            Console.WriteLine(i);
            Console.WriteLine(name);

            // TryParse method
            Console.Write("Enter x : ");
            string x = Console.ReadLine();
            int y = 0;
            bool isParsed = int.TryParse(x, out y);  // if x is an actual int then that integer value in y otherwise y will be 0
            Console.WriteLine(isParsed);
            Console.WriteLine(y);
        }
    }
}
