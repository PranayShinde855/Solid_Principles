using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Database
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<UserLogin> UserLogin { get; set; }
    }
}
