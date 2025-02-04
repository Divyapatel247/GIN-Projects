using Microsoft.EntityFrameworkCore;
using api.Models;  // ✅ Ensure you include this to recognize Stock and Comment

namespace api.Data
{
    public class ApplicationDbContext : DbContext  // ✅ Check class name (case-sensitive)
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
