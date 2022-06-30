using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiddleEarth.Core.Services;

namespace MMidleEarthApi.Controllers
{
    public class RacesController : CustomBaseController
    {
        private readonly IRaceService _raceService;

        public RacesController(IRaceService raceService)
        {
            _raceService = raceService;
        }

        [HttpGet("[action]/{raceId}")]
        public async Task<IActionResult> GetSingleRaceByIdWithCharacters(int raceId)
        {
            return CreateActionResult(await _raceService.GetSingleRaceByIdWithCharactersAsync(raceId));
        }
    }
}
