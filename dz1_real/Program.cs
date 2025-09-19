

using dz1_real.Controllers;
using static dz1_real.models.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;


LibraryController libraryController = new LibraryController();



Library createLibrary(string Name)
{
    Library library = new Library(Name);
    libraryController.AddLibrary(library);

    return library;
}



Book createBook(string Title, string Author, string ISBN, Library library, int bookCount)
{
    Book book = new Book(Title, Author, ISBN, library, bookCount);
    libraryController.AddBook(book);

    return book;
}

Reader createReader(string Name)
{
    Reader reader = new Reader(Name);
    libraryController.RegisterReader(reader);
    return reader;
}


Library library = createLibrary("Библиотека");



createBook("Война и мир", "Лев Толстой", "978-5-17-118366-2", library, 30);
createBook("Преступление и наказание", "Фёдор Достоевский", "978-5-389-07454-4", library, 20);
createBook("Мастер и Маргарита", "Михаил Булгаков", "978-5-389-07455-1", library, 15);
createBook("Евгений Онегин", "Александр Пушкин", "978-5-389-07456-8", library, 25);
createBook("Мёртвые души", "Николай Гоголь", "978-5-389-07457-5", library, 18);
createBook("Отцы и дети", "Иван Тургенев", "978-5-389-07458-2", library, 12);
Book favorite_book = createBook("Доктор Живаго", "Борис Пастернак", "978-5-389-07459-9", library, 10);
Book delete_book = createBook("Белая гвардия", "Михаил Булгаков", "978-5-389-07460-5", library, 8);


libraryController.ListBooks();
libraryController.RemoveBook(delete_book);

libraryController.ListBooks();


Reader reader1 = createReader("Иван Иванов");
Reader reader2 = createReader("Карл Каралов");

libraryController.TakeBook(favorite_book, reader1);

libraryController.ListBooks();

