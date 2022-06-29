using AutoMapper;
using MiddleEarth.Core.DTOs;
using MiddleEarth.Core.DTOs.Respons;
using MiddleEarth.Core.Models;
using MiddleEarth.Core.Repositories;
using MiddleEarth.Core.Services;
using MiddleEarth.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Service.Services
{
    public class RaceService : Service<Race>, IRaceService
    {
        private readonly IRaceRepository _raceRepository;
        private readonly IMapper _mapper;
        public RaceService(IGenericRepository<Race> repository, IUnitOfWork unitOfWork, IRaceRepository raceRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _raceRepository = raceRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponsDto<RaceWithCharactersDto>> GetSingleRaceByIdWithCharactersAsync(int raceId)
        {
            var race = await _raceRepository.GetSingleRaceByIdWithCharactersAsync(raceId);
            var raceDto=_mapper.Map<RaceWithCharactersDto>(race);
            return CustomResponsDto<RaceWithCharactersDto>.Success(200, raceDto);
        }
    }
}
