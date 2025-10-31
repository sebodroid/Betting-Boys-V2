import React, { useEffect, useState } from "react";
import "./Dashboard.css"
import GameCard from '../../components/GameCard/GameCard'
import axios from "axios";

const Dashboard = () => {
  const [data, setData] = useState([]);
  const [loading, setLoading] = useState(true);
  const [week, setWeek] = useState(9);

  useEffect(() => {
    const fetchNflData = async () => {
      try {
        const response = await axios.get(`http://localhost:5146/api/NflSeason?week=${week}`);
        setData(response.data);
      } catch (error) {
        console.error("Error fetching NflSeason data:", error);
      } finally {
        setLoading(false);
      }
    };

    fetchNflData();
  }, [week]);
  
  return (
    <div className="page-wrapper">
      <div className="game-cards">
        {loading ? (
          <p>Loading games...</p>
        ) : data.length > 0 ? (
          data.map((game, index) => <GameCard key={index} game={game} />)
        ) : (
          <p>No games found for this week.</p>
        )}
      </div>
      <div className="get-week">
        <button onClick={() => setWeek(1)} aria-label="go to week 1">«1</button>
        <button onClick={() => setWeek(prev => Math.max(1, prev - 1))} aria-label="previous week">‹</button>
        <span className="current-week">{week}</span>
        <button onClick={() => setWeek(prev => Math.min(17, prev + 1))} aria-label="next week">›</button>
        <button onClick={() => setWeek(17)} aria-label="go to week 17">17»</button>
      </div>
    </div>
  )
}

export default Dashboard
