using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooKRentalmanagementSystem_V1
{
    internal class PrintedBook : Book
    {

        public int ISBN;
        public int NumberOfPages;

        public PrintedBook(string bookid, string title, string author, decimal rentalPrice,int isbn,int numberofpage) : base(bookid, title, author, rentalPrice)
        {
            ISBN=isbn;
            NumberOfPages=numberofpage;
        }
    }
}
