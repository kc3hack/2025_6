using KansaiExplore.Data;
using KansaiExplore.Data.Shared;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace KansaiExplore.Services
{
    public class NearSpots : INearSpots
    {

        private readonly DataContext context;
        public NearSpots(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<NicheSpot> GetNearSpots(double latitude, double longitude)
        {
            var db = context.kansaispot;
            IEnumerable<NicheSpot> spots = db.Where(d => d.Longitude > longitude - 0.03).Where(d => d.Longitude < longitude + 0.03)
                .Where(d => d.Latitude > latitude - 0.03).Where(d => d.Latitude < latitude + 0.03);
            return spots;
        }
    }
}
