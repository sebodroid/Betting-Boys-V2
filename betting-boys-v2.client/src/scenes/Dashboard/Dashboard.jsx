import React, { useEffect, useState } from "react";
import "./Dashboard.css"
import GameCard from '../../components/GameCard/GameCard'
import axios from "axios";

const Dashboard = () => {
  const [data, setData] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchNflData = async () => {
      try {
        const response = await axios.get("http://localhost:5146/api/NflSeason?week=9");
        setData(response.data);
      } catch (error) {
        console.error("Error fetching NflSeason data:", error);
      } finally {
        setLoading(false);
      }
    };

    fetchNflData();
  }, []);
  
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
    </div>
  )
}

export default Dashboard
