using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return String.Format("{0} -  {1}", Name, Age);
        }

        public int CompareTo(Person other)
        {
            return this.Age - other.Age; 
        }
    }
}
