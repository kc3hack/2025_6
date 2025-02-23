using KansaiExplore.Data.Shared;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
namespace KansaiExplore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NicheSpot>()
                .HasData(new NicheSpot
                {
                    Id = Guid.NewGuid(),
                    Choordinates = "13333,1111",
                    CreatedAt = DateTime.Now,
                    CreatedBy = Guid.NewGuid(),
                    MediaUrl = "example.com",
                    SpotDescription = "てすとだよ",
                    SpotName = "Test"
                });
        }
        public DbSet<NicheSpot> kansaispot { get; set; }
    }
}
