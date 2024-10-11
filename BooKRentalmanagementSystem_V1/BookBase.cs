namespace BooKRentalmanagementSystem_V1
{
    public class BookBase
    {
        public Book book1 = new Book();
        private string Author;
        private string Bookid;
        private decimal RentalPrice;
        private string Title;

        public override string ToString()
        {
            return $"Bookid: {Bookid},Title: {Title},Author:{Author},RentalPrice:{RentalPrice}";
        }
    }
}