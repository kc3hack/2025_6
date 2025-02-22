
namespace KansaiExplore.Data.Services
{
    public class SpotService : ISpotService
    {
        private readonly SpotDbContext _context;
        public SpotService(SpotDbContext context)
        {
            _context = context;
        }

        public async Task AddSpot(SpotDbContext.NicheSpotData spotData)
        {
            _context.NicheSpots.Add(spotData);
        }
    }
}
