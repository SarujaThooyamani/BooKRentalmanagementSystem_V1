using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooKRentalmanagementSystem_V1
{
    internal class Book
    {
        public string Bookid;
        public string Title;
        public string Author;
        public decimal RentalPrice;

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
       
    }
}
