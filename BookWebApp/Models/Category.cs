using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApp.Models
{
    
    public class Category
    {
        public string NameToken { get; set; }
        [Key]
        public int type { get; set; }
        public string Description { get; set; }
    }
}
