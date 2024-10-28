using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace Libraries.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext>options) : base(options) { }


        public DbSet<Book> Books { get; set; }
    }
}
