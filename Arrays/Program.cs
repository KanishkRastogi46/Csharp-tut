using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array integer
            int[] arr1 = new int[4];
            //arr1[0] = 1;
            //arr1[1] = 2;
            //arr1[2] = 3;
            //arr1[3] = 4;

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"Enter arr1[{i}] : ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Normal for loop");

            for (int i = 0; i < arr1.Length; i++) 
            {
                Console.Write($"{arr1[i]}  ");
            }

            Console.WriteLine();
            Console.WriteLine("Foreach loop");

            foreach (int num in arr1) 
            {
                Console.Write($"{num}  ");
            }

            Console.WriteLine();
            Console.WriteLine("Sorting an array using built in sort function");

            // sorting an array
            Array.Sort(arr1);
            foreach (int num in arr1)
            {
                Console.Write($"{num}  ");
            }

            Console.WriteLine();
            Console.WriteLine("Reversing an array using built in reverse function");

            // reversing an array
            Array.Reverse(arr1);
            foreach (int num in arr1) Console.Write($"{num}  ");

            Console.WriteLine();
            Console.WriteLine("Clearing an array using built in clear function");

            // clearing an array
            Array.Clear(arr1 , 0 , arr1.Length);
            foreach (int num in arr1) Console.Write($"{num}  "); // print 4 zeros :- 0 0 0 0

            Console.WriteLine();
            Console.WriteLine("Searching an element in array by index");

            // searching an element in array by index
            int[] arr2 = new int[6];
            arr2[0] = 1;
            arr2[1] = 2;
            arr2[2] = 3;
            arr2[3] = 4;
            arr2[4] = 3;
            arr2[5] = 4;
            int pos1 = Array.IndexOf(arr2 , 4 , 1 , 4); // array , search , start , stop
            int pos2 = Array.IndexOf(arr2, 4, 4);       // array , search , start
            int pos3 = Array.IndexOf(arr2, 0);          // array , search
            Console.WriteLine($"pos1 = {pos1} , pos2 = {pos2} , pos3 = {pos3}");

            // jagged arrays i.e, array with each row having different number of columns
            Console.WriteLine("Jagged arrays") ;
            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new[] { 1, 2, 3 };
            jaggedArr[1] = new[] { 4, 5 };
            jaggedArr[2] = new[] { 6, 7, 8, 9 };
            foreach (int[] jArr in jaggedArr)
            {
                foreach (int i in jArr) Console.WriteLine(i);
            }
                    

            Console.WriteLine();
            Console.WriteLine("----THE END----");
        }
    }
}
