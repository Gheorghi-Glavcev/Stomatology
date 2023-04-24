using Microsoft.EntityFrameworkCore;

namespace Stomatology.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {      
        }
    }
}
