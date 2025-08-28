using Microsoft.EntityFrameworkCore;

namespace MiLibreriaWebApp.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Country)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CountryId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Genre)
                .WithMany(g => g.Books)
                .HasForeignKey(b => b.GenreId)
                .OnDelete(DeleteBehavior.SetNull);

            // Seed 100 most populated countries (in English)
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "China" },
                new Country { Id = 2, Name = "India" },
                new Country { Id = 3, Name = "United States" },
                new Country { Id = 4, Name = "Indonesia" },
                new Country { Id = 5, Name = "Pakistan" },
                new Country { Id = 6, Name = "Nigeria" },
                new Country { Id = 7, Name = "Brazil" },
                new Country { Id = 8, Name = "Bangladesh" },
                new Country { Id = 9, Name = "Russia" },
                new Country { Id = 10, Name = "Mexico" },
                new Country { Id = 11, Name = "Japan" },
                new Country { Id = 12, Name = "Ethiopia" },
                new Country { Id = 13, Name = "Philippines" },
                new Country { Id = 14, Name = "Egypt" },
                new Country { Id = 15, Name = "Vietnam" },
                new Country { Id = 16, Name = "DR Congo" },
                new Country { Id = 17, Name = "Turkey" },
                new Country { Id = 18, Name = "Iran" },
                new Country { Id = 19, Name = "Germany" },
                new Country { Id = 20, Name = "Thailand" },
                new Country { Id = 21, Name = "United Kingdom" },
                new Country { Id = 22, Name = "France" },
                new Country { Id = 23, Name = "Italy" },
                new Country { Id = 24, Name = "Tanzania" },
                new Country { Id = 25, Name = "South Africa" },
                new Country { Id = 26, Name = "Myanmar" },
                new Country { Id = 27, Name = "South Korea" },
                new Country { Id = 28, Name = "Colombia" },
                new Country { Id = 29, Name = "Kenya" },
                new Country { Id = 30, Name = "Spain" },
                new Country { Id = 31, Name = "Argentina" },
                new Country { Id = 32, Name = "Algeria" },
                new Country { Id = 33, Name = "Sudan" },
                new Country { Id = 34, Name = "Ukraine" },
                new Country { Id = 35, Name = "Uganda" },
                new Country { Id = 36, Name = "Iraq" },
                new Country { Id = 37, Name = "Poland" },
                new Country { Id = 38, Name = "Canada" },
                new Country { Id = 39, Name = "Morocco" },
                new Country { Id = 40, Name = "Saudi Arabia" },
                new Country { Id = 41, Name = "Uzbekistan" },
                new Country { Id = 42, Name = "Peru" },
                new Country { Id = 43, Name = "Angola" },
                new Country { Id = 44, Name = "Malaysia" },
                new Country { Id = 45, Name = "Mozambique" },
                new Country { Id = 46, Name = "Ghana" },
                new Country { Id = 47, Name = "Yemen" },
                new Country { Id = 48, Name = "Nepal" },
                new Country { Id = 49, Name = "Venezuela" },
                new Country { Id = 50, Name = "Madagascar" },
                new Country { Id = 51, Name = "Cameroon" },
                new Country { Id = 52, Name = "Côte d'Ivoire" },
                new Country { Id = 53, Name = "North Korea" },
                new Country { Id = 54, Name = "Australia" },
                new Country { Id = 55, Name = "Niger" },
                new Country { Id = 56, Name = "Taiwan" },
                new Country { Id = 57, Name = "Sri Lanka" },
                new Country { Id = 58, Name = "Burkina Faso" },
                new Country { Id = 59, Name = "Mali" },
                new Country { Id = 60, Name = "Romania" },
                new Country { Id = 61, Name = "Malawi" },
                new Country { Id = 62, Name = "Chile" },
                new Country { Id = 63, Name = "Kazakhstan" },
                new Country { Id = 64, Name = "Zambia" },
                new Country { Id = 65, Name = "Guatemala" },
                new Country { Id = 66, Name = "Ecuador" },
                new Country { Id = 67, Name = "Syria" },
                new Country { Id = 68, Name = "Netherlands" },
                new Country { Id = 69, Name = "Senegal" },
                new Country { Id = 70, Name = "Cambodia" },
                new Country { Id = 71, Name = "Chad" },
                new Country { Id = 72, Name = "Somalia" },
                new Country { Id = 73, Name = "Zimbabwe" },
                new Country { Id = 74, Name = "Guinea" },
                new Country { Id = 75, Name = "Rwanda" },
                new Country { Id = 76, Name = "Benin" },
                new Country { Id = 77, Name = "Burundi" },
                new Country { Id = 78, Name = "Tunisia" },
                new Country { Id = 79, Name = "Bolivia" },
                new Country { Id = 80, Name = "Belgium" },
                new Country { Id = 81, Name = "Haiti" },
                new Country { Id = 82, Name = "Cuba" },
                new Country { Id = 83, Name = "South Sudan" },
                new Country { Id = 84, Name = "Dominican Republic" },
                new Country { Id = 85, Name = "Czech Republic" },
                new Country { Id = 86, Name = "Greece" },
                new Country { Id = 87, Name = "Jordan" },
                new Country { Id = 88, Name = "Portugal" },
                new Country { Id = 89, Name = "Azerbaijan" },
                new Country { Id = 90, Name = "Sweden" },
                new Country { Id = 91, Name = "Honduras" },
                new Country { Id = 92, Name = "United Arab Emirates" },
                new Country { Id = 93, Name = "Hungary" },
                new Country { Id = 94, Name = "Tajikistan" },
                new Country { Id = 95, Name = "Belarus" },
                new Country { Id = 96, Name = "Austria" },
                new Country { Id = 97, Name = "Papua New Guinea" },
                new Country { Id = 98, Name = "Serbia" },
                new Country { Id = 99, Name = "Israel" },
                new Country { Id = 100, Name = "Switzerland" }
            );

            // Seed common genres (including essay categories)
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Fiction" },
                new Genre { Id = 2, Name = "Non-Fiction" },
                new Genre { Id = 3, Name = "Mystery" },
                new Genre { Id = 4, Name = "Fantasy" },
                new Genre { Id = 5, Name = "Science Fiction" },
                new Genre { Id = 6, Name = "Biography" },
                new Genre { Id = 7, Name = "Romance" },
                new Genre { Id = 8, Name = "Thriller" },
                new Genre { Id = 9, Name = "Historical" },
                new Genre { Id = 10, Name = "Children" },
                new Genre { Id = 11, Name = "Young Adult" },
                new Genre { Id = 12, Name = "Horror" },
                new Genre { Id = 13, Name = "Poetry" },
                new Genre { Id = 14, Name = "Adventure" },
                new Genre { Id = 15, Name = "Graphic Novel" },
                new Genre { Id = 16, Name = "Classic" },
                new Genre { Id = 17, Name = "Short Story" },
                new Genre { Id = 18, Name = "Memoir" },
                new Genre { Id = 19, Name = "Self-Help" },
                new Genre { Id = 20, Name = "Essay" },
                new Genre { Id = 21, Name = "Critical Essay" },
                new Genre { Id = 22, Name = "Literary Essay" },
                new Genre { Id = 23, Name = "Philosophical Essay" },
                new Genre { Id = 24, Name = "Scientific Essay" },
                new Genre { Id = 25, Name = "Political Essay" },
                new Genre { Id = 26, Name = "Travel Essay" },
                new Genre { Id = 27, Name = "Personal Essay" },
                new Genre { Id = 28, Name = "Journalism" },
                new Genre { Id = 29, Name = "Religion" },
                new Genre { Id = 30, Name = "Cookbook" }
            );
            // Seed read books
                modelBuilder.Entity<Book>().HasData(
                    new Book { Id = 1, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", CountryId = 9, GenreId = 1, ISBN = "9780140449136", ReadingStatus = ReadingStatus.Finished },
                    new Book { Id = 2, Title = "A Confederacy of Dunces", Author = "John Kennedy Toole", CountryId = 3, GenreId = 1, ISBN = "9788433971802", ReadingStatus = ReadingStatus.Finished },
                    new Book { Id = 3, Title = "The Leopard", Author = "Giuseppe Tomasi di Lampedusa", CountryId = 23, GenreId = 9, ISBN = "9788435008910", ReadingStatus = ReadingStatus.Finished },
                    new Book { Id = 4, Title = "Sapiens", Author = "Yuval Noah Harari", CountryId = 99, GenreId = 2, ISBN = "9780062316097", ReadingStatus = ReadingStatus.Finished },
                    new Book { Id = 5, Title = "The Magic Mountain", Author = "Thomas Mann", CountryId = 19, GenreId = 1, ISBN = "9788499893466", ReadingStatus = ReadingStatus.Finished },
                    new Book { Id = 6, Title = "The Phantom of the Opera", Author = "Gaston Leroux", CountryId = 22, GenreId = 1, ISBN = "9780141191508", ReadingStatus = ReadingStatus.Finished },
                    new Book { Id = 7, Title = "The Invisible Man", Author = "H.G. Wells", CountryId = 21, GenreId = 5, ISBN = "9780141439983", ReadingStatus = ReadingStatus.Finished },
                    new Book { Id = 8, Title = "Frankenstein", Author = "Mary Shelley", CountryId = 21, GenreId = 5, ISBN = "9780141439471", ReadingStatus = ReadingStatus.Finished },
                    new Book { Id = 9, Title = "Treasure Island", Author = "Robert Louis Stevenson", CountryId = 21, GenreId = 14, ISBN = "9780141439822", ReadingStatus = ReadingStatus.Finished },
                    new Book { Id = 10, Title = "Reflections on the Revolution in France", Author = "Edmund Burke", CountryId = 21, GenreId = 20, ISBN = "9788498791749", ReadingStatus = ReadingStatus.Finished },
                    new Book { Id = 11, Title = "Imperiofobia", Author = "María Elvira Roca Barea", CountryId = 30, GenreId = 20, ISBN = "9788491640686", ReadingStatus = ReadingStatus.Finished },
                    new Book { Id = 12, Title = "Animal Farm", Author = "George Orwell", CountryId = 21, GenreId = 1, ISBN = "9788499890946", ReadingStatus = ReadingStatus.Finished },
                    new Book { Id = 13, Title = "1984", Author = "George Orwell", CountryId = 21, GenreId = 1, ISBN = "9788499890946", ReadingStatus = ReadingStatus.Finished },
                    new Book { Id = 14, Title = "Blindness", Author = "José Saramago", CountryId = 88, GenreId = 1, ISBN = "9788466368066", ReadingStatus = ReadingStatus.Finished },
                    new Book { Id = 15, Title = "Why Nations Fail", Author = "Daron Acemoglu, James A. Robinson", CountryId = 3, GenreId = 2, ISBN = "9780307719225", ReadingStatus = ReadingStatus.Finished }
                );
        }
    }
}
