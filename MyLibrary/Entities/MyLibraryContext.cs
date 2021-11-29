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

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; } 

    }
}

