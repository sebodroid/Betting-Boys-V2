import React from 'react'
import "./GameCard.css"

const GameCard = () => {
  return (
    <div>
      <div className='game-card'>
        <span className='game-date'>Thu, 10/30, 8:15PM</span>
        <table>
          <tbody>
            <tr>
              <td>
                <div className='team'>
                  <img src="https://sports.cbsimg.net/fly/images/team-logos/alt/406.svg" class="logo" alt="nfl team logo"></img>
                  <div className='team-name'>Ravens</div>
                  <div className='record'>2-5</div>
                </div>
              </td>
            </tr>
            <tr>
              <td>
                <div className='team'>
                  <img src="https://sports.cbsimg.net/fly/images/team-logos/alt/418.svg" class="logo" alt="nfl team logo"></img>
                  <div className='team-name'>Dolphins</div>
                  <div className='record'>2-6</div>
                </div>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  )
}

export default GameCard
