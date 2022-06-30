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
    public class WeaponService : Service<Weapon>, IWeaponService
    {
        private readonly IWeaponRepository _weaponRepository;
        private readonly IMapper _mapper;
        public WeaponService(IGenericRepository<Weapon> repository, IUnitOfWork unitOfWork, IWeaponRepository weaponRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _weaponRepository = weaponRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponsDto<WeaponWithCharactersDto>> GetWeaponByIdWithCharactersAsync(int weaponId)
        {
            var weapon = await _weaponRepository.GetWeaponByIdWithCharactersAsync(weaponId);
            var weaponDto= _mapper.Map<WeaponWithCharactersDto>(weapon);
            return CustomResponsDto<WeaponWithCharactersDto>.Success(200, weaponDto);
        }
    }
}
