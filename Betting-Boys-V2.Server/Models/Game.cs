using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Betting_Boys_V2.Server.Models
{
    [Table("week_odds")]
    public class Game
    {
        [Column("id")]
        public string? Id { get; set; }
        [Column("commence_time")]
        public string? CommenceTime { get; set; }
        [Column("home_team")]
        public string? HomeTeam { get; set; }
        [Column("away_team")]
        public string? AwayTeam { get; set; }
        [Column("week")]
        public string? Week { get; set; }
        [Column("player_props")]
        public JsonDocument? PropBets { get; set; }

    }
}
