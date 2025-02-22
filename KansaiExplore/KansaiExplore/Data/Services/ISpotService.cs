namespace KansaiExplore.Data.Services
{
    public interface ISpotService
    {
        Task AddSpot(SpotDbContext.NicheSpotData spotData);
    }
}
