using KansaiExplore.Data.Shared;

namespace KansaiExplore.Services
{
    public interface INearSpots
    {
        public IEnumerable<NicheSpot> GetNearSpots(double latitude, double longitude);
    }
}
