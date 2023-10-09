using System;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium5.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Maksymalna długość 50 znaków" )]
        public string Title { get; set; }

        //[DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Opis jest wymagany")]
        [UIHint("LongText")]
        public string Description { get; set; }
        
        [UIHint("Stars")]
        [Range(0, 5, ErrorMessage = "Ocena filmu musi być liczbą pomiędzy 0 a 5" )]
        public int? Rating { get; set; }                // Nullable / Unrequired
        public string? TrailerLink { get; set; }        // Nullable / Unrequired

    }
}
