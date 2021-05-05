using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
           var file = File.ReadAllText(@"/Users/timothyhart/Desktop/hello_world.jpg");
            Console.WriteLine(file);

            foreach (var line in file)
            {
                //Console.WriteLine(line);
            }
        }
    }
    
}
