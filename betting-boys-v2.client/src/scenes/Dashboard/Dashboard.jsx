import React from 'react'
import "./Dashboard.css"
import GameCard from '../../components/GameCard/GameCard'

const dummyGames = [
  {
    date: "Thu, 10/30, 8:15PM",
    teams: [
      { name: "Ravens", record: "2-5", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/406.svg" },
      { name: "Dolphins", record: "2-6", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/418.svg" }
    ],
    odds: { overUnder: "o50.5", spread: "+7.5" },
    analysisLink: "/PlayerProps"
  },
  {
    date: "Sun, 11/3, 1:00PM",
    teams: [
      { name: "Packers", record: "4-3", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/417.svg" },
      { name: "Bears", record: "3-4", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/419.svg" }
    ],
    odds: { overUnder: "o46.0", spread: "-3.0" },
    analysisLink: "/PlayerProps"
  },
  {
    date: "Sun, 11/3, 1:00PM",
    teams: [
      { name: "Falcons", record: "3-4", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/420.svg" },
      { name: "Patriots", record: "6-2", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/421.svg" }
    ],
    odds: { overUnder: "o45.0", spread: "-5.5" },
    analysisLink: "/PlayerProps"
  },
  {
    date: "Sun, 11/3, 1:00PM",
    teams: [
      { name: "Panthers", record: "4-4", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/422.svg" },
      { name: "Packers", record: "5-1-1", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/423.svg" }
    ],
    odds: { overUnder: "o44.5", spread: "-13.5" },
    analysisLink: "/PlayerProps"
  },
  {
    date: "Sun, 11/3, 1:00PM",
    teams: [
      { name: "Bengals", record: "3-5", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/424.svg" },
      { name: "Browns", record: "4-3", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/425.svg" }
    ],
    odds: { overUnder: "o51.5", spread: "+3.0" },
    analysisLink: "/PlayerProps"
  },
  {
    date: "Sun, 11/3, 4:05PM",
    teams: [
      { name: "Cowboys", record: "6-2", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/426.svg" },
      { name: "Giants", record: "3-5", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/427.svg" }
    ],
    odds: { overUnder: "o47.5", spread: "-6.5" },
    analysisLink: "/PlayerProps"
  },
  {
    date: "Sun, 11/3, 4:25PM",
    teams: [
      { name: "Seahawks", record: "5-3", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/428.svg" },
      { name: "49ers", record: "6-2", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/429.svg" }
    ],
    odds: { overUnder: "o50.0", spread: "+2.0" },
    analysisLink: "/PlayerProps"
  },
  {
    date: "Sun, 11/3, 8:20PM",
    teams: [
      { name: "Raiders", record: "3-5", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/430.svg" },
      { name: "Chargers", record: "4-3", logo: "https://sports.cbsimg.net/fly/images/team-logos/alt/431.svg" }
    ],
    odds: { overUnder: "o51.0", spread: "-1.5" },
    analysisLink: "/PlayerProps"
  }
];

const Dashboard = () => {
  return (
    <div className='page-wrapper'>
        <div className='game-cards'>
            {dummyGames.map((game, index) => (
                <GameCard key={index} game={game} />
            ))}
        </div>
    </div>
  )
}

export default Dashboard
