using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Core.Models
{
    public class Realm:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Character> Characters { get; set; }
    }
}
