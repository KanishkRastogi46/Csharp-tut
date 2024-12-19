using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if... else if... else
            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18 && age >= 0) Console.WriteLine("Not eligible to vote");
            else if (age >= 18 && age <= 100) Console.WriteLine("Eligible to vote");
            else Console.WriteLine("Invalid Age");

            // switch 
            Console.WriteLine("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 0: Console.WriteLine("case 0");
                    break;
                case 1: Console.WriteLine("case 1");
                    break;
                default: Console.WriteLine("default");
                    break;
            }

            // conditional operator
            string name = age >= 18 ? "Kanishk" : "Chotu";
            Console.WriteLine(name);


            // for loop
            for (int k = 1; k < 11; k++) Console.WriteLine(k);

            // foreach loop
            int[] arr = new[] { 10, 20, 30 };
            foreach (int item in arr){
                Console.WriteLine(item);
            }

            // while loop
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            // do-while loop
            int j = 1;
            do {
                Console.WriteLine(j);
                j++;
            } while (j <= 10);
        }
    }
}
