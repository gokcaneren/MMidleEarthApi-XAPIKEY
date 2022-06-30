using Microsoft.EntityFrameworkCore;
using MiddleEarth.Core.Models;
using MiddleEarth.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Repository.Repositories
{
    public class WeaponRepository : GenericRepository<Weapon>, IWeaponRepository
    {
        public WeaponRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Weapon> GetWeaponByIdWithCharactersAsync(int weaponId)
        {
            return await _context.Weapons.Include(x=>x.Characters).Where(x=>x.Id==weaponId).SingleOrDefaultAsync();
        }
    }
}
