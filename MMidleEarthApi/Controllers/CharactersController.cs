using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiddleEarth.Core.DTOs;
using MiddleEarth.Core.DTOs.Requests;
using MiddleEarth.Core.DTOs.Respons;
using MiddleEarth.Core.Models;
using MiddleEarth.Core.Services;

namespace MMidleEarthApi.Controllers
{
    public class CharactersController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Character> _service;

        public CharactersController(IService<Character> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var characters=await _service.GetAllAsync();
            var charactersDtos=_mapper.Map<List<CharacterDto>>(characters.ToList());
            return CreateActionResult(CustomResponsDto<List<CharacterDto>>.Success(200, charactersDtos));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var character = await _service.GetByIdAsync(id);
            var characterDto= _mapper.Map<CharacterDto>(character);
            return CreateActionResult(CustomResponsDto<CharacterDto>.Success(200, characterDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CharacterDto characterDto)
        {
            var character = await _service.AddAsync(_mapper.Map<Character>(characterDto));
            var charactersDto = _mapper.Map<CharacterDto>(character);
            return CreateActionResult(CustomResponsDto<CharacterDto>.Success(201, charactersDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(CharacterUpdateDto characterDto)
        {
            await _service.UpdateAsync(_mapper.Map<Character>(characterDto));
            return CreateActionResult(CustomResponsDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var character = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(character);
            return CreateActionResult(CustomResponsDto<NoContentDto>.Success(204));
        }
    }
}
