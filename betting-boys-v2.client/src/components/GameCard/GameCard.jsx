import React from "react";
import "./GameCard.css";

const TEAM_LOGOS = {
  HOU: "https://sports.cbsimg.net/fly/images/team-logos/alt/247415.svg",
  ARI: "https://sports.cbsimg.net/fly/images/team-logos/alt/404.svg",
  ATL: "https://sports.cbsimg.net/fly/images/team-logos/alt/405.svg",
  BAL: "https://sports.cbsimg.net/fly/images/team-logos/alt/406.svg",
  BUF: "https://sports.cbsimg.net/fly/images/team-logos/alt/407.svg",
  CAR: "https://sports.cbsimg.net/fly/images/team-logos/alt/408.svg",
  CHI: "https://sports.cbsimg.net/fly/images/team-logos/alt/409.svg",
  CIN: "https://sports.cbsimg.net/fly/images/team-logos/alt/410.svg",
  DAL: "https://sports.cbsimg.net/fly/images/team-logos/alt/411.svg",
  DEN: "https://sports.cbsimg.net/fly/images/team-logos/alt/412.svg",
  DET: "https://sports.cbsimg.net/fly/images/team-logos/alt/413.svg",
  GB: "https://sports.cbsimg.net/fly/images/team-logos/alt/414.svg",
  IND: "https://sports.cbsimg.net/fly/images/team-logos/alt/415.svg",
  JAX: "https://sports.cbsimg.net/fly/images/team-logos/alt/416.svg",
  KC: "https://sports.cbsimg.net/fly/images/team-logos/alt/417.svg",
  MIA: "https://sports.cbsimg.net/fly/images/team-logos/alt/418.svg",
  MIN: "https://sports.cbsimg.net/fly/images/team-logos/alt/419.svg",
  NE: "https://sports.cbsimg.net/fly/images/team-logos/alt/420.svg",
  NO: "https://sports.cbsimg.net/fly/images/team-logos/alt/421.svg",
  NYG: "https://sports.cbsimg.net/fly/images/team-logos/alt/422.svg",
  NYJ: "https://sports.cbsimg.net/fly/images/team-logos/alt/423.svg",
  LV: "https://sports.cbsimg.net/fly/images/team-logos/alt/424.svg",
  PHI: "https://sports.cbsimg.net/fly/images/team-logos/alt/425.svg",
  PIT: "https://sports.cbsimg.net/fly/images/team-logos/alt/426.svg",
  LA: "https://sports.cbsimg.net/fly/images/team-logos/alt/427.svg",
  LAC: "https://sports.cbsimg.net/fly/images/team-logos/alt/428.svg",
  SF: "https://sports.cbsimg.net/fly/images/team-logos/alt/429.svg",
  SEA: "https://sports.cbsimg.net/fly/images/team-logos/alt/430.svg",
  TB: "https://sports.cbsimg.net/fly/images/team-logos/alt/431.svg",
  TEN: "https://sports.cbsimg.net/fly/images/team-logos/alt/432.svg",
  WAS: "https://sports.cbsimg.net/fly/images/team-logos/alt/433.svg",
  CLE: "https://sports.cbsimg.net/fly/images/team-logos/alt/434.svg",
};

const getLogo = (teamCode) =>
  TEAM_LOGOS[teamCode] ||
  // fallback: show the team code as an SVG data URL (simple text fallback)
  `data:image/svg+xml;utf8,${encodeURIComponent(
    `<svg xmlns='http://www.w3.org/2000/svg' width='120' height='120'><rect width='100%' height='100%' fill='%23e2e8f0'/><text x='50%' y='50%' dominant-baseline='middle' text-anchor='middle' font-size='28' fill='%23333'>${teamCode}</text></svg>`
  )}`;

const GameCard = ({ game }) => {
  if (!game) return null;

  const date = `${game.weekday ?? ""}${game.weekday ? ", " : ""}${game.gameday ?? ""}${
    game.gameTime ? `, ${game.gameTime}` : ""
  }`;

  const teams = [
    {
      code: game.awayTeam,
      name: game.awayTeam,
      record: game.awayRecord ?? "",
      logo: getLogo(game.awayTeam),
      moneyline: game.awayMoneyline,
    },
    {
      code: game.homeTeam,
      name: game.homeTeam,
      record: game.homeRecord ?? "",
      logo: getLogo(game.homeTeam),
      moneyline: game.homeMoneyline,
    },
  ];

  const odds = {
    overUnder: game.totalLine ?? game.total ?? game.totalLine,
    spread: game.spreadLine ?? game.spreadLine,
  };

  const analysisLink = game.analysisLink ?? "#";

  return (
    <div className="game-card">
      <span className="game-date">{date}</span>

      <table>
        <tbody>
          {/* Away team row */}
          <tr>
            <td>
              <div className="team">
                <img src={teams[0].logo} className="logo" alt={`${teams[0].code} logo`} />
                <div className="team-name">{teams[0].name}</div>
                {teams[0].record && <div className="record">{teams[0].record}</div>}
              </div>
            </td>
            <td>
              <div className="odds-cell">
                <div className="over-under">{odds.overUnder ?? ""}</div>
              </div>
            </td>
          </tr>

          {/* Home team row */}
          <tr>
            <td>
              <div className="team">
                <img src={teams[1].logo} className="logo" alt={`${teams[1].code} logo`} />
                <div className="team-name">{teams[1].name}</div>
                {teams[1].record && <div className="record">{teams[1].record}</div>}
              </div>
            </td>
            <td>
              <div className="odds-cell">
                <div className="spread">{odds.spread ?? ""}</div>
              </div>
            </td>
          </tr>
        </tbody>
      </table>

      <a className="bottom-bar" href={analysisLink}>
        <p>Game Analysis</p>
      </a>
    </div>
  );
};

export default GameCard;
