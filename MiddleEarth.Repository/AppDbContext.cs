using Microsoft.EntityFrameworkCore;
using MiddleEarth.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Realm> Realms { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<CharacterFeature> characterFeatures { get; set; }

    }
}
