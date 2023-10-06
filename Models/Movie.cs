using System;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium5.Models
{
    public class Movie
    {
        [Key]
        private int Id;
        private string Title;
        private string Description;
        private int Rating;
        private string TrailerLink;
    }
}
