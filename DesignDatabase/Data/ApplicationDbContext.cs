using DesignDatabase.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignDatabase.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<House> Houses { get; set; }
        public DbSet<CrawlerThread> CrawlerThreads { get; set; }
        public DbSet<GetUrlTask> GetUrlTasks { get; set; }
        public DbSet<WaitingURL> waitingURLs { get; set; }
    }
}