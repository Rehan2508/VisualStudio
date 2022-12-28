using AutoMapper;
using App.RPG.Dtos.Character;
using App.RPG.Models;
using App.RPG.Dtos.Weapon;
using App.RPG.Dtos.Skill;
using App.RPG.Dtos.Fight;

namespace App.RPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighScoreDto>();
        }
    }
}
