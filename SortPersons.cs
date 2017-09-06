using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo
{
    class SortPersons
    {
        static void Main(string[] args)
        {
            Person[] people = {
                 new Person { Name = "Scott", Age = 40 },
                 new Person { Name = "Anders", Age = 60 },
                 new Person { Name = "Bob", Age = 35 },
                 new Person { Name = "Steve", Age = 50 }
                 };

            Array.Sort(people);

            foreach(Person p in people)
                Console.WriteLine(p);


            //Array.Sort(people, new Comparison<Person>(CompareByName));
            //Array.Sort(people, CompareByName);

            Array.Sort(people, (p1,p2) => p2.Name.CompareTo(p1.Name));

            foreach (Person p in people)
                Console.WriteLine(p);

        }

        static int  CompareByName(Person p1, Person p2)
        {
            return p1.Name.CompareTo(p2.Name);
        }
    }
}
