using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApp.Models
{
    [Keyless]
    public class Category
    {
        public string NameToken { get; set; }
        public int type { get; set; }
        public string Description { get; set; }
    }
}
