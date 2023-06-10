using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; } = string.Empty;

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Author { get; set; } = string.Empty;

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; } = string.Empty;

        [Display(Name = "Price")]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Rating (0-10)")]
        [Column(TypeName = "int")]
        [Range(0, 10)]
        [Required]
        public int Rating { get; set; }
    }

}
