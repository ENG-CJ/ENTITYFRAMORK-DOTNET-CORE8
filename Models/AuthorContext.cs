using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace Libraries.Models
{
    public class AuthorContext : DbContext
    {
        public AuthorContext(DbContextOptions<AuthorContext> options) : base(options) { }


        public DbSet<Author> Authors { get; set; }
 
    }
}
