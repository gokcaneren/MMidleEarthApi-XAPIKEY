using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Core.Models
{
    public class CharacterFeature
    {
        public int Id { get; set; }
        public string Sex { get; set; }
        public int Height { get; set; }
        public string Eyes { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
