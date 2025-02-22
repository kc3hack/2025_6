using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KansaiExplore.Data.Shared
{
    public class NicheSpot
    {
        [Key]
        public Guid Id { get; set; }
        public string SpotName { get; set; }
        public string SpotDescription { get; set; }
        public Guid CreatedBy { get; set; }
        public string Choordinates { get; set; }
        public string MediaUrl { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
