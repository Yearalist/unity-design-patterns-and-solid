// GOOD EXAMPLE - Bow implements IWeapon interface

using UnityEngine;

public class BowWeapon : MonoBehaviour,IWeapon
{
    public string WeaponName => "Bow";

    public void Attack()
    {
        Debug.Log("[Bow] Shooting arrow for 15 ranged damage!");
        Debug.Log("[Bow] Playing draw animation");
        Debug.Log("[Bow] Spawning arrow projectile");
    }

    public void SpecialAbility()
    {
        Debug.Log("[Bow] Special: Rain of arrows!");
    }

    public void GetWeaponInfo()
    {
        Debug.Log("[Bow] Ranged weapon, 15 damage, long range");
    }

}
