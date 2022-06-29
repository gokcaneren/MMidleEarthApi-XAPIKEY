using MiddleEarth.Core.DTOs;
using MiddleEarth.Core.DTOs.Respons;
using MiddleEarth.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Core.Services
{
    public interface IRaceService:IService<Race>
    {
        public Task<CustomResponsDto<RaceWithCharactersDto>> GetSingleRaceByIdWithCharactersAsync(int raceId);
    }
}
