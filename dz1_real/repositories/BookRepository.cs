using static dz1_real.models.Models;

namespace dz1_real.repositories
{
    public class BookRepository : IBookRepository
    {
        private List<Book> books;


        public BookRepository()
        {
            books = new List<Book>();
        }

        public void addBook(Book book)
        {
            book.ID = books.Count + 1;
            books.Add(book);
            Console.WriteLine("Книга добавлена");
        }

        public void removeBook(Book book)
        {
            books.Remove(book);
            Console.WriteLine("Книга удалена");
        }

        public List<Book> getListBooks()
        {
            return books;
        }

        public Book findBookByID(int ID)
        {
            return books.Find(book => book.ID == ID);
        }




    }

    public interface IBookRepository
    {
        void addBook(Book book);
        void removeBook(Book book);
        Book findBookByID(int ID);
        List<Book> getListBooks();
    }
}
