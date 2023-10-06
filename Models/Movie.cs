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
        public string Description { get; set; }
        // Nullable / Unrequired
        public int? Rating { get; set; }
        // Nullable / Unrequired
        public string? TrailerLink { get; set; }
    }
}
