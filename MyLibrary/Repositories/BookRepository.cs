using MyLibrary.Contracts;
using MyLibrary.Entities;
using MyLibrary.Models;

namespace MyLibrary.Repositories
{
    public class BookRepository : Repository<Book>
    {
        public BookRepository(MyLibraryContext myLibraryContext) : base(myLibraryContext)
        {
        }
    }
}
