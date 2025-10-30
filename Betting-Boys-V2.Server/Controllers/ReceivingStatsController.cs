using Betting_Boys_V2.Server.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Betting_Boys_V2.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReceivingStatsController : Controller
    {
        private readonly ReceivingRepository _repo;

        public ReceivingStatsController(ReceivingRepository repo)
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
        public async Task<IActionResult> GetAllBySeason(string season)
        {
            var stats = await _repo.GetAllBySeason(season);
            return Ok(stats);
        }

        [HttpGet("team/{team}")]
        public async Task<IActionResult> GetAllByTeam(string team)
        {
            var stats = await _repo.GetAllByTeam(team);
            return Ok(stats);
        }

        [HttpGet("season&team/{season}/{team}")]
        public async Task<IActionResult> GetAllBySeasonandTeam(string season, string team)
        {
            var stats = await _repo.GetAllBySeasonandTeam(season, team);
            return Ok(stats);
        }
    }
}
