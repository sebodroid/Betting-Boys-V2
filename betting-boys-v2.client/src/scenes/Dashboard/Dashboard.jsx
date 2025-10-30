import React from 'react'
import "./Dashboard.css"
import GameCard from '../../components/GameCard/GameCard'

const Dashboard = () => {
  return (
    <div className='page-wrapper'>
        <div className='game-cards'>
            <GameCard />
        </div>
    </div>
  )
}

export default Dashboard
