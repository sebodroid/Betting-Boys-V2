using Microsoft.EntityFrameworkCore;
using Betting_Boys_V2.Server.Models;

namespace Betting_Boys_V2.Server
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<PassingStats> PassingStats { get; set; }
        public DbSet<ReceivingStats> ReceivingStats { get; set; }
        public DbSet<RushingStats> RushingStats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PassingStats>()
                .HasKey(p => new { p.PlayerId, p.Season, p.Week });

            modelBuilder.Entity<ReceivingStats>()
                .HasKey(p => new { p.PlayerId, p.Season, p.Week });

            modelBuilder.Entity<RushingStats>()
               .HasKey(p => new { p.PlayerId, p.Season, p.Week });
        }
    }
}
