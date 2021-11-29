using Microsoft.EntityFrameworkCore;
using MyLibrary.Contracts;
using MyLibrary.Models;

namespace MyLibrary.Services
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> _bookRepository;

        public BookService(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Task<List<Book>> GetAllAsync()
        {
            return _bookRepository.GetAll().ToListAsync(); 
        }

        public Task<Book?> GetAsync(int id)
        {
            return _bookRepository.GetAll().Where(x => x.BookId == id).FirstOrDefaultAsync();  
        }

        public async Task<Book> AddAsync(Book book)
        {
            return await _bookRepository.AddAsync(book); 
        }

        public async Task<Book> UpdateAsync(Book entity)
        {
            return await _bookRepository.UpdateAsync(entity);
        }



        public async Task<Book> DeleteAsync(int id)
        {
            var book = await GetAsync(id); 
            return await _bookRepository.DeleteAsync(book);
        }
    }
}
