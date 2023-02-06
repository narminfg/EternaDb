using EternaDb.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaDb.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Pricing>Pricings  { get; set; }
        public DbSet<Service>Services  { get; set; }
        public DbSet<PricingService> PricingServices { get; set; }
        public DbSet<Team> teams { get; set; }

    }
}
