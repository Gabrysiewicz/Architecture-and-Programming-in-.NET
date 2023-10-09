using System;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium5.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
