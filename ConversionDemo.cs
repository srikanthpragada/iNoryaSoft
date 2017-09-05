using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo
{
    class ConversionDemo
    {
        static int Main(string[] args)
        {
            Time t = new Time { Hours = 10, Mins = 20, Secs = 30 };
            Time t2 = new Time { Hours = 10, Mins = 20, Secs = 30 };

            Console.WriteLine(t == t2);     //  Time.operator==(t,t2)

            String s1 = "C#";
            String s2 = "C#";

            Console.WriteLine(s1 == s2);  // True 


            int total = t; //  t.TotalSeconds 

            Console.WriteLine(total);

            t = (Time) 10;  // Explicit conversion

            return 0;
        }
    }
}
