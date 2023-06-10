using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }

        [Display(Name = "Price (Euro)")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }

}
