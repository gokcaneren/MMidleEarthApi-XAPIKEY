using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiddleEarth.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Repository.Seeds
{
    internal class WeaponSeed : IEntityTypeConfiguration<Weapon>
    {
        public void Configure(EntityTypeBuilder<Weapon> builder)
        {
            builder.HasData(
                new Weapon
                {
                    Id = 1,
                    Name = "Sword"
                },
                new Weapon
                {
                    Id = 2,
                    Name = "Bow"
                },
                new Weapon
                {
                    Id = 3,
                    Name = "Spear"
                },
                new Weapon
                {
                    Id = 4,
                    Name = "Staff"
                },
                new Weapon
                {
                    Id = 5,
                    Name = "Axe"
                },
                new Weapon
                {
                    Id = 6,
                    Name = "Hammer"
                }
                );
        }
    }
}
