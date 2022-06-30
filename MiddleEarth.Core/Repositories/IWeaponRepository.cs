using MiddleEarth.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Core.Repositories
{
    public interface IWeaponRepository:IGenericRepository<Weapon>
    {
        Task<Weapon> GetWeaponByIdWithCharactersAsync(int weaponId);
    }
}
