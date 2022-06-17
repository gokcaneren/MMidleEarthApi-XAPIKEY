using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiddleEarth.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Repository.Configurations
{
    internal class CharacterFeatureConfiguration : IEntityTypeConfiguration<CharacterFeature>
    {
        public void Configure(EntityTypeBuilder<CharacterFeature> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.HasOne(c => c.Character).WithOne(c => c.CharacterFeature)
                .HasForeignKey<CharacterFeature>(c => c.CharacterId);
        }
    }
}
