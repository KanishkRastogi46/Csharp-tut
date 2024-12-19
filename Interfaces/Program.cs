using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        interface Person
        {
            void Details();
            void Greet();
        }

        class User : Person
        {
            private string name;
            private int age;
            public User() { }

            public User (string name , int age) 
            { 
                this.name = name;
                this.age = age;
            }
            public void Details()
            {
                Console.WriteLine($"Name: {this.name} ,\nAge:  {this.age}");
            }

            public void Greet()
            {
                Console.WriteLine($"Hello {this.name.Split(' ')[0]}");
            }
        }
        static void Main(string[] args)
        {
            Person p = new User("Kanishk Rastogi" , 21);
            p.Greet();
            p.Details();
        }
    }
}
