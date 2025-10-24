using System.ComponentModel.DataAnnotations.Schema;

namespace Betting_Boys_V2.Server.Models
{
    [Table("receiving_stats")]
    public class ReceivingStats
    {
            [Column("season")]
            public int Season { get; set; }
            [Column("week")]
            public int Week { get; set; }
            [Column("player_display_name")]
            public string? PlayerName { get; set; }
            [Column("player_position")]
            public string? PlayerPosition { get; set; }
            [Column("team_abbr")]
            public string? Team { get; set; }
            [Column("avg_cushion")]
            public double? AvgCushion { get; set; }
            [Column("avg_separation")]
            public double? AvgSeparation { get; set; }
            [Column("receptions")]
            public int Receptions{ get; set; }
            [Column("targets")]
            public int Targets { get; set; }
            [Column("catch_percentage")]
            public double CatchPercent { get; set; }
            [Column("yards")]
            public int Yards { get; set; }
            [Column("rec_touchdowns")]
            public int RecTDs { get; set; }
            [Column("avg_yac")]
            public double AvgYac{ get; set; }
            [Column("player_gsis_id")]
            public string? PlayerId { get; set; }
            [Column("player_jersey_number")]
            public int PlayerNumber { get; set; }
        }
}
