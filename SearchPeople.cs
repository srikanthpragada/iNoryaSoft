using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo
{
    class SearchPeople
    {
        static void Main(string[] args)
        {
            Person[] people = {
                 new Person { Name = "Scott", Age = 40 },
                 new Person { Name = "Anders", Age = 60 },
                 new Person { Name = "Bob", Age = 35 },
                 new Person { Name = "Steve", Age = 50 }
                 };


            // var selpeople = Array.FindAll(people, (p) => p.Age > 40);
            var selpeople = Array.FindAll(people, (p) => p.Name.Contains('o'));

            foreach (Person p in selpeople)
                Console.WriteLine(p);


        }
    }
}
