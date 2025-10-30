using System.ComponentModel.DataAnnotations.Schema;

namespace Betting_Boys_V2.Server.Models
{
    [Table("receiving_stats")]
    public class ReceivingStats
    {
            [Column("season")]
            public string? Season { get; set; }
            [Column("week")]
            public string? Week { get; set; }
            [Column("player_display_name")]
            public string? PlayerName { get; set; }
            [Column("player_position")]
            public string? PlayerPosition { get; set; }
            [Column("team_abbr")]
            public string? Team { get; set; }
            [Column("avg_cushion")]
            public string? AvgCushion { get; set; }
            [Column("avg_separation")]
            public string? AvgSeparation { get; set; }
            [Column("receptions")]
            public string? Receptions { get; set; }
            [Column("targets")]
            public string? Targets { get; set; }
            [Column("catch_percentage")]
            public string? CatchPercent { get; set; }
            [Column("yards")]
            public string? Yards { get; set; }
            [Column("rec_touchdowns")]
            public string? RecTDs { get; set; }
            [Column("avg_yac")]
            public string? AvgYac { get; set; }
            [Column("player_gsis_id")]
            public string? PlayerId { get; set; }
            [Column("player_jersey_number")]
            public string? PlayerNumber { get; set; }
        }
}
