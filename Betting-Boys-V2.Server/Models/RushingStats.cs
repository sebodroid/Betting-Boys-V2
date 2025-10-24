using System.ComponentModel.DataAnnotations.Schema;

namespace Betting_Boys_V2.Server.Models
{
    [Table("rushing_stats")]
    public class RushingStats
    {
        [Column("season")]
        public int Season { get; set; }
        [Column("week")]
        public int Week { get; set; }
        [Column("player_display_name")]
        public string? PlayerName { get; set; }
        [Column("team_abbr")]
        public string? Team { get; set; }
        [Column("efficiency")]
        public double Efficiency { get; set; }
        [Column("rush_attempts")]
        public int RushAttempts { get; set; }
        [Column("rush_yards")]
        public int RushYards { get; set; }
        [Column("avg_rush_yards")]
        public double AvgRushYards { get; set; }
        [Column("rush_touchdowns")]
        public int RushTDs { get; set; }
        [Column("expected_rush_yards")]
        public double ExpRushYards { get; set; }
        [Column("rush_yards_over_expected")]
        public double RushYardsOverExp { get; set; }
        [Column("rush_yards_over_expected_per_att")]
        public double RushYardsOverExpPerAtt { get; set; }
        [Column("rush_pct_over_expected")]
        public double RushPctOverExp { get; set; }
        [Column("player_gsis_id")]
        public string? PlayerId { get; set; }
        [Column("player_jersey_number")]
        public int PlayerNumber { get; set; }
    }
}
