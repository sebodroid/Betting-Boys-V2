using Betting_Boys_V2.Server.Models;
using Microsoft.EntityFrameworkCore;
namespace Betting_Boys_V2.Server.Repositories
{
    public class PassingRepository
    {
        private readonly AppDbContext _appDbContext;

        public PassingRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<PassingStats>> GetAllStats()
        {
            return await _appDbContext.PassingStats.ToListAsync();
        }

        public async Task<List<PassingStats>> GetStatsBySeason(string season)
        {
            return await _appDbContext.PassingStats.Where(b => b.Season.Equals(season)).ToListAsync();
        }
        
        public async Task<List<PassingStats>> GetStatsSeasonandWeek(string season, string week)
        {
            return await _appDbContext.PassingStats.Where(b => b.Season.Equals(season) & b.Week.Equals(week)).ToListAsync();
        }
        public async Task<List<PassingStats>> GetStatsSeasonandTeam(string season, string team)
        {
            return await _appDbContext.PassingStats.Where(b => b.Season.Equals(season) & b.Team.Equals(team)).ToListAsync();
        }
        public async Task<List<PassingStats>> GetStatsSeasonWeekandTeam(string season, string week, string team)
        {
            return await _appDbContext.PassingStats.Where(b => b.Season.Equals(season) & b.Week.Equals(week) & b.Team.Equals(team)).ToListAsync();
        }
    }
     
}
