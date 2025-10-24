using System.ComponentModel.DataAnnotations.Schema;

namespace Betting_Boys_V2.Server.Models
{
    [Table("passing_stats")]
    public class PassingStats
    {
        [Column("season")]
        public int Season { get; set; }
        [Column("week")]
        public int Week { get; set; }
        [Column("player_display_name")]
        public string? PlayerName { get; set; }
        [Column("team_abbr")]
        public string? Team{ get; set; }
        [Column("avg_time_to_throw")]
        public double? AvgTimeToThrow { get; set; }
        [Column("avg_completed_air_yards")]
        public double? AvgCompletedAirYards { get; set; }
        [Column("max_completed_air_distance")]
        public double? MaxCompAirDistance { get; set; }
        [Column("attemps")]
        public int Attempts { get; set; }
        [Column("pass_yards")]
        public int PassYards { get; set; }
        [Column("pass_touchdowns")]
        public int PassTDs { get; set; }
        [Column("interceptions")]
        public int Interceptions { get; set; }
        [Column("passer_rating")]
        public double PasserRating { get; set; }
        [Column("completions")]
        public int Completions { get; set; }
        [Column("completion_percentage")]
        public double CompletionPercent { get; set; }
        [Column("avg_air_distance")]
        public double AvgAirDistance { get; set; }
        [Column("max_air_distance")]
        public double MaxAirDistance { get; set; }
        [Column("player_gsis_id")]
        public string? PlayerId { get; set; }
        [Column("player_jersey_number")]
        public int PlayerNumber { get; set; }
    }
}
