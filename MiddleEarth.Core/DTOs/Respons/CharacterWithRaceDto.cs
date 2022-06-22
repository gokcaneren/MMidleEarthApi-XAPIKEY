using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Core.DTOs.Respons
{
    public class CharacterWithRaceDto:CharacterDto
    {
        public RaceDto Race { get; set; }
    }
}
