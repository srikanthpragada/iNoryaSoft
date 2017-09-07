using System;
namespace csdemo
{
    public class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public double NoPages { get; set; }
        public string Subject { get; set; }
    }

    public static class BookRepository {

        public static Book[] GetBooks()
        {
            Book[] books = {
                new Book() { Title = "Angular2", Price = 450, NoPages = 400, Subject = "Web" },
                new Book() { Title = "Asp.Net MVC", Price = 650, NoPages = 850 , Subject ="Web" },
                new Book() { Title = "Bootstrap", Price = 350, NoPages = 4500 , Subject = "Web"},
		   	    new Book() { Title = "C# Language", Price = 500, NoPages = 750 , Subject = "Language"},
				new Book() { Title = "Java Complete Reference", Price = 600, NoPages = 1100 , Subject = "Language"}
			};
            return books;
        }// GetBooks()
                
    }
}
