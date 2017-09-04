using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo
{
    class DynamicDemo
    {
        static void Main(string[] args)
        {
            object obj = "Abc";

            string name = obj as string;  // Downcasting 
            Console.WriteLine(name.Length);


            obj = DateTime.Now;

            DateTime now = (DateTime) obj;  // Downcasting 
            Console.WriteLine(now.Year);


            dynamic d = "Abc";
            Console.WriteLine($"Length Is {d.Length}");

            d = DateTime.Now;
            Console.WriteLine(d.Year);






        }
    }
}
