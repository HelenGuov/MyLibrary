using Microsoft.EntityFrameworkCore;
using MyLibrary.Models;

namespace MyLibrary.Entities
{
    public class MyLibraryContext : DbContext
    {
        public MyLibraryContext(DbContextOptions<MyLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;

    }
}

