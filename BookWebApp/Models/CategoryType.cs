using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApp.Models
{
    [Keyless]
    public class CategoryType
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }
}
