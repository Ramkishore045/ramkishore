using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;


namespace LINQ
{
    class Task1

    {
        public static void Main()
        {
            IList<Book> BookData = new List<Book>()
            {
                new Book(){BookID = 1,Title="Nineteen Eighty-Four",Author="George OrWell",Price=650},
                new Book(){BookID = 2,Title="The Lord of the Rings",Author="J.R.R.Tolkien",Price=799},
                new Book(){BookID = 3,Title="Don Quixote",Author="Alonso Quixano",Price=489},
                new Book(){BookID = 4,Title="Beloved",Author="Toni Morrison",Price=149},
                new Book(){BookID = 5,Title="Anna Karenina",Author="Leo Tolstoy",Price=1119},
                new Book(){BookID = 6,Title="Madame Bovary",Author="Gustave Flaubert",Price=345},
                new Book(){BookID = 7,Title="War and Peace",Author="Ben Tolstoy",Price=560},
                new Book(){BookID = 8,Title="Lolita",Author="Vladimir Nabokov",Price=249}
            };
            // All the Data
            var boqry = from b1 in BookData
                        select b1;
            foreach (var q in boqry)
                Console.WriteLine(q.BookID +" "+q.Title +"  "+q.Author +"  "+q.Price);
            Console.ReadLine();
            Console.WriteLine("************************************************************************");
            // PARTICULAR AUTHOR
            var boqry1 = from b2 in BookData
                         where b2.Author.Contains("Leo")
                         select b2;
            foreach (var B in boqry1)
                Console.WriteLine(B.Title);
            Console.ReadLine();
            Console.WriteLine("************************************************************************");
            //LOWEST TO HIGHEST
            var boqry2 = BookData.OrderBy(B => B.Price);
            foreach (var B in boqry2)
                Console.WriteLine(B.Price + " " + B.Title);
            Console.ReadLine(); Console.WriteLine("************************************************************************");

            //ASCENDING ORDER
            var boqry3 = BookData.OrderBy(B => B.Author);
            foreach(var B in boqry3)
                Console.WriteLine( B.Author+ " "+B.Title);
            Console.ReadLine(); Console.WriteLine("************************************************************************");

        }
    }

    class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

    }
}