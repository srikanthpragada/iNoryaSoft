using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo
{
    class DynamicLinq
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 20, 33, 45, 60 };

            var evens = nums.Where(n => n % 2 == 0);

            var staticEvens = nums.Where(n => n % 2 == 0).ToArray();

            foreach (var n in evens)
                Console.WriteLine(n);

            nums[0] = 11;


            foreach (var n in evens)
                Console.WriteLine(n);

            foreach (var n in staticEvens)
                Console.WriteLine(n);

            var odds =
                 from n in nums
                 where n % 2 != 0
                 orderby n
                 select n;

            Console.WriteLine("Odd Numbers");

            foreach (var n in odds)
                Console.WriteLine(n);

        }
    }
}
