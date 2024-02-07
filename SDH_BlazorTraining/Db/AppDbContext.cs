using Microsoft.EntityFrameworkCore;
using SDH_BlazorTraining.Models;

namespace SDH_BlazorTraining.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<BlogDataModel> Blogs { get; set; }
    }
}
