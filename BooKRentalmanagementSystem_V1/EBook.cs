using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooKRentalmanagementSystem_V1
{
    internal class EBook:Book
    {
        public double Filesize;
        public string Format;

        public EBook(string bookid, string title, string author, decimal rentalPrice , double filesize,string format) : base(bookid, title, author, rentalPrice)
        {
            this.Format = format;
            this.Filesize = filesize;
        }
    }
}
