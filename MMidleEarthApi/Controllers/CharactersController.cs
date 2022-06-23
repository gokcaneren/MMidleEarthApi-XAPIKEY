using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiddleEarth.Core.DTOs;
using MiddleEarth.Core.DTOs.Respons;
using MiddleEarth.Core.Models;
using MiddleEarth.Core.Services;

namespace MMidleEarthApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
    }
}
