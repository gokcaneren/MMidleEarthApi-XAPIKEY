using AutoMapper;
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
    public class CharacterService : Service<Character>, ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly IMapper _mapper;
        public CharacterService(IGenericRepository<Character> repository, IUnitOfWork unitOfWork, ICharacterRepository characterRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _characterRepository = characterRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponsDto<List<CharacterWithRaceDto>>> GetCharacterWithRace()
        {
            var characters = await _characterRepository.GetCharactersWithRace();
            var charactersDto = _mapper.Map<List<CharacterWithRaceDto>>(characters);
            return CustomResponsDto<List<CharacterWithRaceDto>>.Success(200, charactersDto);
        }
    }
}
