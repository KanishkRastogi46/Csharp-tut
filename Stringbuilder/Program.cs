using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringbuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("kanishk");
            sb.AppendLine(" Rastogi is a good person");

            // replaces good from great
            sb.Replace("good", "great");

            Console.WriteLine(sb);

            Console.WriteLine(sb.GetType());

            string str = "Lapola";
            Console.WriteLine(str.GetType());
        }
    }
}
