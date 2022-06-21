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
        public string ImageUrl { get; set; }
        public int RaceId { get; set; }
        public Race Race { get; set; }

        public int? RealmId { get; set; }
        public Realm? Realm { get; set; }

        public ICollection<Weapon> Weapons { get; set; }

        public CharacterFeature CharacterFeature { get; set; }
    }
}
