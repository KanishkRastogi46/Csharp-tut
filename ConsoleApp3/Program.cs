using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int incr = 0;
            Console.WriteLine(incr++);      // post-increment
            Console.WriteLine(++incr);      // pre-increment
            incr += 1;
            Console.WriteLine(incr);

            int rem = 9 % 4;
            Console.WriteLine(rem);

            int bodmas = 10 - 20 * 30 / 5 + 15;
            Console.WriteLine(bodmas);

            double div = 10d / 3d;
            Console.WriteLine("{0:0.00}", div); // 3.33

            float div1 = 10f / 3;
            Console.WriteLine("{0:0.0}", div1); // 3.3

            decimal div2 = 10 / 3;
            Console.WriteLine(div2);           // 3
        }
    }
}
