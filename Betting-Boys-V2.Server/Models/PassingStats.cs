using System.ComponentModel.DataAnnotations.Schema;

namespace Betting_Boys_V2.Server.Models
{
    [Table("passing_stats")]
    public class PassingStats
    {
        [Column("season")]
        public string? Season { get; set; }
        [Column("week")]
        public string? Week { get; set; }
        [Column("player_display_name")]
        public string? PlayerName { get; set; }
        [Column("team_abbr")]
        public string? Team{ get; set; }
        [Column("avg_time_to_throw")]
        public string? AvgTimeToThrow { get; set; }
        [Column("avg_completed_air_yards")]
        public string? AvgCompletedAirYards { get; set; }
        [Column("max_completed_air_distance")]
        public string? MaxCompAirDistance { get; set; }
        [Column("attempts")]
        public string? Attempts { get; set; }
        [Column("pass_yards")]
        public string? PassYards { get; set; }
        [Column("pass_touchdowns")]
        public string? PassTDs { get; set; }
        [Column("interceptions")]
        public string? Interceptions { get; set; }
        [Column("passer_rating")]
        public string? PasserRating { get; set; }
        [Column("completions")]
        public string? Completions { get; set; }
        [Column("completion_percentage")]
        public string? CompletionPercent { get; set; }
        [Column("avg_air_distance")]
        public string? AvgAirDistance { get; set; }
        [Column("max_air_distance")]
        public string? MaxAirDistance { get; set; }
        [Column("player_gsis_id")]
        public string? PlayerId { get; set; }
        [Column("player_jersey_number")]
        public string? PlayerNumber { get; set; }
    }
}
