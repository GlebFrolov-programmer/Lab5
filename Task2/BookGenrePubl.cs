using bookGenre;

namespace bookGenrePubl
{
public sealed class BookGenrePubl : BookGenre
{
    private string publisher; // издатель

    public BookGenrePubl(string title, string genre, string author, string publisher, float price)
        : base(title, genre, author, price)
    {
        Publisher = publisher;
    }
    public string Publisher
    {
        get
        {
            return publisher;
        }
        set
        {
            publisher = (value == null ? string.Empty : value);
        }
    }
    public new void Print()
    {
        base.Print();
        Console.WriteLine($"; Издательство: {Publisher}");
    }
    public static void Print(BookGenrePubl bookGenrePubl)
    {
        bookGenrePubl.Print();
    }
}
}