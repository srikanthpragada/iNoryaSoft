using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo
{
    class PredefDelegatesDemo
    {
        static void Main(string[] args)
        {
            Action ad1 = Print;
            ad1();

            Action<string> ad2 = (s) => Console.WriteLine(s);

            
            Func<string> fd = Fun1;
            Console.WriteLine(fd());

            Func<int> fd2 = () => DateTime.Now.Hour;
            Console.WriteLine(fd2());

            Func<string, string, int> fd3 = (s1,s2) => s1.Length;


        }

        static string Fun1()
        {
            return "A string";
        }

        static void Print()
        {

        }
    }
}
