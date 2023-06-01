using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace my_books.Model
{
    public class AppDBContext:DbContext
    {
        

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Author>()
                .HasOne(b => b.Book)
                .WithMany(ba => ba.book_authors)
                .HasForeignKey(bi => bi.bookId);


            modelBuilder.Entity<Book_Author>()
                .HasOne(a => a.Author)
                .WithMany(ba => ba.book_authors)
                .HasForeignKey(ai => ai.authorId);
        }

        public DbSet<Book> Books { get; set;}

        public DbSet<Author> Authors{ get; set; }

        public DbSet<Publisher> Publisher { get; set; }

        public DbSet<Book_Author> Book_Authors{ get; set; }


    }
}
