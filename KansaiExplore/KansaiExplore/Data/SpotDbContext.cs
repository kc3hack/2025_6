using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace KansaiExplore.Data
{
    public class SpotDbContext : DbContext
    {
        public DbSet<NicheSpotData> NicheSpots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;ConnectRetryCount=0");
            base.OnConfiguring(optionsBuilder);
        }
        public class NicheSpotData
        {
            [Key]
            public Guid Id { get; set; }
            public string SpotName { get; set; }
            public string SpotDescription { get; set; }
            public Guid CreatedBy { get; set; }
            public string Choordinates{ get; set; }
            public string MediaUrl { get; set; }
            public DateTime CreatedAt { get; set; }
        }
    }
}
