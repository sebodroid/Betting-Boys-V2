using Microsoft.EntityFrameworkCore;
using Betting_Boys_V2.Server.Models;

namespace Betting_Boys_V2.Server.Repositories
{
    public class ReceivingRepository
    {
        private readonly AppDbContext _appDbContext;

        public ReceivingRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<ReceivingStats>> GetAll()
        {
            return await _appDbContext.ReceivingStats.ToListAsync();
        }

        public async Task<List<ReceivingStats>> GetAllBySeason(string season)
        {
            return await _appDbContext.ReceivingStats.Where(p => p.Season.Equals(season)).ToListAsync();
        }

        public async Task<List<ReceivingStats>> GetAllByTeam(string team)
        {
            return await _appDbContext.ReceivingStats.Where(p => p.Team.Equals(team)).ToListAsync();
        }

        public async Task<List<ReceivingStats>> GetAllBySeasonandTeam(string season, string team)
        {
            return await _appDbContext.ReceivingStats.Where(p => p.Season.Equals(season) & p.Team.Equals(team)).ToListAsync();
        }
    }
}
