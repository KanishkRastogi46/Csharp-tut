using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        public abstract class Person
        {
            public abstract void Details();
            public abstract void Greet();

            public virtual void Welcome()
            {
                Console.WriteLine("Welcome user");
            }
        }

        public class User : Person
        {
            private string name;
            private int age;
            public User (string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public override void Details ()
            {
                Console.WriteLine($"Name : {this.name},\nAge : {this.age}");
            }

            public override void Greet ()
            {
                Console.WriteLine($"Hello {this.name.Split(' ')[0]}");
            }

            public override void Welcome ()
            {
                Console.WriteLine($"Welcome to User class - Mr/Mrs {this.name}");
            }
        }
        static void Main(string[] args)
        {
            // can't create an instance of abstract class
            //Person person = new Person(); ❌
            Person p = new User("Kanishk Rastogi", 21);
            p.Welcome();
            p.Greet();
            p.Details();
        }
    }
}
