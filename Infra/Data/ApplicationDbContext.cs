using Microsoft.EntityFrameworkCore;
using Core.entities;  // Bu satırı eklediğinizden emin olun

namespace Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().ToTable("Countries").HasKey(c => c.CountryCode);
            modelBuilder.Entity<City>().ToTable("Cities").HasKey(c => c.CityId);
            modelBuilder.Entity<District>().ToTable("Districts").HasKey(d => d.DistrictId);

            modelBuilder.Entity<City>()
                .HasOne(c => c.Country)
                .WithMany(c => c.Cities)
                .HasForeignKey(c => c.CountryCode);

            modelBuilder.Entity<District>()
                .HasOne(d => d.City)
                .WithMany(c => c.Districts)
                .HasForeignKey(d => d.CityId);
        }
    }
}
