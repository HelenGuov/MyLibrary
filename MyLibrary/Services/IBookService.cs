using MyLibrary.Models;

namespace MyLibrary.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAllAsync(); 
        Task<Book?> GetAsync(int id);
        Task<Book> AddAsync(Book entity);
        Task<Book> UpdateAsync(Book entity);
        Task<Book> DeleteAsync(int id);
    }
}
