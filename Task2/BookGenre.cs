using book;

namespace bookGenre
{
public class BookGenre: Book
{
    private string genre; // Жанр

    public BookGenre(string title, string genre, string author, decimal price)
        :base(title, author, price)
    {
        Genre = genre;
    }

    public string Genre
    {
        get
        {
            return genre;
        }
        set
        {
            genre = (value == null ? string.Empty : value);
        }
    }

    public new void Print()
    {
        base.Print();
        Write($"; Жанр книги: {this.Genre}");
    }
    public static void Print(BookGenre bookGenre)
    {
        bookGenre.Print();
    }
}
}