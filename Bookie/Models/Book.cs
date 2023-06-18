using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookie.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public int Rating { get; set; }
        public string Author { get; set; }
        public string ImageURL { get; set; }
        public int Price { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }

    }
}