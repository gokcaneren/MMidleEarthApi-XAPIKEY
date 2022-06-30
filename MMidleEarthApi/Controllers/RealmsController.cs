using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiddleEarth.Core.Services;

namespace MMidleEarthApi.Controllers
{
    public class RealmsController : CustomBaseController
    {
        private readonly IRealmService _realmService;

        public RealmsController(IRealmService realmService)
        {
            _realmService = realmService;
        }

        [HttpGet("[action]/{realmId}")]
        public async Task<IActionResult> GetSingleRealmByIdWithCharacters(int realmId)
        {
            return CreateActionResult(await _realmService.GetSingleRealmByIdWithCharactersAsync(realmId));
        }
    }
}
