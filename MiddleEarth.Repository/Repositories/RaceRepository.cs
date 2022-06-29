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
    public class RaceRepository : GenericRepository<Race>, IRaceRepository
    {
        public RaceRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Race> GetSingleRaceByIdWithCharactersAsync(int raceId)
        {
            return await _context.Races.Include(x => x.Characters).Where(x => x.Id == raceId).SingleOrDefaultAsync();
        }
    }
}
