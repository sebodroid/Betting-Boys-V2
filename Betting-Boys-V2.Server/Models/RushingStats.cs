using System.ComponentModel.DataAnnotations.Schema;

namespace Betting_Boys_V2.Server.Models
{
    [Table("rushing_stats")]
    public class RushingStats
    {
        [Column("season")]
        public string? Season { get; set; }
        [Column("week")]
        public string? Week { get; set; }
        [Column("player_display_name")]
        public string? PlayerName { get; set; }
        [Column("team_abbr")]
        public string? Team { get; set; }
        [Column("efficiency")]
        public string? Efficiency { get; set; }
        [Column("rush_attempts")]
        public string? RushAttempts { get; set; }
        [Column("rush_yards")]
        public string? RushYards { get; set; }
        [Column("avg_rush_yards")]
        public string? AvgRushYards { get; set; }
        [Column("rush_touchdowns")]
        public string? RushTDs { get; set; }
        [Column("expected_rush_yards")]
        public string? ExpRushYards { get; set; }
        [Column("rush_yards_over_expected")]
        public string? RushYardsOverExp { get; set; }
        [Column("rush_yards_over_expected_per_att")]
        public string? RushYardsOverExpPerAtt { get; set; }
        [Column("rush_pct_over_expected")]
        public string? RushPctOverExp { get; set; }
        [Column("player_gsis_id")]
        public string? PlayerId { get; set; }
        [Column("player_jersey_number")]
        public string? PlayerNumber { get; set; }
    }
}
