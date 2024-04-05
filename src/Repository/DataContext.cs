
using Microsoft.EntityFrameworkCore;
using Model;

namespace Repository
{
    public class DataContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=ABAS110\KOS; User id=sa; Password=12345; Database=AbaconsLibrary; trustservercertificate=true");
        }
    }
}

