using book;
using bookGenre;
using bookGenrePubl;

Console.WriteLine("Class Book:");
Book book = new("Война и мир", "Лев Толстой", 5000);
book.Print();
Console.WriteLine();

Console.WriteLine("Class BookGenre:");
BookGenre bookGenre = new("Мертвые души", "Роман", "Николай Гоголь", 400);
bookGenre.Print();
Console.WriteLine();

Console.WriteLine("Class BookGenrePubl:");
BookGenrePubl bookGenrePubl = new("Стив Джобс", "Биография", "Уолтер Айзексон", "Simon & Schuster", 840);
bookGenrePubl.Print();