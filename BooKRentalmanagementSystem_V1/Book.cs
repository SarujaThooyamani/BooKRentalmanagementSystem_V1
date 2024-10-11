using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooKRentalmanagementSystem_V1
{
    internal class Book
    {
        private string Bookid;
        private string Title;
        private string Author;
        private decimal RentalPrice;

        public Book(string bookid, string title, string author, decimal rentalPrice)
        {
            Bookid = bookid;
            Title = title;
            Author = author;
            RentalPrice = rentalPrice;
        }

        public override string ToString()
        {
            return $"Bookid: {Bookid},Title: {Title},Author:{Author},RentalPrice:{RentalPrice}";
        }
        public Book book1 = new Book();
    }
}
