using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace API.Models
{
    public class CategoryContext : DbContext
    {
        public CategoryContext(DbContextOptions<CategoryContext> options)
            : base(options)
        {

        }
        public DbSet<Category> categogies { get; set; }
    }
}
