using System;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium5.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        
        [Required]
        //[DataType(DataType.MultilineText)]
        [UIHint("LongText")]
        public string Description { get; set; }
        
        [UIHint("Stars")]
        [Range(0,5)]
        public int? Rating { get; set; }                // Nullable / Unrequired
        public string? TrailerLink { get; set; }        // Nullable / Unrequired

    }
}
