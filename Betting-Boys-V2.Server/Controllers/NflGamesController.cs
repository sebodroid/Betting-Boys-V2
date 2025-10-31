using Betting_Boys_V2.Server.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Betting_Boys_V2.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NflSeasonController : Controller
    {
        private readonly NflSeasonRepository _repo;

        public NflSeasonController(Repositories.NflSeasonRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? week = null)
        {
            var seasonGames = await _repo.GetGamesByWeek(week);
            return Ok(seasonGames);
        }

        [HttpGet("week")]
        public IActionResult GetWeek()
        {
            string week = GetCurrentNFLWeek.GetWeek();
            return Ok(new { week });
        }
    }
}
