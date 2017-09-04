using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo
{
    class ImplicitVariableDemo
    {
        static void Main()
        {
            var num = 10;

            // num = "Abc";

            var d1 = DateTime.Now;
            var a = new int[] { 10, 20, 30 };

            var t1 = new { Name = "C#", Version = "7.0" };
            
        }
    }
}
