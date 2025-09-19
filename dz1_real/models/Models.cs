using System;
using System.Collections.Generic;

namespace dz1_real.models
{
    public class Models
    {
        public class Book
        {
            public int ID;
            public string Title { get; set; }
            public string Author { get; set; }

            // международный стандартный книжный номер
            public string ISBN { get; set; }
            public int bookCount { get; set; }

            // принадлежность книги библиотеке
            public Library OwnerLibrary { get; set; }

            // текущий читатель, если null - книга в библиотеке
            public Reader CurrentReader { get; set; }

            public Book(string title, string author, string isbn, Library library,int bookCount)
            {
                Title = title;
                Author = author;
                ISBN = isbn;
                OwnerLibrary = library;
                CurrentReader = null;
                this.bookCount = bookCount;
            }
        }

        public class Reader
        {
            public string Name { get; set; }
            public int ID { get; set; }

            public Reader(string name)
            {
                Name = name;
            }

           
        }

        public class Library
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public Library(string Name)
            {
                this.Name = Name;
            }

           
           
        }
    }
}
