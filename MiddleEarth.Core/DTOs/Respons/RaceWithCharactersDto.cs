﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Core.DTOs
{
    public class RaceWithCharactersDto:RaceDto
    {
        public List<CharacterDto> Characters { get; set; }
    }
}
