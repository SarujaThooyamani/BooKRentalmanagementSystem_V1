using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BooKRentalmanagementSystem_V1
{
    internal class BookManager
    {
        public List<Book> books = new List<Book>();
        public void CreateBook(Book book)
        {
           
             books.Add(book);
            Console.WriteLine("Book added Successfully");
        }

        public void ReadBooks()
        {
            
            if (books.Count != 0)
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
        public void UpdateBook(string bookid, string newtitle,string newauthor,decimal newRentalprice)
        {
            
            var data = books.Find(b => b.Bookid ==bookid);
            if (data != null)
            {
                data.Title = newtitle;
                data.Author = newauthor;
                data.RentalPrice = newRentalprice;
                Console.WriteLine("Book updated Succesfully");
            }
            else
            {
                Console.WriteLine("can't find book");
            }


        }
        public void DeleteBook(string bookid)
        {
           
            var book= books.Find(b=>b.Bookid ==bookid);
            if (book != null)
            {
                books.Remove(book);
            }
            else
            {
                Console.WriteLine("can't find book");
            }
        }

    }
} 
