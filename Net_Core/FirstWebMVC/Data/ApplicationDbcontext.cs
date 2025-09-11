using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models; // nhớ import namespace chứa Person

namespace FirstWebMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Thêm DbSet cho Person
        public DbSet<Person> Person { get; set; }
    }
}
