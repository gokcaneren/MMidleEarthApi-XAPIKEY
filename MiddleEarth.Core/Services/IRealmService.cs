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
    public interface IRealmService:IService<Realm>
    {
        public Task<CustomResponsDto<RealmWithCharactersDto>> GetSingleRealmByIdWithCharactersAsync(int realmId);
    }
}
