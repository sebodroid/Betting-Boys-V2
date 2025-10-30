using static System.Net.WebRequestMethods;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting_Boys_V2.Server.Models
{
    [Table("nfl_games")]
    public class NflSchedule
    {
        [Column("game_id")]
        public string? GameId { set; get; }
        [Column("season")]
        public string? Season { set; get; }
        [Column("game_type")]
        public string? GameType { set; get; }
        [Column("week")]
        public string? Week { set; get; }
        [Column("gameday")]
        public string? Gameday { set; get; }
        [Column("weekday")]
        public string? Weekday { set; get; }
        [Column("gametime")]
        public string? GameTime { set; get; }
        [Column("away_team")]
        public string? AwayTeam { set; get; }
        [Column("away_score")]
        public string? AwayScore { set; get; }
        [Column("home_team")]
        public string? HomeTeam { set; get; }
        [Column("home_score")]
        public string? HomeScore { set; get; }
        [Column("location")]
        public string? Location { set; get; }
        [Column("result")]
        public string? Result { set; get; }
        [Column("total")]
        public string? Total { set; get; }
        [Column("overtime")]
        public string? Overtime { set; get; }
        [Column("old_game_id")]
        public string? OldGameId { set; get; }
        [Column("gsis")]
        public string? Gsis { set; get; }
        [Column("pfr")]
        public string? Pfr { set; get; }
        [Column("pff")]
        public string? Pff { set; get; }
        [Column("espn")]
        public string? Espn { set; get; }
        [Column("ftn")]
        public string? Ftn { set; get; }
        [Column("away_rest")]
        public string? AwayRest { set; get; }
        [Column("home_rest")]
        public string? HomeRest { set; get; }
        [Column("away_moneyline")]
        public string? AwayMoneyline { set; get; }
        [Column("home_moneyline")]
        public string? HomeMoneyline { set; get; }
        [Column("spread_line")]
        public string? SpreadLine { set; get; }
        [Column("away_spread_odds")]
        public string? AwaySpreadOdds { set; get; }
        [Column("total_line")]
        public string? TotalLine { set; get; }
        [Column("under_odds")]
        public string? UnderOdds { set; get; }
        [Column("over_odds")]
        public string? OverOdds { set; get; }
        [Column("div_game")]
        public string? DivGame { set; get; }
        [Column("roof")]
        public string? Roof { set; get; }
        [Column("surface")]
        public string? Surface { set; get; }

    }
}
