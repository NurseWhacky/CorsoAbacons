
using Microsoft.EntityFrameworkCore;
using Model;

namespace Repository
{
    public class DataContext : DbContext
    {
        private string connectionString;
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        // to manage different connection strings/users/ roles etc etc (just an example)
        // connection strings should be stored safely, NOT like this!!!
        public DataContext() 
        {
            connectionString = @"Data source=ABAS110\KOS; User id=sa; Password=12345; Database=AbaconsLibrary; trustservercertificate=true";
        }

        public DataContext(string connectionString)
        {
            this.connectionString = connectionString ?? @"Data source=ABAS110\KOS; User id=sa; Password=12345; Database=AbaconsLibrary; trustservercertificate=true";
        }

        // override 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }
    }
}

