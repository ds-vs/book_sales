using book_sales.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace book_sales.DAL
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    
        public DbSet<Book> Book { get; set; }
    }
}

