using System;
using System.Collections.Generic;
using static dz1_real.models.Models;

namespace dz1_real.repositories
{
   

    public class ReaderRepository : IReaderRepository
    {
        private readonly List<Reader> readers;

        public ReaderRepository()
        {
            readers = new List<Reader>();
        }

        public void AddReader(Reader reader)
        {
            reader.ID = readers.Count + 1;
            readers.Add(reader);
            Console.WriteLine($"Читатель {reader.Name} добавлен");
        }

        public List<Reader> GetAllReaders()
        {
            return readers;
        }

        public Reader getReaderByID(int id)
        {
            return readers.Find(reader => reader.ID == id);
        }
    }

    public interface IReaderRepository
    {
        void AddReader(Reader reader);
        Reader getReaderByID(int id);
        List<Reader> GetAllReaders();
    }
}
