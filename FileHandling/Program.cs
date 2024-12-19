using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File handling

            // creating a file
            string filePath = @"C:\Users\Asus\Desktop\c-sharp.txt";

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
                Console.WriteLine("File created successfully");
            }
            else Console.WriteLine("File already exists");

            // creating a directory
            string folderPath = @"C:\Users\Asus\Desktop\csharp-dir";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Folder created successfully");
            }
            else Console.WriteLine("Folder already exists");


            // writing into file
 
            //if (File.Exists(filePath))
            //{
            //    // for writing some text into file
            //    //File.WriteAllText(filePath, "C# is a good programming language.");

            //    // for writing multiple lines into file
            //    string[] lines = new[]
            //    {
            //        "C# is 😍",
            //        "dotnet framework is my ❤️",
            //        DateTime.Now.ToString(),
            //    };
            //    File.AppendAllLines(filePath , lines);
            //    Console.WriteLine("File write successfull");
            //}
            //else File.Create(filePath);


            // reading a file
            //if (File.Exists(filePath))
            //{
            //    // reading all lines of file
            //    string[] lines = File.ReadAllLines(filePath);

            //    foreach (string line in lines) Console.WriteLine(line);

            //    Console.WriteLine("Read file successfull");
            //}
            //else File.Create(filePath);

            FileInfo info = new FileInfo(filePath);
            Console.WriteLine(info.FullName);
            Console.WriteLine(info.Name);
            Console.WriteLine(info.Extension);
            Console.WriteLine(info.CreationTime);
            Console.WriteLine(info.DirectoryName);
            Console.WriteLine(info.Length);
          
            File.Delete(filePath);
            Directory.Delete(folderPath);
        }
    }
}
