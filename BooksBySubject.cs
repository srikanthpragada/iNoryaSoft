using System;
using System.Linq; 
namespace csdemo
{
    public class BooksBySubject
    { 
        public static void Main() 
        {
            Book[] books = BookRepository.GetBooks();

            //double total = books.Sum (b => b.Price);

            //double avg = books.Average(b => b.NoPages);

            //Console.WriteLine("Total   Price : {0}", total);
            //Console.WriteLine("Average Pages : {0}", avg);

            var result = books.GroupBy(b => b.Subject);

            foreach (var group in result)
            {
                Console.WriteLine("{0} - {1} ", group.Key, group.Count());
                foreach(var b in group)
                {
                    Console.WriteLine(b.Title);
                }
            }

        }
    }
}
