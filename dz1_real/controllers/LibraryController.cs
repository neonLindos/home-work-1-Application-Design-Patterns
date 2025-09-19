using System;
using dz1_real.models;
using dz1_real.repositories;
using static dz1_real.models.Models;

namespace dz1_real.Controllers
{
    public class LibraryController
    {
        private IBookRepository bookRepository;
        private ILibraryRepository libraryRepository;
        private IReaderRepository readerRepository;

        public LibraryController()
        {
            this.bookRepository = new BookRepository();
            this.libraryRepository = new LibraryRepository();
            this.readerRepository = new ReaderRepository() ;
        }

        public void AddBook(Book book)
        {
            bookRepository.addBook(book);
        }
        public void RemoveBook(Book book)
        {
            bookRepository.removeBook(book);
        }

        public void AddLibrary(Library library)
        {
            libraryRepository.addLibrary(library);
        }

        public void RegisterReader(Reader reader)
        {
            readerRepository.AddReader(reader);
        }

        public void ReturnBook(Book book, Reader reader)
        {
            Book book_ = bookRepository.findBookByID(book.ID);
            if (book_ != null)
            {
                book_.CurrentReader = null;
            }
        }

        public void TakeBook(Book book, Reader reader)
        {
            Book book_ = bookRepository.findBookByID(book.ID);
            if (book_ == null)
            {
                Console.WriteLine("Книга не найдена");
                return;
            }

            if (book_.CurrentReader == null)
            {
                book_.CurrentReader = reader;
            }
            else
            {
                Console.WriteLine("Книга уже на руках");
            }
        }


        public void ListBooks()
        {
            var books = bookRepository.getListBooks();
            Console.WriteLine($"Всего книг: {books.Count}");
            foreach (var book in books)
            {
                string status = book.CurrentReader == null
                    ? "В библиотеке"
                    : $"У читателя {book.CurrentReader.Name}";
                Console.WriteLine($"{book.ID}. {book.Title} — {status}");
            }
        }
    }
}
