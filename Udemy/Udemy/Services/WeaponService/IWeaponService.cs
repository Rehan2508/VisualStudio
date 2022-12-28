using App.RPG.Dtos.Character;
using App.RPG.Dtos.Weapon;
using App.RPG.Models;

namespace App.RPG.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}
