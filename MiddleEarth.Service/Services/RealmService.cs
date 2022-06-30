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
    public class RealmService : Service<Realm>, IRealmService
    {
        private readonly IRealmRepository _realmRepository;
        private readonly IMapper _mapper;
        public RealmService(IGenericRepository<Realm> repository, IUnitOfWork unitOfWork, IMapper mapper, IRealmRepository realmRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _realmRepository = realmRepository;
        }

        public async Task<CustomResponsDto<RealmWithCharactersDto>> GetSingleRealmByIdWithCharactersAsync(int realmId)
        {
            var realm = await _realmRepository.GetSingleRealmByIdWithCharactersAsync(realmId);
            var realmDto= _mapper.Map<RealmWithCharactersDto>(realm);
            return CustomResponsDto<RealmWithCharactersDto>.Success(200, realmDto);
        }
    }
}
