using Betting_Boys_V2.Server.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Betting_Boys_V2.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PassingStatsController : Controller
    {

        private readonly PassingRepository _repo;

        public PassingStatsController(PassingRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var passingStats = await _repo.GetAllStats();
            return Ok(passingStats);
        }

        [HttpGet("season/{season}")]
        public async Task<IActionResult> GetStatsBySeason(string season)
        {
            var passingStats = await _repo.GetStatsBySeason(season);
            return Ok(passingStats);
        }

        [HttpGet("season&week/{season}/{week}")]
        public async Task<IActionResult> GetStatsSeasonandWeek(string season, string week)
        {
            var passingStats = await _repo.GetStatsSeasonandWeek(season, week);
            return Ok(passingStats);
        }

        [HttpGet("season&team/{season}/{team}")]
        public async Task<IActionResult> GetStatsSeasonandTeam(string season, string team)
        {
            var passingStats = await _repo.GetStatsSeasonandTeam(season, team);
            return Ok(passingStats);
        }

        [HttpGet("season&week&team/{season}/{week}/{team}")]
        public async Task<IActionResult> GetStatsSeasonWeekandTeam(string season, string week, string team)
        {
            var passingStats = await _repo.GetStatsSeasonWeekandTeam(season, week, team);
            return Ok(passingStats);
        }

    }
}
