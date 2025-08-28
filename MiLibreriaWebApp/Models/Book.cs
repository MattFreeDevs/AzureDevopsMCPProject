using System.ComponentModel.DataAnnotations;

namespace MiLibreriaWebApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public int CountryId { get; set; }
    public Country? Country { get; set; }

        public int GenreId { get; set; }
    public Genre? Genre { get; set; }

    public string? ISBN { get; set; }

        public ReadingStatus ReadingStatus { get; set; }
    }
}
