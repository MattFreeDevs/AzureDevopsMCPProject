using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MiLibreriaWebApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
