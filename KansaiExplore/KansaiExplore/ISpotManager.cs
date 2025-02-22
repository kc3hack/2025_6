using KansaiExplore.Data;

namespace KansaiExplore
{
    public interface ISpotManager
    {
        Task AddSpotAsync(SpotDbContext.NicheSpotData spotData);
        Task<SpotDbContext.NicheSpotData> GetSpotWithId(Guid guid);
    }
}
