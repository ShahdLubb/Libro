using Microsoft.EntityFrameworkCore;
using Persistance.DBEntities;

namespace Persistance
{
    public class LibroDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
        public DbSet<Review> BookReviews { get; set; }
        public DbSet<ReadingList> ReadingLists { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Borrow> Borrowings { get; set; }
        public DbSet<CheckIn> CheckIns { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public LibroDbContext(DbContextOptions<LibroDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>()
                .Property(r => r.Rating)
                .HasColumnType("decimal(3,2)");

            modelBuilder.Entity<Genre>()
                .HasKey(g => g.GenreCode);

            base.OnModelCreating(modelBuilder);
        }

        }
}
