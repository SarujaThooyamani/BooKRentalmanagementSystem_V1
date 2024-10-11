using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooKRentalmanagementSystem_V1
{
    internal class BookManager
    {
        public List<Book> books=new List<Book>();
        public void CreateBook(Book book)
        {

            books.Add(book);
            Console.WriteLine("Book added Successfully");
        }

        public void ReadBooks()
        {
            if(books.Count != 0)
            {
                foreach (Book book in books)
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine("no books to show");
            }
        }
        public void UpdateBook(Book book)
        {
            var data =books.Find(b=>b.BookId==book)
        }

    }

    
}
