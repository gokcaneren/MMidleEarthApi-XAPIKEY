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
    internal class CharacterSeed : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.HasData(
                new Character
                {
                    Id = 1,
                    Name = "Gandalf",
                    ImageUrl = "https://static.wikia.nocookie.net/lotr/images/e/e7/Gandalf_the_Grey.jpg/revision/latest/scale-to-width-down/350?cb=20121110131754",
                    RaceId = 7,
                    RealmId = null,
                },
                new Character
                {
                    Id = 2,
                    Name = "Melkor",
                    ImageUrl = "https://static.wikia.nocookie.net/lotr/images/8/82/Melkor_by_formenost.jpg/revision/latest/scale-to-width-down/350?cb=20121205131822",
                    RaceId = 8,
                    RealmId = null,
                }
                );
        }
    }
}
