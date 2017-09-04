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

            int total = t; //  t.TotalSeconds 

            Console.WriteLine(total);

            // t = 10; 


            return 0;
        }
    }
}
