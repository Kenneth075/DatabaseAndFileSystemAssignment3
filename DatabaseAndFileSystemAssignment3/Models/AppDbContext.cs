using Microsoft.EntityFrameworkCore;

namespace DatabaseAndFileSystemAssignment3.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<GallaryItems> Kenneths { get; set; }
    }
}
