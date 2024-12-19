using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        class Person
        {
            // getters and setters for name
            public string Name { get ; set ; }

            // getters and setters for age
            public int Age{ get; set; }

            // Constructor overloading
            // default constructor
            public Person() { }

            // Normal constructor
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            // copy contructor
            public Person (Person person)
            {
                Name = person.Name;
                Age = person.Age;
            }

            // getter
            public string GetPerson ()
            {
                return $"Person's name is {this.Name} and age is {this.Age}";
            }

            // setter
            public void SetPerson(string newName ,  int newAge)
            {
                this.Name = newName;
                this.Age = newAge;
            }

            // overriding ToString() function of class Object
            public override string ToString()
            {
                return this.GetPerson();
            }
        }
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Salman";
            p1.Age = 50;
            //p1.GetPerson();
            Console.WriteLine($"{p1.Name} is {p1.Age} years old");
            Console.WriteLine();

            Person p2 = new Person("Kanishk" , 21);
            Console.WriteLine(p2.ToString());
            Console.WriteLine();

            Person p3 = new Person(p2);
            Console.WriteLine(p3.GetPerson());
            Console.WriteLine();

        }
    }
}
