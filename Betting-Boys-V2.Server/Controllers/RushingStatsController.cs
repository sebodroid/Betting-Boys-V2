using Betting_Boys_V2.Server.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Betting_Boys_V2.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RushingStatsController : Controller
    {
        private readonly RushingRepository _repo;

        public RushingStatsController(RushingRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var stats = await _repo.GetAll();
            return Ok(stats);
        }

        [HttpGet("season/{season}")]
        public async Task<IActionResult> GetStatsBySeason(string season)
        {
            var stats = await _repo.GetStatsBySeason(season);
            return Ok(stats);
        }

        [HttpGet("team/{team}")]
        public async Task<IActionResult> GetStatsByTeam(string team)
        {
            var stats = await _repo.GetStatsByTeam(team);
            return Ok(stats);
        }

        [HttpGet("season&team/{season}/{team}")]
        public async Task<IActionResult> GetStatsBySeasonandTeam(string season, string team)
        {
            var stats = await _repo.GetStatsBySeasonandTeam(season, team);
            return Ok(stats);
        }
    }
}
