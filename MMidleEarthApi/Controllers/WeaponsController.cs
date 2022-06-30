using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiddleEarth.Core.Services;

namespace MMidleEarthApi.Controllers
{
    public class WeaponsController : CustomBaseController
    {
        private readonly IWeaponService _weaponService;

        public WeaponsController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpGet("[action]/{weaponId}")]
        public async Task<IActionResult> GetWeaponByIdWithCharacters(int weaponId)
        {
            return CreateActionResult(await _weaponService.GetWeaponByIdWithCharactersAsync(weaponId));
        }
    }
}
