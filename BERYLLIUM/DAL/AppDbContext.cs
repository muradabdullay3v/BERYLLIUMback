using BERYLLIUM.Models;
using Microsoft.EntityFrameworkCore;

namespace BERYLLIUM.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Work> Works { get; set; }
    }
}
