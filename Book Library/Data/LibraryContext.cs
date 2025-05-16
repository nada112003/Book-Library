using Microsoft.EntityFrameworkCore;
using Smart_Tutor.Models;

namespace Smart_Tutor.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Sample data
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Genre = "Fiction",
                    PublishDate = new DateTime(1925, 4, 10),
                    Description = "A story of the fabulously wealthy Jay Gatsby and his love for the beautiful Daisy Buchanan."
                },
                new Book
                {
                    Id = 2,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Genre = "Fiction",
                    PublishDate = new DateTime(1960, 7, 11),
                    Description = "The story of racial injustice and the loss of innocence in the American South."
                }
            );
        }
    }
} 