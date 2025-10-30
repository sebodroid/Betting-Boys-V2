using Betting_Boys_V2.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Betting_Boys_V2.Server.Repositories
{
    public class RushingRepository
    {
        private readonly AppDbContext _appDbContext;

        public RushingRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<RushingStats>> GetAll()
        {
            return await _appDbContext.RushingStats.ToListAsync();
        }

        public async Task<List<RushingStats>> GetStatsBySeason(string season)
        {
            return await _appDbContext.RushingStats.Where(p  => p.Season.Equals(season)).ToListAsync();
        }

        public async Task<List<RushingStats>> GetStatsByTeam(string team)
        {
            return await _appDbContext.RushingStats.Where(p => p.Team.Equals(team)).ToListAsync();
        }

        public async Task<List<RushingStats>> GetStatsBySeasonandTeam(string season, string team)
        {
            return await _appDbContext.RushingStats.Where(p => p.Season.Equals(season) &  p.Team.Equals(team)).ToListAsync();
        }
    }
}
