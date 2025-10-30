import React from 'react'
import "./GameCard.css"

const GameCard = ({ game }) => {
  const { date, teams, odds, analysisLink } = game;

  return (
    <div className='game-card'>
      <span className='game-date'>{date}</span>
      <table>
        <tbody>
          <tr>
            <td>
              <div className='team'>
                <img src={teams[0].logo} className="logo" alt={`${teams[0].name} logo`} />
                <div className='team-name'>{teams[0].name}</div>
                <div className='record'>{teams[0].record}</div>
              </div>
            </td>
            <td>
              <span className='over-under'>{odds.overUnder}</span>
            </td>
          </tr>
          <tr>
            <td>
              <div className='team'>
                <img src={teams[1].logo} className="logo" alt={`${teams[1].name} logo`} />
                <div className='team-name'>{teams[1].name}</div>
                <div className='record'>{teams[1].record}</div>
              </div>
            </td>
            <td>
              <span className='spread'>{odds.spread}</span>
            </td>
          </tr>
        </tbody>
      </table>

      <a className="bottom-bar" href={analysisLink}>
          <p>Game Analysis</p>
      </a>
    </div>
  );
}


export default GameCard
