using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo
{
    class QueryOperatorsDemo
    {
        static bool CostlyBooks(Book b)
        {
            if (b.Price > 400)
                return true;
            else
                return false; 
        }

        static void Main(string[] args)
        {
            var books = BookRepository.GetBooks();

            // var selbooks = books.Where(CostlyBooks);
            var selbooks = books.Where(b =>
               {
                   // Console.WriteLine("Processing {0}",b.Title);
                   return b.Price > 400;
               })
               .OrderBy(b => b.Price)
               .Select(b => new { Title = b.Title, Price = b.Price * 1.18 });


            foreach (var b in selbooks)
                Console.WriteLine("{0} {1}",b.Title, b.Price);


        }
    }
}
