using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Core.Models
{
    public class Character:BaseEntity
    {
        public string Name { get; set; }

        public int RaceId { get; set; }
        public Race Race { get; set; }

        public int RealmsId { get; set; }
        public Realms Realms { get; set; }

        public int CharacterClassId { get; set; }
        public CharacterClass CharacterClass { get; set; }

        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }

        public CharacterFeature CharacterFeature { get; set; }
    }
}
