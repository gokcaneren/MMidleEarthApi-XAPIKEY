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
    public class CharacterRepository : GenericRepository<Character>, ICharacterRepository
    {
        public CharacterRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Character>> GetCharactersWithRace()
        {
            //Eager Loading!
            return await _context.Characters.Include(x=>x.Race).ToListAsync();
        }
    }
}
