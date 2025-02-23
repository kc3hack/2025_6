using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KansaiExplore.Data.Shared
{
    [Table("kansaispot")]
    public class NicheSpot
    {
        [Key]
        public Guid Id { get; set; }
        [Column("spot_name")]
        public string SpotName { get; set; }
        [Column("spot_description")]
        public string SpotDescription { get; set; }
        [Column("created_by")]
        public Guid CreatedBy { get; set; }
        [Column("choordinates")]
        public string Choordinates { get; set; }
        [Column("media_url")]
        public string MediaUrl { get; set; }
        [Column("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        [Column("latitude")]
        public double Latitude { get; set; }
        [Column("longitude")]
        public double Longitude { get; set; }
        [Column("valuation")]
        public string Valuation { get; set; }
    }
}
