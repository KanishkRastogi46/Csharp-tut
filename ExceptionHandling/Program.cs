using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Handling");

            // try...catch...finally for handling exception
            bool success = false;
            int num = 0;
            while (!success)
            {
                try
                {
                    Console.WriteLine("Enter a number : ");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);
                    success = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter a Int32 !");

                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Exception Message : {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong");
                    Console.WriteLine($"Exception Message : {ex.Message}");
                }
                finally
                {
                    Console.WriteLine($"Num is {num}");
                }
            }
            Console.WriteLine("Program Finished");
        }
    }
}
