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
    internal class CharacterFeatureSeed : IEntityTypeConfiguration<CharacterFeature>
    {
        public void Configure(EntityTypeBuilder<CharacterFeature> builder)
        {
            builder.HasData(
                new CharacterFeature
                {
                    Id = 1,
                    Sex = "Male",
                    Eyes = "Blue",
                    Hair = "Grey",
                    Height = 168,
                    CharacterId = 1,
                },
                new CharacterFeature
                {
                    Id = 2,
                    Sex = "Valar",
                    Height = 300,
                    Hair = "Black",
                    Eyes = "Black",
                    CharacterId = 2,
                }
                );
        }
    }
}
