using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {
        struct Person
        {
            public string name;
            public int age;

            public Person (string name , int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Structures in C#");

            Person person1;
            person1.name = "Kanishk";
            person1.age = 10;

            Console.WriteLine(person1.name + " - " + person1.age);

            Person person2 = CreatePerson();
            Console.WriteLine($"{person2.name} - {person2.age}");

            Person person3 = new Person("Saloni" , 21);
            Console.WriteLine($"{person3.name} - {person3.age}");

        }

        static Person CreatePerson()
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();

            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            return new Person(name , age);
        }
    }
}
