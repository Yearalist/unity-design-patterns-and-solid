// BAD EXAMPLE - Violates Open/Closed Principle


using UnityEngine;

public class WeaponManagerBad : MonoBehaviour
{

    public enum WeaponType
    {
        Sword,
        Bow,
        Magic
    }

    public WeaponType currentWeapon;


    public void Attack()
    {
        if (currentWeapon == WeaponType.Sword)
        {
            Debug.Log("[Weapon] Swinging sword for 20 melee damage!");
            Debug.Log("[Weapon] Playing slash animation");
            Debug.Log("[Weapon] Applying close range hit detection");
        }
        else if (currentWeapon == WeaponType.Bow)
        {
            Debug.Log("[Weapon] Shooting arrow for 15 ranged damage!");
            Debug.Log("[Weapon] Playing draw animation");
            Debug.Log("[Weapon] Spawning arrow projectile");
        }
        else if (currentWeapon == WeaponType.Magic)
        {
            Debug.Log("[Weapon] Casting fireball for 25 magic damage!");
            Debug.Log("[Weapon] Playing cast animation");
            Debug.Log("[Weapon] Spawning fireball with area effect");
        }
    }


    public void SpecialAbility()
    {
        if (currentWeapon == WeaponType.Sword)
        {
            Debug.Log("[Weapon] Sword special: Whirlwind slash!");
        }
        else if (currentWeapon == WeaponType.Bow)
        {
            Debug.Log("[Weapon] Bow special: Rain of arrows!");
        }
        else if (currentWeapon == WeaponType.Magic)
        {
            Debug.Log("[Weapon] Magic special: Meteor shower!");
        }
    }


    public void GetWeaponInfo()
    {
        if (currentWeapon == WeaponType.Sword)
        {
            Debug.Log("[Weapon] Sword - Melee weapon, 20 damage, short range");
        }
        else if (currentWeapon == WeaponType.Bow)
        {
            Debug.Log("[Weapon] Bow - Ranged weapon, 15 damage, long range");
        }
        else if (currentWeapon == WeaponType.Magic)
        {
            Debug.Log("[Weapon] Magic - Spell weapon, 25 damage, area effect");
        }
    }
}




