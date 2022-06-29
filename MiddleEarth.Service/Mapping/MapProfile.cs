using AutoMapper;
using MiddleEarth.Core.DTOs;
using MiddleEarth.Core.DTOs.Requests;
using MiddleEarth.Core.DTOs.Respons;
using MiddleEarth.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleEarth.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Character, CharacterDto>().ReverseMap();
            CreateMap<Race, RaceDto>().ReverseMap();
            CreateMap<Realm, RealmDto>().ReverseMap();
            CreateMap<Weapon, WeaponDto>().ReverseMap();
            CreateMap<CharacterFeature, CharacterFeatureDto>().ReverseMap();
            CreateMap<CharacterUpdateDto, Character>();
            CreateMap<Character, CharacterWithRaceDto>();
            CreateMap<Race, RaceWithCharactersDto>();
        }
    }
}
