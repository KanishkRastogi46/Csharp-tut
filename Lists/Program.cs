using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);

            Console.WriteLine("For loop");
            for (int i = 0; i < l.Count; i++) 
            {
                Console.WriteLine(l[i]);
            }

            Console.WriteLine("Foreach loop");
            foreach (int num in l) Console.WriteLine(num);

            // removing a item
            Console.WriteLine("Removing from index 0");
            l.RemoveAt(0);
            Console.WriteLine($"Now item at index 0 is {l[0]}");
        }
    }
}
