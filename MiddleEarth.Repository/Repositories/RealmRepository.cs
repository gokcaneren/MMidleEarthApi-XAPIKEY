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
    public class RealmRepository : GenericRepository<Realm>, IRealmRepository
    {
        public RealmRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Realm> GetSingleRealmByIdWithCharactersAsync(int realmId)
        {
            return await _context.Realms.Include(x=>x.Characters).Where(x=>x.Id==realmId).SingleOrDefaultAsync();
        }
    }
}
