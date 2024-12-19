using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Test
    {
        public static int Multiply(int a, int b = 10)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
    internal class Program
    {
        public static string name = "kanishk rastogi";
        static void Main(string[] args)
        {
            // static functions in C# within the same class as Main function
            Console.WriteLine("static functions in C# within the same class as Main function");
            int sum = DoSomeThing(20, 47);
            Console.WriteLine(sum);

            // static function of another class with optional parameter b
            Console.WriteLine("static function of another class with optional parameter b");
            int product = Test.Multiply(20);
            Console.WriteLine(product);

            // making an object of class Test and using a non-static function
            Console.WriteLine("making an object of class Test and using a non-static function");
            Test test = new Test();
            double divide = test.Divide(100D, 11D);
            Console.WriteLine("{0:0.00}", divide);

            // using a non-static function within the same class as Main function
            Console.WriteLine("using a non-static function within the same class as Main function");
            Program program = new Program();
            int modulo = program.Modulo(21, 11);
            Console.WriteLine(modulo);

            // static variable
            Console.WriteLine("static variable");
            Console.WriteLine(Program.name);
            Console.WriteLine();
            Console.WriteLine(name);
            Console.WriteLine();

            // works the same as document.title in javascript, the only difference is it sets the title of a tab in Terminal
            Console.WriteLine("works the same as document.title in javascript, the only difference is it sets the title of a tab in Terminal");
            Console.Title = Program.name;

            Console.WriteLine();

            // Types of parameter 
            Console.WriteLine("Types of parameter");
            Console.WriteLine("1.) Optional parameter");
            // 1.) optional parameters
            Anything();

            // 2.) named parameters
            Console.WriteLine("2.) Named parameter");
            int ageInput = 21;
            string nameInput = "Rahul";
            PrintDetails(age: ageInput, name: nameInput);

            // 3.) output parameter using keyword out
            Console.WriteLine("3.) output parameter using keyword out");
            int num = 1;
            Console.WriteLine($"Value of num is {num}");
            bool success = Func(out num);
            Console.WriteLine(success);
            Console.WriteLine($"Value of num is {num}");

            List<int> list = new List<int>();
            list.Add(10);
            list.Add(30);
            list.Add(15);
            int n = -1;
            IndexOf(list , 15 , out n);
            Console.WriteLine(n);

            // 4.) reference parameters
            Console.WriteLine("4.) pass by reference parameters");
            int a = 10 , b = 30;
            Console.WriteLine($"a = {a}  \t  b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}  \t  b = {b}");
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void IndexOf(List<int> l , int num , out int n)
        {
            n = l.IndexOf(num);
        }

        static bool Func(out int num) 
        {
            num = 10;
            return true;
        }

        static void PrintDetails(string name  , int age)
        {
            Console.WriteLine($"My name is {name} and I am {age} years old");
        }

        static void Anything(int s = default)
        {
            Console.WriteLine($"It prints optional parameter s as {s}");
        }

        static int DoSomeThing(int a, int b)
        {
            return a + b;
        }

        int Modulo(int a, int b)
        {
            return a % b;
        }
    }
}
