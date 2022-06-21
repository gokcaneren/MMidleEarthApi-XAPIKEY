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
    internal class CharacterConfiguration : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(75);

            builder.HasOne(r => r.Race).WithMany(c => c.Characters).HasForeignKey(c => c.RaceId);
            builder.HasOne(r => r.Realm).WithMany(c => c.Characters).HasForeignKey(c => c.RealmId);

            builder.HasMany(w => w.Weapons).WithMany(c => c.Characters);
        }
    }
}
