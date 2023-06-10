using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; } = string.Empty;
        public string? Author { get; set; } = string.Empty;
        public string? Genre { get; set; } = string.Empty;

        [Display(Name = "Price (Euro)")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Rating (0-10)")]
        public int Rating { get; set; }
    }

}
