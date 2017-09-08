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
                Console.WriteLine("{0} {1}", b.Title, b.Price);

            /*
            var maxprice = books.Max(b => b.Price);

            var book = books.Where(b => b.Price == maxprice)
                            .OrderByDescending( b => b.NoPages)
                            .First();
            */

            var maxprice = books.Max(b => b.Price);

            var book = (from b in books
                        where b.Price == maxprice
                        orderby b.NoPages descending
                        select b
                        ).First();

            Console.WriteLine("{0} - {1}",book.Title, book.Price);

            var total = books.Sum(b => b.Price);


        }
    }
}
