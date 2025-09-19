using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static dz1_real.models.Models;

namespace dz1_real.repositories
{
    public class LibraryRepository : ILibraryRepository
    {
        private List<Library> libraries;

        public LibraryRepository()
        {
            libraries = new List<Library>();
        }

        public void addLibrary(Library library)
        {
            library.ID = libraries.Count + 1;
            libraries.Add(library);

        }

        public Library getLibraryById(int id)
        {
            return libraries.First(library => library.ID == id);
        }

        public Library getLibraryByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Library> listLibraries()
        {
            throw new NotImplementedException();
        }
    }

    interface ILibraryRepository
    {
        void addLibrary(Library library);
        Library getLibraryByID(int id);
        List<Library> listLibraries();
    }
}
