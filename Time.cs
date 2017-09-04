using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo
{
    class Time
    {
        public int Hours { get; set; }
        public int Mins { get; set; }
        public int Secs { get; set; }

        // Conversion operator 
        public static implicit operator int (Time t)
        {
            return t.Hours * 3600 + t.Mins * 60 + t.Secs;
        }
    }

    static class ExMethods
    {
        public static void Print(this Time t)
        {
            Console.WriteLine("{0:00}:{1:00}:{2:00}", t.Hours, t.Mins, t.Secs);
        }

        // Extension method in String class 
        public static int FindCount(this string st, string pattern)
        {
            // code 
            return 1;
        }
    }

    class TestTime
    {
        static void Main(string[] args)
        {
            Time t = new Time { Hours = 10, Mins = 10, Secs = 10 };
            // ExMethods.Print(t);
            t.Print();

            string st = "This is C#";
            Console.WriteLine(st.FindCount("is"));

            // Console.WriteLine(t.TotalSeconds);
        }
           
    }
}
