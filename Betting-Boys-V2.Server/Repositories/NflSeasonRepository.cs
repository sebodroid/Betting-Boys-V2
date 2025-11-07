using Betting_Boys_V2.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Betting_Boys_V2.Server.Repositories
{
    public class NflSeasonRepository
    {
        private readonly AppDbContext _appDbContext;

        public NflSeasonRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<NflSchedule>> GetAllGames()
        {
            return await _appDbContext.NflSchedule.ToListAsync();
        }
        public async Task<List<NflSchedule>> GetGamesByWeek(string? week)
        {
            if (string.IsNullOrEmpty(week))
            {
                return await _appDbContext.NflSchedule.ToListAsync();
            }

            return await _appDbContext.NflSchedule
                .Where(game => game.Week == week)
                .ToListAsync();
        }

        public async Task<List<Game>> GetGameProps(string? week)
        {
            return await _appDbContext.Game.Where(game => game.Week.Equals(week)).ToListAsync();
        }
    }
}
