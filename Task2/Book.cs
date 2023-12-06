namespace book
{
    public class Book
    {
        private string title;
        private string author;
        private float price;
        public Book(string title, string author, float price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
        public string Title 
        {
            get
            {
                return title;
            }
            set
            {
                title = (value == null) ? string.Empty : value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = (value == null) ? string.Empty : value;
            }
        }
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = (value < 0) ? 0 : value;
            }
        }
        public void Print()
        {
            Print(this);
        }
        public static void Print(Book book)
        {
            Console.WriteLine($"Книга \"{book.Title}\"; Автор {book.Author}; Стоимость {book.Price}");
        }
    }
}