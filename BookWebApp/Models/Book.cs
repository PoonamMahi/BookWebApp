using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApp.Models
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        [Key]
        public int Category { get; set; }
        public string Author { get; set; }
    }
}
