using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Core.DTOs.Requests
{
    public class CharacterUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int RaceId { get; set; }
        public int? RealmId { get; set; }
        public ICollection<WeaponDto> Weapons { get; set; }
    }
}
