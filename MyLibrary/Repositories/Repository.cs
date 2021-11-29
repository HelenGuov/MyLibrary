using Microsoft.EntityFrameworkCore;
using MyLibrary.Contracts;
using MyLibrary.Entities;

namespace MyLibrary.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly MyLibraryContext MyLibraryContext;

        public Repository(MyLibraryContext myLibraryContext)
        {
            MyLibraryContext = myLibraryContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                await MyLibraryContext.AddAsync(entity);
                await MyLibraryContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        public IQueryable<T> GetAll()
        {
            try
            {
                return MyLibraryContext.Set<T>(); 
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                MyLibraryContext.Update(entity);
                await MyLibraryContext.SaveChangesAsync(); 

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }

        public async Task<T> DeleteAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                MyLibraryContext.Remove(entity); 
                await MyLibraryContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be deleted: {ex.Message}");
            }
        }

    }
}
